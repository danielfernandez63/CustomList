using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList <T>
    {
        T[] list;
        int count;

        public MyList()
        {
            list = new T[10];
            count = 0;

        }

       // public T[] Add(T item)
        //{


        //}


    }
}
