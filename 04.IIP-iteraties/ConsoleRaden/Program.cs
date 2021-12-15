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
            int pogingen = 0;
            Random geheimgetal = new Random();
            
            Console.WriteLine("Raad een getal tussen 1 en 10");
            int getal;
            do
            {
                pogingen++;
                if (pogingen > 3)
                    {
                    Console.WriteLine("Volgende keer beter");
                    Console.ReadKey();
                }
                else
                
                    Console.Write($"Poging {pogingen}:");
                    getal = Convert.ToInt32(Console.ReadLine());
                
               
            } while (getal != geheimgetal.Next(1, 11));
            
            Console.WriteLine("Geraden");
            Console.ReadKey();
        }
    }
}
