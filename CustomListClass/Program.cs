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

            GenericList<string> animals = new GenericList<string>(new string[] { "dog", "cat", "monkey", "panda", "elephant", "fish", "reptile", "giraffe",
                "bear", "dolphin", "shark", "lion", "tiger", "whale",  "rhinoceros" });
            Console.WriteLine("Animal List");
           
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);

            }

            //Count property
            Console.WriteLine("\nAnimal Count");
            Console.WriteLine(animals.Count);

            Console.WriteLine("\nAdd stingray to list");
            animals.Add("stingray");
            Console.WriteLine("Add liger to list");
            animals.Add("liger");

            Console.WriteLine();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);

            }

            //Count property
            Console.WriteLine("\nAnimal Count");
            Console.WriteLine(animals.Count);

            Console.WriteLine("\nRemove monkey from list");
            animals.Remove("monkey");
            Console.WriteLine("Remove liger from list");
            animals.Remove("liger");

            Console.WriteLine("");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
           
            }

            Console.WriteLine("\nCalling ToString(), with Count property");
            Console.WriteLine(animals.Count + " " + animals.ToString());

            //Console.ReadKey();
            //Console.WriteLine("Calling ToString(), with Count property");
            //GenericList<int> numbersOriginal= new GenericList<int>(new int[] { 1, 2, 3 });
            //Console.WriteLine(numbersOriginal.Count + " " + numbersOriginal.ToString());

            Console.ReadKey();
            Console.WriteLine("\nOperator + overload");
            GenericList<int> numbersOriginal = new GenericList<int>(new int[] { 1, 2, 3});
            GenericList<int> moreNumbers = new GenericList<int>(new int[] { 4,5,6, 7, 8, 9, 10 });
            GenericList<int> combinedNumbers = numbersOriginal + moreNumbers;
            Console.WriteLine("\nFirst List");
            foreach (var number in numbersOriginal)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nSecond List");
            foreach (var number in moreNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n+ List");
            Console.WriteLine();
            foreach (var number in combinedNumbers)
            {
                Console.WriteLine(number);
            }
            //Console.ReadKey();
            //Console.WriteLine("\nOperator + overload");

            //GenericList<string> strings1 = new GenericList<string>(new string[] { "hello", "goodbye", "good morning", "good night"});
            //GenericList<string> strings2 = new GenericList<string>(new string[] { "baseball", "basketball"});
            //GenericList<string> strings3 = strings1 + strings2;

            //Console.WriteLine("\nList A");
            //foreach (var item in strings1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\nList B");

            //foreach (var item in strings2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n+ List");
            //foreach (var item in strings3)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();

            //Operator - overload
            Console.WriteLine("\nOperator - overload");
            GenericList<int> firstTenNumbers = new GenericList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            //GenericList<int> evenNumbers = new GenericList<int>(new int[] { 2, 4, 6, 8, 10 });
            GenericList<int> evenNumbers = new GenericList<int>(new int[0]);
            foreach (var number in firstTenNumbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            GenericList<int> oddNumbers = firstTenNumbers - evenNumbers;
            Console.WriteLine("\nList of first 10 numbers: {0}", firstTenNumbers);
            Console.WriteLine("List of even numbers: {0}", evenNumbers);
            Console.WriteLine("First 10 numbers minus even numbers: {0}", oddNumbers);

            //Zipper function
            Console.WriteLine("\nZipper function");
            GenericList<string> zipList1 = new GenericList<string>(new string[] { "one", "two", "three", "four","five" });
            GenericList<string> zipList2 = new GenericList<string>(new string[] { "10", "20", "30" });
            GenericList<int> zipList3 = new GenericList<int>(new int[] { 1, 2, 3, 4, 5 });
            GenericList<int> zipList4 = new GenericList<int>(new int[] { 6, 7, 8, 9, 10 });

            Console.WriteLine("");
            Console.WriteLine(zipList1);
            foreach (var item in zipList1)
            {
                Console.WriteLine("Ziplist1: " + item);
            }

            Console.WriteLine("");
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

            GenericList<int> numbers = new GenericList<int>(new int[0]);
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {

                numbers.Add(random.Next(1, 100));
            }

            Console.WriteLine("Original list: {0}", numbers);
            numbers.Sort();
            Console.WriteLine("Sorted list: {0}", numbers);
            Console.ReadLine();

            GenericList<string> names = new GenericList<string>(new string[] { "Tommy", "Rachel","Isaac", "Brock", "Glen", "Jacob", "Dylan" });
            Console.WriteLine("Original list: {0}", animals);
            animals.Sort();
            Console.WriteLine("Sorted list: {0}", animals);
            Console.ReadLine();


            GenericList<string> sortStringList2 = new GenericList<string>(new string[] { "Tommy", "1", "Isaac", "3", "Glen", "500", "Dylan" });
            Console.WriteLine("Original list: {0}", sortStringList2);
            sortStringList2.Sort();
            Console.WriteLine("Sorted list: {0}", sortStringList2);
            Console.ReadLine();


        }
    }
}
