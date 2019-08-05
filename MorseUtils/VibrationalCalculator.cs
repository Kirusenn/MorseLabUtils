using System;
using System.Text;

namespace MorseUtils {
	class VibrationalCalculator {
		private double target, omega2, rho, omega1Min, omega1Max;
		private int vMin, vMax;

		public VibrationalCalculator(double target, double omega2, double rho, double omega1Min, double omega1Max, int vMin, int vMax) {
			this.target = target;
			this.omega2 = omega2;
			this.rho = rho;
			this.omega1Min = omega1Min;
			this.omega1Max = omega1Max;
			this.vMin = vMin;
			this.vMax = vMax;
		}

		public string Calculate(double increment) {
			StringBuilder results = new StringBuilder();

			for (int v = vMin; v < vMax + 1; v++) {
				double currentDiff = double.MaxValue;
				double bestOmega = double.MaxValue;

				for (double omega = omega1Min; omega < omega1Max + increment; omega += increment) {
					double newDiff = Math.Abs(target - GetDiff(omega, v));


					if (newDiff < currentDiff) {
						bestOmega = omega;
						currentDiff = newDiff;
					}
				}

				results.AppendLine($"v={v}:\t{bestOmega}cm-1");
			}

			return results.ToString();
		}

		private double GetDiff(double omega, int v) {
			return omega * (rho - 1) * (v + 0.5) - (omega2 * (rho - 1) * 0.5);
		}
	}
}
