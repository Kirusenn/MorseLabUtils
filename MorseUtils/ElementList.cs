using System;
using System.Collections.Generic;
using System.IO;

namespace MorseUtils {
	public class ElementList {
		private readonly Dictionary<string, Element> elements;

		public ElementList() {
			elements = new Dictionary<string, Element>();

			try {
				string[] parts;
				Element newElement;

				using (StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ATOMIC_ISOTOPES.csv"))) {
					while (!reader.EndOfStream) {
						parts = reader.ReadLine().Split(',');
						newElement = new Element(parts[0], Double.Parse(parts[1]));
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

		public Dictionary<string, double> GetIsotopes(string symbol) {
			Element requested;
			if (elements.TryGetValue(symbol.ToLower(), out requested)) {
				return requested.Isotopes;
			} else {
				return null;
			}
		}
	}
}
