using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldClass;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            string expected = "Hello World";
            string dataType = "Simple";
            string actual = FactoryCreateHelloWorld.GetHellowWorld(dataType);
            Assert.AreEqual(expected, actual);
        }
    }
}
