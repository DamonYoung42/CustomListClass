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
        T[] initialList;
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
            T[] newArray = new T[Count + 1];
            int counter = 0;
            foreach (var value in initialList)
            {
                newArray[counter] = value;
                counter++;
            }
            
            //    newArray[i] = initialList[i];
            //}           
            
            //    newArray[i] = value;
            //}
            //for (int i = 0; i < Count; i++)
            //{
            //    newArray[i] = initialList[i];
            //}
            newArray[newArray.Length - 1] = itemToAdd;
            initialList = newArray;
        }

        public static GenericList<T> operator +(GenericList<T> firstItem, GenericList<T> secondItem)
        {
            GenericList<T> newArray = new GenericList<T>(new T[0]);

            foreach (var value in firstItem)
            {
                newArray.Add(value);
            }

            foreach (var value in secondItem)
            {
                newArray.Add(value);
            }
            //for (int i = 0; i < firstItem.Count; i++)
            //{
            //    newArray.Add(firstItem.initialList[i]);
            //}

            //for (int i = 0; i < secondItem.Count; i++)
            //{
            //    newArray.Add(secondItem.initialList[i]);
            //}
            return newArray;
        }
    
        public static GenericList<T> operator -(GenericList<T> firstItem, GenericList<T> secondItem)
        {
            GenericList<T> newArray = new GenericList<T>(new T[0]);
            newArray += firstItem;

            foreach (var value in secondItem)
            {
                newArray.Remove(value);
            }

            //for (int i = 0; i < secondItem.Count; i++)
            //{
            //    newArray.Remove(secondItem.initialList[i]);
            //}
            return newArray;
        }

        public void Zip(GenericList<T> secondItem)
        {
            GenericList<T> newList = new GenericList<T>(new T[0]);

            for (int i = 0; i < Count; i++)
            {
                if (i < Count)
                {
                    newList.Add(initialList[i]);
                }


                if (i < secondItem.Count)
                {
                    newList.Add(secondItem.initialList[i]);

                }
            }
            initialList = newList.initialList;
        }

        public void Remove(T itemToRemove)

        {
            int counter = 0;
            T[] newArray = new T[Count - 1];

            foreach (var value in initialList)
            {
                if (!value.Equals(itemToRemove))
                {
                    newArray[counter] = value;
                    counter++;
                }
            }

            //for (int i = 0; i < Count; i++)
            //{

            //    if (!initialList[i].Equals(itemToRemove))
            //    {
            //        newArray[counter] = initialList[i];
            //        counter++;             
            //    }
            //}
            initialList = newArray;
        }

        public override string ToString()
        {
            string newString = "";

            foreach(var value in initialList)
            {
                newString += value;
            }
            //for (int i = 0; i < Count; i++)
            //{
            //    newString += initialList[i];
            //}
            return newString;
        }



        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return initialList[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return initialList[i];
            }
        }
    }
}
