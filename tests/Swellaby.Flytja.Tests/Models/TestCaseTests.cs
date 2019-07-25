using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swellaby.Flytja.Models;

namespace Swellaby.Flytja.Tests.Models
{
    [TestClass]
    public class TestCaseTests
    {
        [TestMethod]
        public void Title_Get_ReturnsCorrectValue()
        {
            var exp = "TC: Shopping Cart Remove...";
            var testCase = new TestCase() { Title = exp };
            Assert.AreEqual(exp, testCase.Title);
        }

        [TestMethod]
        public void Title_Set_AppliesCorrectValue()
        {
            var exp = "TC: Shopping Cart Add...";
            var testCase = new TestCase() { Title = "boo" };
            testCase.Title = exp;
            Assert.AreEqual(exp, testCase.Title);
        }
    }
}
