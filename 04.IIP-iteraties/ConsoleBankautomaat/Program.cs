using System;

namespace ConsoleBankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            const string AFHALEN = "welke bedrag wil je afhalen: ";
            const string STORTEN = "Welke bedrag wil je storten: ";
            const string STOPPEN = "Bedankt en tot ziens";


            Console.WriteLine("Bankautomaat");
            Console.WriteLine("============");

            char automaat;
            string keuze = "";
            int saldo = 500;
            do
            {
                Console.WriteLine("a. afhaling");
                Console.WriteLine("b. storting");
                Console.WriteLine("c. stoppen");

                Console.Write($"je keuze: ");
                automaat = Convert.ToChar(Console.ReadLine());

                if (automaat != 'c')
                {
                    switch (automaat)
                    {
                        case 'a':
                            keuze = AFHALEN;
                            break;
                        case 'b':
                            keuze = STORTEN;
                            break;
                        case 'c':
                            keuze = STOPPEN;
                            break;
                    }
                }
                if (automaat == 'a')
                {
                    Console.WriteLine($"{keuze}");
                    int afhalen = Convert.ToInt32(Console.ReadLine());

                    saldo -= afhalen;
                    Console.WriteLine($"storten ok - het nieuwe saldo is {saldo}");

                }
                else if (automaat == 'b')
                {
                    Console.WriteLine($"{keuze}");
                    int storten = Convert.ToInt32(Console.ReadLine());
                    saldo += storten;
                    Console.WriteLine($"afhaling ok - het nieuwe saldo is {saldo}");
                }
                else if (automaat == 'c')
                {
                    Console.WriteLine($"{keuze}");
                }
                else
                {
                    Console.WriteLine("ongeldige keuze");
                }
            } while (automaat != 'c');
        }
    }
}
