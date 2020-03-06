using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MorseUtils {
	public static class AbundanceCalculator {

		/// <summary>
		/// Method to calculate mass abundances for given array of Elements
		/// </summary>
		/// <param name="elements">Array of Elements to calculate mass abundances for</param>
		/// <param name="exact">If true, returns exact masses; returns rounded masses otherwise</param>
		/// <returns></returns>
		public static Dictionary<double, double> Calculate(Element[] elements, bool exact) {
			List<KeyValuePair<double, double>> isotopes = new List<KeyValuePair<double, double>>();
			foreach (Element e in elements) {
				foreach (KeyValuePair<double, double> isotope in e.Isotopes) {
					if (exact) {
						isotopes.Add(new KeyValuePair<double, double>(isotope.Key, isotope.Value));
					} else {
						isotopes.Add(new KeyValuePair<double, double>(Math.Round(isotope.Key), isotope.Value));
					}
				}
			}

			// Dictionary to store all combined masses in
			Dictionary<double, double> masses = new Dictionary<double, double>();

			Recurse(isotopes, masses, 1, isotopes[0].Key, isotopes[0].Value);

			return masses;
		}

		private static void Recurse(List<KeyValuePair<double, double>> isotopes, Dictionary<double, double> masses, int start, double mass, double abundance) {
			KeyValuePair<double, double> currentIsotope = isotopes[start];
			while (start < isotopes.Count) {
				Recurse(isotopes, masses, start + 1, mass + isotopes[start].Key, abundance * isotopes[start].Value);
				masses.Add(mass)
			}
			masses.Add(mass, abundance);
			return;
		}

		/// <summary>
		/// Overload that assumes approximate isotopes are wanted
		/// </summary>
		/// <param name="elements">Array of Elements to calculate mass abundances for</param>
		/// <returns></returns>
		public static Dictionary<double, double> Calculate(Element[] elements) {
			return Calculate(elements, false);
		}

		/// <summary>
		/// Overload that parses a string representation of a chemical formula and passes it as an Element[]
		/// </summary>
		/// <param name="formula"></param>
		/// <param name="exact"></param>
		/// <returns></returns>
		public static Dictionary<double, double> Calculate(string formula, bool exact, ElementList elist) {
			string[] elementNames = Regex.Split(formula, @"(?<!^)(?=[A-Z])");
			Element[] elements = new Element[elementNames.Length];
			for (int e = 0; e < elementNames.Length; e++) {
				elements[e] = elist.GetElement(elementNames[e]);
			}
			return Calculate(elements, exact);
		}

		/// <summary>
		/// Overload that parses a string representation of a chemical formula and passes it as an Element[], assuming exact==false
		/// </summary>
		/// <param name="formula"></param>
		/// <param name="elist"></param>
		/// <returns></returns>
		public static Dictionary<double, double> Calculate(string formula, ElementList elist) {
			return Calculate(formula, false, elist);
		}
	}
}
