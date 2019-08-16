using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MorseUtils {
	class VibrationalCalculator {
		private static double target, omega2, rho, omega1Min, omega1Max;
		private static int vMin, vMax;
		private static int maxThreads = (int)(Environment.ProcessorCount * .5);
		private static SemaphoreSlim threadPool = new SemaphoreSlim(1, maxThreads);

		public VibrationalCalculator(double target, double omega2, double rho, double omega1Min, double omega1Max, int vMin, int vMax) {
			VibrationalCalculator.target = target;
			VibrationalCalculator.omega2 = omega2;
			VibrationalCalculator.rho = rho;
			VibrationalCalculator.omega1Min = omega1Min;
			VibrationalCalculator.omega1Max = omega1Max;
			VibrationalCalculator.vMin = vMin;
			VibrationalCalculator.vMax = vMax;
		}

		public string Calculate(double increment) {
			SortedList<int, double> vResults = new SortedList<int, double>();
			Task[] tasks = new Task[vMax + 1];

			for (int v = vMin; v <= vMax; v++) {
				int currentV = v;
				tasks[currentV] = Task.Factory.StartNew(() => GetMin(currentV, increment, vResults));
			}

			Task.WaitAll(tasks);

			StringBuilder results = new StringBuilder();
			foreach(KeyValuePair<int, double> result in vResults) {
				results.AppendLine(("v=" + $"{result.Key}:".PadLeft(3)).PadRight(7) + $"{result.Value}cm-1");
			}
			return results.ToString();
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>")]
		private static void GetMin(int v, double increment, SortedList<int, double> vResults) {
			threadPool.WaitAsync();

			double currentDiff = double.MaxValue;
			double bestOmega = double.MaxValue;

			for (double omega = omega1Min; omega <= omega1Max; omega += increment) {
				double newDiff = Math.Abs(target - GetDiff(omega, v));

				if (newDiff < currentDiff) {
					bestOmega = omega;
					currentDiff = newDiff;
				}
			}

			lock (vResults) {
				vResults.Add(v, bestOmega);
			}

			threadPool.Release();
		}

		private static double GetDiff(double omega, int v) {
			return omega * (rho - 1) * (v + 0.5) - (omega2 * (rho - 1) * 0.5);
		}
	}
}
