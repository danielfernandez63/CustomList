using System;
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
            int[] actual = myList.Add(1);

            Assert.AreEqual(expected, actual[0]);
               

            }


        [TestMethod]
   
        public void AddStringToArray()
        {

            // arrange
            string expected = "dude";

            //act
            MyList<string> myList = new MyList<string>();
            string[] actual = myList.Add("dude");

            //assert
            Assert.AreEqual(expected, actual[0]);

        }


        [TestMethod]

        public void AddTwoItemsToArray()
        {

            // arrange
            int[] expected = { 6, 3 };

            //act
            MyList<int[]> myList = new MyList<int[]>();
            int[] actual = myList.Add(expected);

            //assert
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }


        [TestMethod]

        public void x()
        {

            // arrange


            //act


            //assert

        }

        [TestMethod]

        public void x()
        {

            // arrange


            //act


            //assert

        }

    }
}
