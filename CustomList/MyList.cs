using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList <T>
    {
        T[] array;
        public int count;
        public int capacity;

        public T this[int i] { get { return array[i]; } set { array[i] = value; } }

        public MyList()
        {
            capacity = 5;
            array = new T[capacity];
            count = 0;

        }

        public T[] Add(T item)
        {
            if (count > 4)
            {
                MoreArrayNeeded();

            }         
                array[count] = item;
                count++;
                return CurrentArray();     
        }

        public void MoreArrayNeeded()
        {
            if (count % 5 == 0)
            {
                T[] newArray = new T[count + 5];
                for (int i=0; i < count; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }

        }
        
        public T[] CurrentArray()
        {
            T[] currentArray = new T[count];
            for (int i = 0; i <count; i++)
            {
                currentArray[i] = array[i];
            }
            return currentArray;
        }









    }
}
