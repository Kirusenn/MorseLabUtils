using System;
using System.Collections.Generic;

namespace MorseUtils {
	public static class AbundanceCalculator {

		/// <summary>
		/// Method to calculate mass abundances for given array of Elements
		/// </summary>
		/// <param name="elements">Array of Elements to calculate mass abundances for</param>
		/// <param name="exact">If true, returns exact masses; returns rounded masses otherwise</param>
		/// <returns></returns>
		public static Dictionary<double, double> Calculate(Element[] elements, bool exact) {
			Element[] elementsCopy = new Element[elements.Length];
			Array.Copy(elements, 0, elementsCopy, 0, elements.Length);

			Dictionary<double, double> masses = new Dictionary<double, double>();

			for (int a1 = 0; a1 < elements.Length; a1++) {
				Element e1 = elements[a1];
				foreach (KeyValuePair<double, double> i1 in e1.Isotopes) {
					
					for (int a2 = 0; a2 < elementsCopy.Length; a2++) {
						Element e2 = elements[a2];
						foreach (KeyValuePair<double, double> i2 in e2.Isotopes) {
							double mass = i1.Key + i2.Key;
							double abundance = i1.Value * i2.Value;
							if (!exact) {
								mass = Math.Round(mass);
							}

							double existingAbundance;
							if (masses.TryGetValue(mass, out existingAbundance)) {
								masses.Remove(mass);
								masses.Add(mass, existingAbundance + abundance);
							} else {
								masses.Add(mass, abundance);
							}
						}
					}
				}
			}
			return masses;
		}

		/// <summary>
		/// Alternative method that assumes approximate isotopes are wanted
		/// </summary>
		/// <param name="elements">Array of Elements to calculate mass abundances for</param>
		/// <returns></returns>
		public static Dictionary<double, double> Calculate(Element[] elements) {
			return Calculate(elements, false);
		}
	}
}
