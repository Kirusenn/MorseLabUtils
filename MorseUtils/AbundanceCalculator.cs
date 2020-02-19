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
			// Create copy of elements to  allow adding every isotope to every other
			Element[] elementsCopy = new Element[elements.Length];
			Array.Copy(elements, 0, elementsCopy, 0, elements.Length);

			// Dictionary to store all combined masses in
			Dictionary<double, double> masses = new Dictionary<double, double>();

			// Iterate through first array
			for (int a1 = 0; a1 < elements.Length; a1++) {
				Element e1 = elements[a1];
				// Iterate through first element's isotopes
				foreach (KeyValuePair<double, double> i1 in e1.Isotopes) {

					// Iterate through second array
					for (int a2 = a1+1; a2 < elementsCopy.Length; a2++) {
						Element e2 = elements[a2];
						// Iterate through second element's isotopes
						foreach (KeyValuePair<double, double> i2 in e2.Isotopes) {

							// Combine current isotopes
							double mass = i1.Key + i2.Key;
							double abundance = i1.Value * i2.Value;

							// Round if exact is not set
							if (!exact) {
								mass = Math.Round(mass);
							}

							double existingAbundance;
							// If mass already exists, readd increasing abundance
							if (masses.TryGetValue(mass, out existingAbundance)) {
								masses.Remove(mass);
								masses.Add(mass, existingAbundance + abundance);
							} else {
								// Add mass and abundance if not already in masses
								masses.Add(mass, abundance);
							}
						}
					}

					// Add current isotopes abundance by itself if mass >= 40 (i.e. possibility of seeing monoatomic metal signal)
					// TODO Possibly weight this and/or isotopic combinations; chance of increasing mass above 100% if monoatomic signal is at same mass as a combination of elements and both are high. More of an issue for polyatomic combinations.
					double imass = i1.Key;
					double iabundance = i1.Value;
					if (!exact) {
						imass = Math.Round(imass);
					}

					if (imass >= 40) {
						double iexistingAbundance;
						// If mass already exists, readd increasing abundance
						if (masses.TryGetValue(imass, out iexistingAbundance)) {
							masses.Remove(imass);
							masses.Add(imass, iexistingAbundance + iabundance);
						} else {
							// Add mass and abundance if not already in masses
							masses.Add(imass, iabundance);
						}
					}
				}
			}
			return masses;
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
