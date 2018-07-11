using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTesting
{
    [TestClass]
    public class MyListTestingAddOverLoad
    {

        [TestMethod]
        public void AddTwoArrays()
        {
            // arrange
            MyList<string> mylistOne = new MyList<string>();
            mylistOne.Add("Hello");
            mylistOne.Add("sir");

            MyList<string> mylistTwo = new MyList<string>();
            mylistTwo.Add("scrufflelicious");
            mylistTwo.Add("!");
            string[] expected = { "Hello", "sir", "scrufflelicious", "!" };

            //act
            MyList<string> myList = mylistOne + mylistTwo;

            //assert
            Assert.AreEqual(expected[0], myList[0]);
            Assert.AreEqual(expected[1], myList[1]);
            Assert.AreEqual(expected[2], myList[2]);
            Assert.AreEqual(expected[3], myList[3]);
        }









    }
}
