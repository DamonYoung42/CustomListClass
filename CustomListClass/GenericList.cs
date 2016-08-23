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

        IEnumerator<T[]> GetEnumerator()
        {
            Console.WriteLine("T[].GetEnumerator");
            for (int i = 0; i < initialList.Count(); i++)
            {
                yield return initialList;
            }
        }

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
