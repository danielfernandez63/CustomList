using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        T[] array;
        public int count;
        int capacity;

        public int Capacity
        {
            get
            {
             return capacity;
            }
            set
            {
             capacity = value;
            }
        }

        public T this[int i] { get { return array[i]; } set { array[i] = value; } }

        public MyList()
        {
            capacity = 5;
            array = new T[capacity];
            count = 0;
        }

        public T[] Add(T item)
        {
            if (count > capacity - 5)
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
                capacity += 5;
                T[] newArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
        }

        public T[] CurrentArray()
        {
            T[] currentArray = new T[count];
            for (int i = 0; i < count; i++)
            {
                currentArray[i] = array[i];
            }
            return currentArray;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    count--;
                    ShiftArray(i);
                    return true;
                }

            }
            return false;
        }

        public void ShiftArray(int index)
        {
            T[] newArray = new T[capacity];

            for (int i = index; i < count; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
        }
        

        public override string ToString()
        {
            string stringArray = "";
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                    stringArray = Convert.ToString(array[i]);
            }

            return stringArray;
           
        }




    }
}
