using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace console_app_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int testNumber = 10;

            Assert.AreEqual(10, testNumber);
        }
    }
}
