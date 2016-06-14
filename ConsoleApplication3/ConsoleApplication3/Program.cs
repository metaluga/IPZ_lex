using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "1234";
            int testOut =0;

            Console.Write(Int32.TryParse(test, out testOut));
            /*
            Console.Write(testOut);
            */

        }
    }
}
