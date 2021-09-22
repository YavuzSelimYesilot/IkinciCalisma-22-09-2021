using System;

namespace OriginalMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Basit Dört İşlem Uygulaması-----");
            Console.WriteLine();
            Console.WriteLine();

            double num1;
            double num2;

            Console.WriteLine("Lütfen ilk sayıyı giriniz: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Process process = new Process();

            process.Addition(num1, num2);
            process.Extraction(num1, num2);
            process.Multipication(num1, num2);
            process.Division(num1, num2);

        }
    }
}
