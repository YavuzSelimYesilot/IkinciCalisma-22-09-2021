using System;
using System.Collections.Generic;
using System.Text;

namespace OriginalMath
{
    class Process
    {
        public void Addition(double number1, double number2)
        {
            double result = number1 + number2;

            Console.WriteLine("toplama sonucu: " + result);
        }
        public void Extraction(double number1, double number2)
        {
            double result = number1 - number2;

            Console.WriteLine("çıkarma sonucu: " + result);
        }
        public void Multipication(double number1, double number2)
        {
            double result = number1 * number2;

            Console.WriteLine("çarpma sonucu: " + result);
        }
        public void Division(double number1, double number2)
        {
            double result = number1 / number2;

            Console.WriteLine("bölme sonucu: " + result);
        }


    }
}
