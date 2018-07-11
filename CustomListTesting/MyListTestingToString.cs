using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTesting
{
    [TestClass]
    public class MyListTestingToString
    {
       
        [TestMethod]
        public void CheckingArrayToSeeChangeToString()
        {
            // arrange
            string expected = "123";

            //act
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            string actual = myList.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

   

    }
}
