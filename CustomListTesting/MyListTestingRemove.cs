using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTesting
{
    [TestClass]
    public class MyListTestingRemove
    {
       
   
        [TestMethod]

        public void RemoveFromCount()
        {

            // arrange
            
            string[] arrayOne = { "h", "i" };
            int expected = 1;

            //act
            MyList<string> myList = new MyList<string>();
            myList.Add("h");
            myList.Add("i");
            myList.Remove("i");

            //assert
            Assert.AreEqual(expected, myList.count);
        }



        [TestMethod]

        public void RemoveFromArrayAtEnd() //have to change to catch exception
        {

            // arrange
           
            int expected = 0;

            //act
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Remove(3);

            //assert
            Assert.AreEqual(expected, myList[2]);
        }


        [TestMethod]

        public void RemoveFromArrayCheckShift()
        {
            // arrange

            int expected = 2;

            //act
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Remove(1);

            //assert
            Assert.AreEqual(expected, myList[0]);
        }

        [TestMethod]
        public void RemoveSingleNumberWhenMultiplePresent()
        {

            // arrange
            int expected = 5;

            //act.
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(3);
            myList.Add(5);
            myList.Remove(3);

            //assert
            Assert.AreEqual(expected, myList.count);

        }

        [TestMethod]
        public void checkingcounttonotchangewhenremoving1()
        {

            // arrange
            int expected = 3;

            //act
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Remove(4);

            //assert
            Assert.AreEqual(expected, myList.count);

        }

    }
}
