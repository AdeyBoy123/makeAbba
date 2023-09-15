using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeAbba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string a = Console.ReadLine();

            Console.WriteLine("Input another string: ");
            string b = Console.ReadLine();

            Console.WriteLine(makeAbba(a, b));
            Console.ReadLine();
        }

        static string makeAbba(string a, string b)
        {
            return a + b + b + a;
            
        }
    }
}
