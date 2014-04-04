using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using ApprovalTests;
using ApprovalTests.Reporters;

namespace RomanNumbers
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class RomanNumbersTest
    {
        [TestMethod]
        public void Test_I_1()
        {
            Assert.AreEqual(1, Roman.ToDecimal("I"));
        }

        [TestMethod]
        public void TestAll()
        {
            var romans = new[] {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"};
            var results = romans.Select(r => new {roman = r, number = Roman.ToDecimal(r)});
            Approvals.VerifyAll(results, "");
        }
    }
}