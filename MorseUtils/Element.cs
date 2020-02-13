using System;
using System.Collections.Generic;

namespace MorseUtils {

	/// <summary>
	/// Class representing an element
	/// </summary>
	public class Element {
		private String symbol;
		private double averageMass;
		private Dictionary<double, double> isotopes;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="symbol">Elemental symbol, e.g. C for Carbon</param>
		/// <param name="averageMass">Average isotopic mass</param>
		public Element(String symbol, double averageMass) {
			this.Symbol = symbol;
			this.AverageMass = averageMass;
			Isotopes = new Dictionary<double, double>();
		}

		public string Symbol { get => symbol; set => symbol = value; }
		public double AverageMass { get => averageMass; set => averageMass = value; }
		public Dictionary<double, double> Isotopes { get => isotopes; set => isotopes = value; }

		/// <summary>
		/// Used to add isotopes to the Element. This is typically done by reading a CSV and adding isotopes with their respective abundances.
		/// </summary>
		/// <param name="mass">Isotopic mass</param>
		/// <param name="abundance">Abundance of the isotope</param>
		/// <returns></returns>
		public bool AddIsotope(double mass, double abundance) {
			if (Isotopes.ContainsKey(mass)) {
				return false;
			}
			Isotopes.Add(mass, abundance);
			return true;
		}
	}
}
