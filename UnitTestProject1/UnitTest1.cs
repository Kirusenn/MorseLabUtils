using MorseUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1 {
	[TestClass]
	public class UnitTest1 {
		ElementList elements = new ElementList();

		[TestMethod]
		public void TestMethod1() {
			Dictionary<double, double> cIsotopes = elements.GetElement("c").Isotopes;
			double c12Abundance;
			double c13Abundance;
			double c14Abundance;

			Assert.IsTrue(cIsotopes.TryGetValue(12, out c12Abundance));
			Assert.IsNotNull(c12Abundance);
			Assert.AreEqual(0.988922, c12Abundance);

			Assert.IsTrue(cIsotopes.TryGetValue(13.00335484, out c13Abundance));
			Assert.IsNotNull(c13Abundance);
			Assert.AreEqual(0.011078, c13Abundance);

			Assert.IsFalse(cIsotopes.TryGetValue(14, out c14Abundance));
		}

		[TestMethod]
		public void TestMethod2() {
			Element[] carbon = new Element[1];
			carbon[0] = elements.GetElement("C");
			Dictionary<double, double> masses = AbundanceCalculator.Calculate(carbon);
			Assert.IsTrue(masses.Keys.Count == 3);

			double totalAbundance = 0;
			foreach(KeyValuePair<double, double> mass in masses) {
				totalAbundance += mass.Value;
			}

			Assert.IsTrue(totalAbundance < 1);
		}
	}
}
