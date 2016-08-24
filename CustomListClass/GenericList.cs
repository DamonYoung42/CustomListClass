using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class GenericList<T> : IEnumerable<T>
    {
        private T[] initialList;
        int count;

        public int Count
        {
            get
            {
                return initialList.Length;
            }
            
        }

        public GenericList(T[] array)
        {
            initialList = array;


        }
        public void Add(T itemToAdd)
        {
            T[] newArray = new T[initialList.Length + 1];
            for (int i = 0; i < initialList.Length; i++)
            {
                newArray[i] = initialList[i];
            }
            newArray[newArray.Length - 1] = itemToAdd;
            initialList = newArray;
        }

        public static GenericList<T> operator +(GenericList<T> firstItem, GenericList<T> secondItem)
        {
            GenericList<T> newArray = new GenericList<T>(new T[0]);
            for (int i = 0; i < firstItem.initialList.Length; i++)
            {
                newArray.Add(firstItem.initialList[i]);
            }

            for (int i = 0; i < secondItem.initialList.Length; i++)
            {
                newArray.Add(secondItem.initialList[i]);
            }
            return newArray;
        }
    
        public static GenericList<T> operator -(GenericList<T> firstItem, GenericList<T> secondItem)
        {
            GenericList<T> newArray = new GenericList<T>(new T[0]);
            newArray += firstItem;
            for (int i = 0; i < secondItem.initialList.Length; i++)
            {
                newArray.Remove(secondItem.initialList[i]);
            }
            return newArray;
        }

        //public T[] Zip(T[] firstItem, T[] secondItem)
        //{

        //    T[] newArray = new T[Math.Min(firstItem.Length, secondItem.Length)];

        //    for (int i = 0; i < newArray.Length; i++)
        //    {
        //        newArray[i] = firstItem[i] + secondItem[i];
        //    }

        //    return newArray;
        //}

        public void Remove(T itemToRemove)

        {
            int counter = 0;
            T[] newArray = new T[initialList.Length - 1];
            for (int i = 0; i < initialList.Length; i++)
            {
                
                if (!initialList[i].Equals(itemToRemove))
                {
                    newArray[counter] = initialList[i];
                    counter++;             
                }
            }
            initialList = newArray;
        }

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < initialList.Length; i++)
            {
                newString += initialList[i];
            }
            return newString;
        }



        //IEnumerator<T[]> GetEnumerator()
        //{
        //    Console.WriteLine("T[].GetEnumerator");
        //    for (int i = 0; i < initialList.Count(); i++)
        //    {
        //        yield return initialList;
        //    }
        //}

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Console.WriteLine("<T>.GetEnumerator");
            for (int i = 0; i < initialList.Count(); i++)
            {
                yield return initialList[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Console.WriteLine("GetEnumerator");
            for (int i = 0; i < initialList.Count(); i++)
            {
                yield return initialList[i];
            }
        }
    }
}
