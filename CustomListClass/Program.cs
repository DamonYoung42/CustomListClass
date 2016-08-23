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
            

            stringList.Add("country");
            stringList.Add("dob");

            stringList.Remove("age");
            stringList.Remove("city");

            Console.ReadLine();
            //numberList.Add(itemToAdd);
            //Console.WriteLine(stringList);
            //Console.ReadKey();
            //itemToRemove = 2;
            //nameList.Remove(itemToRemove);
        }
    }
}
