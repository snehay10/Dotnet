using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
   public enum nm
    {
        sneha = 0,
        yadav,
        sai,
        a,
        b,
        c,
        d
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            nm n=new nm();
            
            Console.WriteLine(n);
            var a = (nm)1;
            Console.WriteLine(a);
            var b= (nm)4;
            Console.WriteLine(b);
            
        }
    }
}
