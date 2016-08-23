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

            stringList.Add("country");
            stringList.Add("dob");

            foreach (var category in stringList)
            {
                Console.WriteLine(category);

            }
            stringList.Remove("age");
            stringList.Remove("city");

            foreach (var category in stringList)
            {
                Console.WriteLine(category);
           
            }


            Console.ReadLine();
        }
    }
}
