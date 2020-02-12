using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseUtils {
	class Element {
		private String symbol;
		private double average_mass;
		private LinkedList<KeyValuePair<double, double>> isotopes;

		protected Element() {
			try {
				using (StreamReader reader = new StreamReader("ATOMIC_ISOTOPES.csv")) {
					while (!reader.EndOfStream) {

					}
				}
			} catch (Exception e) {
				// TODO
			}
		}
	}
}
