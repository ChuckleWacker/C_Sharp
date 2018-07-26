using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test WriteLine command");
            Console.WriteLine(""); // Empty Line
            string a = "First";
            string b = "Last";
            Console.WriteLine("Displaying variable A = {0} and B = {1}", a, b);
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();  //

        }
    }
}
