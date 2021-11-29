using System;

namespace ConsoleBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");

            double lengte;
            Console.WriteLine("Lengte (in cm):");
            lengte = Convert.ToInt32(Console.ReadLine());
            lengte = lengte / 100;

            int gewicht;
                
            Console.WriteLine("Gewicht in kg: ");
            gewicht = Convert.ToInt32(Console.ReadLine());

            double bmi = gewicht / (lengte * lengte);
            bmi = Math.Round(bmi,2);
            Console.WriteLine("Je BMI bedraagt: " + bmi);
        }
    }
}
