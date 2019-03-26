using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstGame
    {
        //create clsGame
        [TestMethod]
        public void InstaceOK()
        {
            //create and instance of the class we want to create
            clsGame AGame = new clsGame();
            //test to see that it exists
            Assert.IsNotNull(AGame);
        }

        //create GameName property
        [TestMethod]
        public void GameNamePropertyOK()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            string SomeGame = "Overwatch";
            //assign the data to the property
            AGame.GameName = SomeGame;
            //test to make sure the values are the same
            Assert.AreEqual(AGame.GameName, SomeGame);
        }

        //create the GamePrice property
        [TestMethod]
        public void GamePricePropertyOK()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //create some test data to assign to the property
            double SomeGamePrice = 39.99;
            //assign the data to the property
            AGame.GamePrice = SomeGamePrice;
            //test to make sure the values are the same
            Assert.AreEqual(AGame.GamePrice, SomeGamePrice);
        }


        //create the Find method
        [TestMethod]
        public void FindExists()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            string SomeGame = "Overwatch";
            //a boolean to store the result of the method
            Boolean OK;
            //invoke the method
            OK = AGame.Find(SomeGame);
            //test to see that OK returns true
            Assert.IsTrue(OK);
        }

        //create the Valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data
            string SomeGame = "Overwatch";
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to see that the error returns blank
            Assert.AreEqual(Error, "");
        }



        //validation for GameName


        [TestMethod]
        public void GameNameMinLessOne()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeGame = "";
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to make sure that the validation returns an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMin()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeGame = "a";
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMinPlusOne()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeGame = "aa";
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMaxLessOne()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeGame = "0123456789012345678901234567890123456789012345678";
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMax()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeGame = "01234567890123456789012345678901234567890123456789";
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMaxPlusOne()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeGame = "012345678901234567890123456789012345678901234567890";
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to make sure that the validation returns an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMid()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            string SomeGame = "0123456789012345678901234";
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNameExtremeMax()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property using PadRight to create a 500 character string
            String somegame = "";
            string SomeGame = somegame.PadRight(500, 'a');
            //invoke the validation method
            Error = AGame.Valid(SomeGame);
            //test to make sure that the validation returns an error
            Assert.AreNotEqual(Error, "");
        }


        //validation for GamePrice
        [TestMethod]
        public void GamePriceExtremeMin()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = -500;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation returns an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GamePriceMinLessOne()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = -0.01;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation returns an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GamePriceMin()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = 0;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GamePriceMinPlusOne()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = 0.01;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GamePriceMaxLessOne()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = 499.99;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GamePriceMax()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = 500;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GamePriceMaxPlusOne()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = 500.01;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation returns an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GamePriceMid()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = 250;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation does not return an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GamePriceExtremeMax()
        {
            //create an instance of the Game class
            clsGame AGame = new clsGame();
            //a string variable to store the resut of the validation
            String Error = "";
            //create some test data to assign to the property
            double SomeGamePrice = 1000000;
            //invoke the validation method
            Error = AGame.Valid(SomeGamePrice);
            //test to make sure that the validation returns an error
            Assert.AreNotEqual(Error, "");
        }
    }
}
