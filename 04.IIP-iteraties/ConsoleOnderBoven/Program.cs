using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnderBoven
{
    class Program
    {
        static void Main(string[] args)
        {
            int ondergrens;
            int bovengrens;
            Console.Write("Geef een ondergrens:");
            ondergrens = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef een bovengrens:");
            bovengrens = Convert.ToInt32(Console.ReadLine());
            while (bovengrens <= ondergrens)
                {
                Console.Write($"Bovengrens mag niet kleiner zijn dan ondergrens. geef een bovengrens:");
                bovengrens = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Bereik: van {ondergrens} tot {bovengrens}");
            Console.ReadKey();
        }
    }
}
