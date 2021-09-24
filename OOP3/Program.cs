using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(ihtiyacKrediManager);                                 //1
            basvuruManager.BasvuruYap(tasitKrediManager);                                   //2
            basvuruManager.BasvuruYap(konutKrediManager);                                   //3


        }
    }
}
