using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTesting
{
    [TestClass]
    public class MyListTestingRemoveOverLoad
    {



        [TestMethod]
        public void RemovingAnArrayFromArray()
        {
            // arrange
            MyList<string> mylistOne = new MyList<string>();
            mylistOne.Add("Hello");
            mylistOne.Add("sir");
            mylistOne.Add("scrufflelicious");          

            MyList<string> mylistTwo = new MyList<string>();
            mylistTwo.Add("sir");         

            string[] expected = { "Hello", "scrufflelicious" };


            //act
            MyList<string> myList = mylistOne - mylistTwo;


            //assert
            Assert.AreEqual(expected[0], myList[0]);
            Assert.AreEqual(expected[1], myList[1]);
           
        }




    }
}
