using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LING_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[] { 12, 43, 23, 54, 76, 87, 34, 56, 76, 96, 29, 41 };
            var item = from i in age where i > 90 select i;
            foreach (var i in item)
                {
                Console.WriteLine(i);
            }
            Console.ReadLine();


        }
    }
}
