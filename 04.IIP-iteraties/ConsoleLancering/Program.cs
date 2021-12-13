using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel seconden tot lancering?");
            int seconden = Convert.ToInt32(Console.ReadLine());
            for (int i = seconden; i != 0; i--)
                {
                Console.WriteLine(i);
            }
            Console.WriteLine("Lift off!");
            Console.ReadLine();
        }
    }
}
