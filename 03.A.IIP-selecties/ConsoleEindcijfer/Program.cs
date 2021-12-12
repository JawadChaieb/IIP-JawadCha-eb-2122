using System;

namespace ConsoleEindcijfer
{
    class Program
    {
        static void Main(string[] args)
        {
            double eindcijfer;
            double dagelijksw, project, examen;

            Console.WriteLine("BERKENING EINDCIJFER");
            Console.WriteLine("====================");

            Console.WriteLine("Geef het cijfer dagelijks werk (op 20): ");
            dagelijksw = Convert.ToDouble(Console.ReadLine());
            dagelijksw = (dagelijksw / 2) * 3;

            Console.WriteLine("Geef het cijfer op het project (op 20): ");
            project = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef het cijfer op het examen (op 20): ");
            examen = Convert.ToDouble(Console.ReadLine());
            examen = (examen / 2) * 5;

            eindcijfer = dagelijksw + project + examen;
            Console.WriteLine("Je eindcijfer is " + eindcijfer + " %");

            if (eindcijfer < 50)
            {
                Console.WriteLine("-> Onvoldoende");
            }
            else if (eindcijfer >= 50 && eindcijfer < 67.5)
            {
                Console.WriteLine("-> Voldoende");
            }
            else if (eindcijfer >= 67.5 && eindcijfer < 75)
            {
                Console.WriteLine("-> Onderschijding");
            }
            else if(eindcijfer > 75 && eindcijfer < 82.5)
            {
                Console.WriteLine("-> Grote onderschijding");
            }
            else if (eindcijfer > 82.5)
            {
                Console.WriteLine("-> Grootste onderschijding");
            }

            Console.ReadLine();
        }
    }
}
