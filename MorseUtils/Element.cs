using System;
using System.Collections.Generic;

namespace MorseUtils {
	class Element {
		private String symbol;
		private double averageMass;
		private Dictionary<string, double> isotopes;

		public Element(String symbol, double averageMass) {
			this.Symbol = symbol;
			this.AverageMass = averageMass;
			Isotopes = new Dictionary<string, double>();
		}

		public string Symbol { get => symbol; set => symbol = value; }
		public double AverageMass { get => averageMass; set => averageMass = value; }
		public Dictionary<string, double> Isotopes { get => isotopes; set => isotopes = value; }

		public bool AddIsotope(double mass, double abundance) {
			if (Isotopes.ContainsKey(mass.ToString())) {
				return false;
			}
			Isotopes.Add(mass.ToString(), abundance);
			return true;
		}
	}
}
