using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Ali", "Mehmet", "Süleyman", "Yavuz" };

            names.Add("Fatih");

            names.Remove("Yavuz");

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
        }
    }
}
