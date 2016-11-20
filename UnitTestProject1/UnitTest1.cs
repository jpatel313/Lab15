using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab15
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
         Assert.AreEqual("india", CountriesTextFile.ReadFile());
        }
    }
}
