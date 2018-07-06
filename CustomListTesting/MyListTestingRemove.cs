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
            MyList<string> mylist = new MyList<string>();
            mylist.Remove("i");

            //assert
            Assert.AreEqual(expected, mylist.capacity);
        }

        [TestMethod]

        public void RemoveFromArrayAtEnd()
        {

            // arrange
            int[] arrayOne = { 1, 2, 3 };
            int expected = 0;

            //act
            MyList<int> myList = new MyList<int>();
            myList.Remove(3);

            //assert
            Assert.AreEqual(expected, myList[2]);
        }

        [TestMethod]

        public void RemoveFromArrayCheckFront()
        {
            // arrange
            int[] arrayOne = { 1, 2, 3 };
            int expected = 2;

            //act
            MyList<int> myList = new MyList<int>();
            myList.Remove();

            //assert
            Assert.AreEqual(expected, myList[0]);
        }



        [TestMethod]
        public void x1()
        {

            // arrange


            //act


            //assert

        }





    }
}
