using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye", "coho" };

            // Remove an element from the list by specifying
            // the object.
            salmons.Remove("coho");
            salmons.Remove("coho");
            salmons.Remove("coho");
            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
        }
    }
}
