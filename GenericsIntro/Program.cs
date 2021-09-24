using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> isimler = new List<string>() { "Ahmet", "Salih", "Emre" };

            //isimler.Add("Mehmet");

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            MyList<string> names = new MyList<string>();

            names.Add("Nalan");
            names.Add("Selma");

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }







        }
    }
}
