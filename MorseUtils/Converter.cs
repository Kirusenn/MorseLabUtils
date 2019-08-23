using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MorseUtils {
	static class Converter {
		//	Constants
		private static double c = 299792458;                //	Speed of light
		private static double h = 6.62607004 * Math.Pow(10, -34);   //	Planck's Constant


		public static List<double> Convert(int senderBox, List<double> inputValues) {
			List<double> results = new List<double>(inputValues);

			//	Convert mJ to base all else on
			switch (senderBox) {
				case 0: //	mJ entered; do nothing
					break;

				case 1: //	nm
					results[0] = ((h * c) / (inputValues[1] * (Math.Pow(10, -9)))) * Math.Pow(10, 3);
					break;

				case 2: //	cm-1
					results[0] = ((h * c) / (Math.Pow(10, 9) / inputValues[2])) * Math.Pow(10, 3);
					break;

				case 3: //	eV
					break;

				case 4: //	frequency
					break;

				case 5: //	kcal/mol
					break;

				case 6: //	dye counter units
					break;
			}

			return results;
		}
	}
}
