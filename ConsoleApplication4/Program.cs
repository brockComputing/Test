using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age = -1;
            // added a new comment
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            while (age >= 120 || age < 0)
            {
                Console.WriteLine("Enter your age");
                age = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("Hello " + name);
            Console.WriteLine("you are " + age + " years old");
            Console.WriteLine((age * 12) + " months old");
            Console.WriteLine((age * 365) + " days old");
            Console.WriteLine((age * 365 * 24) + " hours old");
            Console.ReadLine();

        }
    }
}
