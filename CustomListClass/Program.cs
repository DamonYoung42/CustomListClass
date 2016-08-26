﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        

        static void Main(string[] args)
        {

            GenericList<string> stringList = new GenericList<string>(new string[] { "name", "city", "address", "state", "age" });
            Console.WriteLine("Initial List");
           
            foreach (var category in stringList)
            {
                Console.WriteLine(category);

            }

            //Count property
            Console.WriteLine(stringList.Count);

            Console.WriteLine("Add country to list");
            stringList.Add("country");
            Console.WriteLine("Add dob to list");
            stringList.Add("dob");

            foreach (var value in stringList)
            {
                Console.WriteLine(value);

            }

            //Count property
            Console.WriteLine(stringList.Count);

            Console.WriteLine("Remove age from list");
            stringList.Remove("age");
            Console.WriteLine("Remove city from list");
            stringList.Remove("city");

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
           
            }

            Console.WriteLine("Calling ToString(), with Count property");
            Console.WriteLine(stringList.Count + " " + stringList.ToString());

            Console.ReadKey();
            Console.WriteLine("Calling ToString(), with Count property");
            GenericList<int> numbersOriginal= new GenericList<int>(new int[] { 1, 2, 3 });
            Console.WriteLine(numbersOriginal.Count + " " + numbersOriginal.ToString());

            Console.ReadKey();
            Console.WriteLine("\nOperator + overload");
            GenericList<int> numbers1 = new GenericList<int>(new int[] { 1, 2, 3});
            GenericList<int> numbers2 = new GenericList<int>(new int[] { 4,5,6, 7, 8, 9, 10 });
            GenericList<int> numbers3 = numbers1 + numbers2;
            Console.WriteLine("\nFirst List");
            foreach (var item in numbers1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nSecond List");
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n+ List");
            Console.WriteLine();
            foreach (var item in numbers3)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("\nOperator + overload");

            GenericList<string> strings1 = new GenericList<string>(new string[] { "hello", "goodbye", "good morning", "good night"});
            GenericList<string> strings2 = new GenericList<string>(new string[] { "baseball", "basketball"});
            GenericList<string> strings3 = strings1 + strings2;

            Console.WriteLine("\nList A");
            foreach (var item in strings1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nList B");

            foreach (var item in strings2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n+ List");
            foreach (var item in strings3)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            
            //Remove function
            GenericList<int> tenNumbers = new GenericList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            GenericList<int> evenNumbers = new GenericList<int>(new int[] { 2, 4, 6, 8, 10 });
            GenericList<int> oddNumbers = tenNumbers - evenNumbers;
            Console.WriteLine("List of first 10 numbers: {0}", tenNumbers);
            Console.WriteLine("List of even numbers: {0}", evenNumbers);
            Console.WriteLine("First 10 numbers minus even numbers: {0}", oddNumbers);

            //Zipper function
            Console.WriteLine("\nZipper function");
            GenericList<string> zipList1 = new GenericList<string>(new string[] { "one", "two", "three", "four","five" });
            GenericList<string> zipList2 = new GenericList<string>(new string[] { "10", "20", "30" });
            GenericList<int> zipList3 = new GenericList<int>(new int[] { 1, 2, 3, 4, 5 });
            GenericList<int> zipList4 = new GenericList<int>(new int[] { 6, 7, 8, 9, 10 });

            Console.WriteLine(zipList1);
            foreach (var item in zipList1)
            {
                Console.WriteLine("Ziplist1: " + item);
            }
            Console.WriteLine(zipList2);
            foreach (var item in zipList2)
            {
                Console.WriteLine("Ziplist2: " + item);
            }
            zipList1.Zip(zipList2);
            foreach (var item in zipList1)
            {
                Console.WriteLine("Zipped Ziplist1: " + item);
            }

            Console.WriteLine("\nZipped Integer List");
            
            Console.WriteLine(zipList3);
            Console.WriteLine(zipList4);
            zipList3.Zip(zipList4);
            Console.WriteLine(zipList3);
            Console.ReadLine();


            Console.WriteLine("\nList Sorting");

            GenericList<int> sortList = new GenericList<int>(new int[] {3,4,1,5,2});
            Console.WriteLine(sortList);
            sortList.Sort();
            Console.WriteLine(sortList);
            Console.ReadLine();

            GenericList<string> sortStringList = new GenericList<string>(new string[] { "Tommy", "Rachel","Isaac", "Brock", "Glen", "Jacob", "Dylan" });
            Console.WriteLine(sortStringList);
            sortStringList.Sort();
            Console.WriteLine(sortStringList);
            Console.ReadLine();


            GenericList<string> sortStringList2 = new GenericList<string>(new string[] { "Tommy", "1", "Isaac", "3", "Glen", "500", "Dylan" });
            Console.WriteLine(sortStringList2);
            sortStringList2.Sort();
            Console.WriteLine(sortStringList2);
            Console.ReadLine();


        }
    }
}
