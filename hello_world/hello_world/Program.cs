using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лёша-картоша.");
            char key = Console.ReadKey().KeyChar;

            Console.WriteLine();

            Console.WriteLine(key);
            Console.ReadKey();
        }
    }
}
