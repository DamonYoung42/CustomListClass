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
            Console.WriteLine(stringList.Count);

            stringList.Add("country");
            stringList.Add("dob");

            foreach (var category in stringList)
            {
                Console.WriteLine(category);

            }

            Console.WriteLine(stringList.Count);
            stringList.Remove("age");
            stringList.Remove("city");

            foreach (var category in stringList)
            {
                Console.WriteLine(category);
           
            }

            Console.WriteLine(stringList.ToString());

            Console.WriteLine(stringList.Count);

            //GenericList<int> numbers1 = new GenericList<int>(new int[] { 1, 2, 3, 4, 5 });
            //GenericList<int> numbers2 = new GenericList<int>(new int[] { 6, 7, 8, 9, 10 });
            //GenericList<int> numbers3 = new GenericList<int>();

            //Console.WriteLine(numbers1.Add(numbers1, numbers2));



            Console.ReadLine();
        }
    }
}
