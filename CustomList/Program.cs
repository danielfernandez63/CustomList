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

            MyList<string> mylistOne = new MyList<string>();
            mylistOne.Add("Hello");
            mylistOne.Add("sir");
            mylistOne.Add("scruffles");
            mylistOne.Add("!");
            mylistOne.Remove("Hello");
        
            mylistOne.Remove("!");
          

            //MyList<string> mylistTwo = new MyList<string>();
            //mylistTwo.Add("scruffles");
            //mylistTwo.Add("!");


           
            MyList<string> myList = (mylistOne);


           Console.WriteLine(myList);
           Console.ReadLine();

           // MyList<int> mylistThree = new MyList<int>();
           // mylistThree.Add(12);
           // mylistThree.Add(34);
           // mylistThree.Add(56);
           // //mylistOne.Add("!");

           //// MyList<string> mylistTwo = new MyList<string>();
           // // mylistTwo.Add("sir");
           // //  mylistTwo.Add("!");

    
           // //  MyList<string> myList = (mylistOne + mylistTwo);

           // Console.WriteLine(mylistThree);
           // Console.ReadLine();
        }
    }
}
