using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies een getal tussen 1 en 7: ");
            int gok = Convert.ToInt32(Console.ReadLine());

            if (gok == 5)
            {
                Console.WriteLine("De gok is juist");
            }
            else if (gok > 5)
            {
                Console.WriteLine("de gok was te hoog");
            }
            else if (gok < 5)
            {
                Console.WriteLine("De gok was te laag");
            }
            Console.ReadLine();
        }
    }
}
