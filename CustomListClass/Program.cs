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

            foreach (var category in stringList)
            {
                Console.WriteLine(category);

            }

            //Count property
            Console.WriteLine(stringList.Count);

            //Add item to T[]
            stringList.Add("country");
            stringList.Add("dob");

            foreach (var category in stringList)
            {
                Console.WriteLine(category);

            }

            //Count property
            Console.WriteLine(stringList.Count);

            //Remove item from T[]
            stringList.Remove("age");
            stringList.Remove("city");

            foreach (var category in stringList)
            {
                Console.WriteLine(category);
           
            }

            //ToString function
            Console.WriteLine(stringList.ToString());

            GenericList<int> numbersOriginal= new GenericList<int>(new int[] { 1, 2, 3 });
            Console.WriteLine(numbersOriginal.ToString());



            //Count property
            Console.WriteLine(stringList.Count);

            Console.WriteLine("\nOperator + overload");
            GenericList<int> numbers1 = new GenericList<int>(new int[] { 1, 2, 3, 4, 5 });
            GenericList<int> numbers2 = new GenericList<int>(new int[] { 6, 7, 8, 9, 10 });
            GenericList<int> numbers3 = numbers1 + numbers2;

            Console.WriteLine(numbers1);
            Console.WriteLine(numbers2);
            Console.WriteLine(numbers3);
            Console.WriteLine("");

            GenericList<string> strings1 = new GenericList<string>(new string[] { "hello", "goodbye", "good morning", "good night"});
            GenericList<string> strings2 = new GenericList<string>(new string[] { "baseball", "basketball"});
            GenericList<string> strings3 = strings1 + strings2;

            Console.WriteLine(strings1);
            Console.WriteLine(strings2);
            Console.WriteLine(strings3);

            Console.WriteLine("\nOperator - overload");
            GenericList<int> tenNumbers = new GenericList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            GenericList<int> evenNumbers = new GenericList<int>(new int[] { 2, 4, 6, 8, 10 });
            GenericList<int> oddNumbers = tenNumbers - evenNumbers;
            Console.WriteLine("List of first 10 numbers: {0}", tenNumbers);
            Console.WriteLine("List of even numbers: {0}", evenNumbers);
            Console.WriteLine("First 10 numbers minus even numbers: {0}", oddNumbers);

            Console.ReadLine();
        }
    }
}
