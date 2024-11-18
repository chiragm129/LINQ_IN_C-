using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
     class Linq_to_object
    {
        static void Main(string[] args)
        {
            //there are three type of linq
            // this is linq to object type

            //int[] age = { 12, 23, 21, 22, 45, 33, 2, 26, 55, 66 };
            //var a = from i in age where i > 20 orderby i descending select i;

            string[] names = { "Ram", "Shyam", "krishn", "Chirag" };
            var a = from name in names where name.Contains("a") select name;

            foreach (string item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
