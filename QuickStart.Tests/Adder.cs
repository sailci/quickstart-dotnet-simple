using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickStart;

namespace QuickStart.Test
{
    [TestClass]
    public class AdderTests
    {
        [TestMethod]
        public void TestAdd()
        {
            var result = Adder.Add(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}
