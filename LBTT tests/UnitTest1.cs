using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LBTT;

namespace LBTT_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_BracketHighLimit_CalculateTaxMethod()
        {
            double expected = 48350;
            double result = LBTT.Program.CalculateTax(750000);
            Assert.AreEqual(expected, result);
        }
    
        [TestMethod]
        public void Test_Negative_CalculateTaxMethod()
        {
            double expected = 0;
            double result = LBTT.Program.CalculateTax(-2000);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_UnderBracket_CalculateTaxMethod()
        {
            double expected = 0;
            double result = LBTT.Program.CalculateTax(143000);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_ExtremeHigh_CalculateTaxMethod()
        {
            double expected = 179958350;
            double result = LBTT.Program.CalculateTax(1500000000);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_BracketTwo_CalculateTaxMethod()
        {
            double expected = 822.90;
            double result = LBTT.Program.CalculateTax(186145);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_BracketThree_CalculateTaxMethod()
        {
            double expected = 3350;
            double result = LBTT.Program.CalculateTax(275000);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_Four_CalculateTaxMethod()
        {
            double expected = 40350;
            double result = LBTT.Program.CalculateTax(670000);
            Assert.AreEqual(expected, result);
        }
    }

}
