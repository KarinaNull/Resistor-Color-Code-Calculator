using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resistor_Color_Code_Calculator; // наш основной проект в решении

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest // класс юнит-теста
    {
        [TestMethod]
        public void Test1_TruncateZeroesMethod()
        {
            Assert.AreEqual("560K", UnitHelper.TruncateZeroes(560000)); 
        }

        [TestMethod]
        public void Test2_TruncateZeroesMethod()
        {
            Assert.AreEqual("100K", UnitHelper.TruncateZeroes(100000));
        }

        [TestMethod]
        public void Test3_TruncateZeroesMethod()
        {
            Assert.AreEqual("512M", UnitHelper.TruncateZeroes(512000000));
        }

        [TestMethod]
        public void Test4_TruncateZeroesMethod()
        {
            Assert.AreEqual("5G", UnitHelper.TruncateZeroes(5000000000));
        }
    }
}
