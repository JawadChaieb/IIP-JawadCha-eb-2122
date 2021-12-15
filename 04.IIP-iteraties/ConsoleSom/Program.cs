using System;

namespace ConsoleSom
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int getal;
            string stop;



            do
            {
                Console.Write("voer en getal in (q om te stoppen): ");
                stop = Console.ReadLine();
                if (stop != "q")
                {
                    som += Convert.ToInt32(stop);
                }
                else
                    Console.WriteLine($"De som is: {som}");

                } while ( stop != "q");
            Console.ReadLine();


            //Console.Write($"de som is: {som}");
            //console.readkey();
        }
    }
}
