using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable<T>
    {
        T[] array { get; set; }
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

        public T this[int i]
        {
            get
            {
                if (i <= count)
                {
                    return array[i];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                (array[i]) = value;
            }
        }


        public MyList()
        {
            capacity = 10;
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
            return array;
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

        //public T[] CurrentArray()
        //{
        //    T[] currentArray = new T[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        currentArray[i] = array[i];
        //    }
        //    return currentArray;
        //}

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
            T[] newArrayOne = new T[capacity];
            T[] newArrayTwo = new T[capacity];


            for (int i = index; i < count; i++)
            {
                if (i < count)
                {
                    newArrayOne[i] = array[i + 1];
                }
                else
                {
                    newArrayTwo[i] = array[i];
                }

            }
            //for (int i = index; i >= count; i++)
            //{
            //    newArray[i] = array[i];
            //}

            array = newArrayOne + newArrayTwo;
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(array[i]);

            }
            return stringBuilder.ToString();

        }

        public static MyList<T> operator +(MyList<T> listOne, MyList<T> listTwo)
        {
            MyList<T> newList = new MyList<T>();
            newList.array = listOne.array;
            newList.count = listOne.count;
               for(int i = 0; i < listTwo.count; i++)
            {
                newList.Add(listTwo.array[i]);
            }

            return newList;

        }
        public static MyList<T> operator -(MyList<T> listOne, MyList<T> listTwo)
        {
            MyList<T> newList = new MyList<T>();
            newList = listOne;
            bool isMatch;


            for (int i = 0; i < listTwo.count; i++)
            {
                isMatch = false;

                for (int j = 0; j < listOne.count; j++)
                {
                    if (listOne[j].Equals(listTwo[i]) == true)
                    {
                        isMatch = true;
                    }

                }
               if (isMatch == false)
                {
                    newList.Remove(listTwo.array[i]);
                }
            }

            return newList;

        }

        public MyList<T> Zipper(MyList<T> listTwo)
        {
            MyList<T> currentArray = new MyList<T>();

            for (int i =0; i < count && i < listTwo.count; i++)
            {
                currentArray.Add(array[i]);
                currentArray.Add(listTwo[i]);
            }

            if (count > listTwo.count)
            {
                for (int j = count; j<(count-listTwo.count); j++)
                {
                    currentArray.Add(array[j]);
                }
            }

            else if (listTwo.count > count)
            {
                for (int k = listTwo.count; k < (listTwo.count-count); k++)
                {
                    currentArray.Add(listTwo[k]);
                }
            }
            this.array = currentArray.array;
            this.count = currentArray.count;
            return currentArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
           
        }
    }
}
