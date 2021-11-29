using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGreenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WELKOM BIJ GREENHOUSE RESTAURANT");
            Console.WriteLine("====================================");

            Console.WriteLine("Kies een grootte (klein of groot):");
            string grootte = Console.ReadLine();
            Console.WriteLine("Kies een basis (quinoa, rijst of salade): ");
            string basis = Console.ReadLine();
            Console.WriteLine("Kies een soort (vegan, zalm of kip): ");
            string soort = Console.ReadLine();
            Console.WriteLine("Je bestelling: een " + grootte + " " + basis + " met " + soort);
            Console.ReadLine();
           
        }
    }
}
