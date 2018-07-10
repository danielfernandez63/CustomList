using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTesting
{
    [TestClass]
    public class MyListTestingZipperMethod
    {



        [TestMethod]
        public void OneListPlusAnotherStrings()
        {

            // arrange
            MyList<string> myListOne = new MyList<string>();
            myListOne.Add("Hello");
            myListOne.Add("how");
            myListOne.Add("are");
            myListOne.Add("you?");
            MyList<string> myListTwo = new MyList<string>();
            myListTwo.Add("I");
            myListTwo.Add("am");
            myListTwo.Add("doing");
            myListTwo.Add("well!");

            //act
            string[] expected = { "Hello", "I", "how", "am", "are", "doing", "you?", "well!" };
            MyList<string> actual = myListOne.Zipper(myListTwo);

            //assert
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[6], actual[6]);
            Assert.AreEqual(expected[7], actual[7]);
        }



        [TestMethod]
        public void x()
        {

           // arrange


         //  act


           // assert


        }



    }
}
