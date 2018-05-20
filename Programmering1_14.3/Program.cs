using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_14._3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Skriv ett tal för att räkna ut dess Fibonacci: ");
            Console.WriteLine(Fibonacci(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }

        static int Fibonacci(int f) {
            if(f <= 2)
                return 1;
            else
                return Fibonacci(f - 1) + Fibonacci(f - 2);
        }
    }
}
