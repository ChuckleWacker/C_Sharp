using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;
            Console.WriteLine("What's your favorite color?");
            color = Console.ReadLine();
            Console.WriteLine("Your favorite color is {0}", color);

            Console.WriteLine("");

            int age;
            Console.WriteLine("What's your age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0}", age);

            Console.ReadKey(); // Break
        }
    }
}
