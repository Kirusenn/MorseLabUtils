using MorseUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1 {
	[TestClass]
	public class UnitTest1 {
		ElementList elements = new ElementList();

		[TestMethod]
		public void TestMethod1() {
			Dictionary<string, double> cIsotopes = elements.GetIsotopes("c");
			double c12Abundance;
			double c13Abundance;
			double c14Abundance;

			Assert.IsTrue(cIsotopes.TryGetValue("12", out c12Abundance));
			Assert.IsNotNull(c12Abundance);
			Assert.AreEqual(0.988922, c12Abundance);

			Assert.IsTrue(cIsotopes.TryGetValue("13.00335484", out c13Abundance));
			Assert.IsNotNull(c13Abundance);
			Assert.AreEqual(0.011078, c13Abundance);

			Assert.IsFalse(cIsotopes.TryGetValue("14", out c14Abundance));
		}
	}
}
