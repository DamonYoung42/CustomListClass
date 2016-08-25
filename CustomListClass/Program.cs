using System;
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

            Console.WriteLine("ToString function with string array");
            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("ToString function with integer array");
            GenericList<int> numbersOriginal= new GenericList<int>(new int[] { 1, 2, 3 });
            Console.WriteLine(numbersOriginal.Count + " " + numbersOriginal);

            Console.ReadKey();
            Console.WriteLine("\nOperator + overload");
            GenericList<int> numbers1 = new GenericList<int>(new int[] { 1, 2, 3, 4, 5 });
            GenericList<int> numbers2 = new GenericList<int>(new int[] { 6, 7, 8, 9, 10 });
            GenericList<int> numbers3 = numbers1 + numbers2;

            foreach (var item in numbers1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in numbers3)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("\nOperator - overload");

            GenericList<string> strings1 = new GenericList<string>(new string[] { "hello", "goodbye", "good morning", "good night"});
            GenericList<string> strings2 = new GenericList<string>(new string[] { "baseball", "basketball"});
            GenericList<string> strings3 = strings1 + strings2;

            Console.WriteLine("List A");
            foreach (var item in strings1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List B");

            foreach (var item in strings2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Combined List");
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


            Console.WriteLine(zipList3);
            Console.WriteLine(zipList4);
            zipList3.Zip(zipList4);
            Console.WriteLine(zipList3);
            Console.ReadKey();
        }
    }
}
