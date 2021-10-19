using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Výpočet BMI");

            Console.ReadLine();

            double hmotnost;
            double výška;
            
            double BMI;

            Console.Write("Zadej hmotnost : ");
            double.TryParse(Console.ReadLine(), out hmotnost);
            Console.ReadLine();

            Console.Write("Zadej výšku : ");
            double.TryParse(Console.ReadLine(), out výška);
            Console.ReadLine();

            BMI = (hmotnost) / (výška/100 * výška/100);
            Console.WriteLine();
            BMI = Math.Round(BMI, 2);
            Console.WriteLine($"Vaše BMI : {BMI}");
            Console.WriteLine();
            




        }
    }
}
