using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstGame
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of our class clsGame
            clsGame AGame = new clsGame();
            Assert.IsNotNull(AGame);
        }
    }
}
