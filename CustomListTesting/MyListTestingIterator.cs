using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTesting
{
    [TestClass]
    public class MyListTestingIterator
    {



        [TestMethod]
        public void TestingIterator()
        {

            // arrange          
            int[] expected = { 1, 2, 4, 5, 6, 3 };

            // act
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Remove(3);
            myList.Add(3);

            // assert
            Assert.AreEqual(expected[0], myList[0]);
            Assert.AreEqual(expected[1], myList[1]);
            Assert.AreEqual(expected[2], myList[2]);
            Assert.AreEqual(expected[3], myList[3]);
            Assert.AreEqual(expected[4], myList[4]);
            Assert.AreEqual(expected[5], myList[5]);
        }




    }
}
