﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTesting
{
    [TestClass]
    public class MyListTestingAdd
    {
        [TestMethod]
        
            public void AddIntToArray()
            {
                int expected = 1;
    
                MyList<int> myList = new MyList<int>();
                myList.Add(1);
        
                Assert.AreEqual(expected, myList[0]);                     
            }

        [TestMethod]
   
        public void AddStringToArray()
        {
            // arrange
            string expected = "dude";

            //act
            MyList<string> myList = new MyList<string>();
            myList.Add("dude");

            //assert
            Assert.AreEqual(expected, myList[0]);
        }

        [TestMethod]

        public void AddTwoItemsToArray()
        {
            // arrange
            int expected = 33;

            //act
            MyList<int> myList = new MyList<int>();
            myList.Add(63);
            myList.Add(33);
            myList.Add(45);
       
          //   Assert.AreEqual(expected[0], actual[0]);// dont really need to check the first number since its been checked before
            Assert.AreEqual(expected, myList[1]);
        }

        [TestMethod]

        public void AddingToCounter()
        {
            //arrange
            int expected = 3;

            //act
            MyList<int> mylist = new MyList<int>();
            mylist.Add(63);
            mylist.Add(102);
            mylist.Add(23);

            //assert
            Assert.AreEqual(expected, mylist.count);
        }

        [TestMethod]

        public void AddingToCapacity()
        {
            //arrange
            int expected = 15;

            //act
            MyList<int> mylist = new MyList<int>();
            mylist.Add(63);
            mylist.Add(102);
            mylist.Add(23);
            mylist.Add(67);
            mylist.Add(33);
            mylist.Add(69);
            mylist.Add(63);
            mylist.Add(102);
            mylist.Add(23);
            mylist.Add(67);
            mylist.Add(33);
            mylist.Add(69);

            //assert
            Assert.AreEqual(expected, mylist.Capacity);
        }

        //[TestMethod]
        //public void CheckingExceptionAdd()
        //{
        //    int expected = 2;

        //    MyList<int> myList = new MyList<int>();
        //    myList.Add(1);


        //    Assert.AreEqual(expected, myList[1]);

        //}



    }
}
