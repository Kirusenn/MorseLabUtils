using System;
using System.Collections.Generic;
using System.IO;

namespace MorseUtils {
	
	/// <summary>
	/// Class representing a list of the elements in dictionary form
	/// </summary>
	public class ElementList {
		private readonly Dictionary<string, Element> elements;

		/// <summary>
		/// Constructs a list of elements from the ATOMIC_ISOTOPES.csv file.
		/// </summary>
		public ElementList() {
			elements = new Dictionary<string, Element>();

			try {
				string[] parts;
				Element newElement;

				// Iterate through lines of ATOMIC_ISOTOPES.csv and create elements
				using (StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ATOMIC_ISOTOPES.csv"))) {
					while (!reader.EndOfStream) {
						// Split line (first should be symbol, second should be average mass, then isotope1,abundance1, etc.
						parts = reader.ReadLine().Split(',');
						// Create element with symbol and average mass
						newElement = new Element(parts[0], Double.Parse(parts[1]));
						// Add each isotope with its abundance
						for (int i = 2; i < parts.Length; i+=2) {
							newElement.AddIsotope(Double.Parse(parts[i]), Double.Parse(parts[i + 1]));
						}
						elements.Add(newElement.Symbol.ToLower(), newElement);
					}
				}
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}

		/// <summary>
		/// Returns a list of isotopes for a given element
		/// </summary>
		/// <param name="symbol">Elemental symbol, e.g. C for carbon</param>
		/// <returns></returns>
		public Element GetElement(string symbol) {
			Element requested;
			if (elements.TryGetValue(symbol.ToLower(), out requested)) {
				return requested;
			} else {
				return null;
			}
		}
	}
}
