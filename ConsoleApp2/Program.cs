using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
      public  static void Main(string[] args)
        {
            var a = new Fractorial(5, 4);
            var b = new Fractorial(1, 2);
            Console.WriteLine(-a);   // output: -5 / 4
            Console.WriteLine(a + b);  // output: 14 / 8
            Console.WriteLine(a - b);  // output: 6 / 8
            Console.WriteLine(a * b);  // output: 5 / 8
            Console.WriteLine(a / b);  // output: 10 / 4
            Console.WriteLine("-----------------------------------------------");
            // wywołuje metody RoundUp oraz RoundDown
            Console.WriteLine(a.RoundUp());
            Console.WriteLine(a.RoundDown());
            Console.WriteLine("----------------------------------------------");
            // Sprawdzam za pomocą losowych 10 ułamków czy interfejs IComparable działa poprawnie losując najpierw ułamkie a następnie je sortuje
            Fractorial[] fraction;
            fraction = new Fractorial[10];
            Random random = new Random(10);
            for (int i = 0; i < 10; ++i)
            {
                fraction[i] = new Fractorial(random.Next(10), random.Next(10));
                Console.WriteLine(fraction[i]);
            }
            Console.WriteLine("------------------------------------------------");
            System.Array.Sort(fraction);

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(fraction[i]);
            }
        }
    }
}
