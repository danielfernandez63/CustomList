using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            //MyList<string> mylistOne = new MyList<string>();
            //mylistOne.Add("Hello");
            //mylistOne.Add("sir");
            //mylistOne.Add("scruffles");
            //mylistOne.Add("!");
            //mylistOne.Remove("Hello");
            //mylistOne.Add("Hello");
            //mylistOne.Remove("!");


            //MyList<string> myList = (mylistOne);


            //Console.WriteLine(myList);
            //Console.ReadLine();





            MyList<int> mylistThree = new MyList<int>();
            mylistThree.Add(2);
            mylistThree.Add(4);
            mylistThree.Add(8);
            mylistThree.Add(6);


            MyList<int> mylistFour = new MyList<int>();
            mylistFour.Add(8);
            mylistFour.Add(6);


            MyList<int> myList = (mylistThree - mylistFour);

            Console.WriteLine(myList);
            Console.ReadLine();

        }
    }
}
