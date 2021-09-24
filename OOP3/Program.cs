using System;
using System.Collections.Generic;

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

            //basvuruManager.BasvuruYap(ihtiyacKrediManager);                                 //1
            //basvuruManager.BasvuruYap(tasitKrediManager);                                   //2
            //basvuruManager.BasvuruYap(konutKrediManager);                                   //3

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService msmLoggerService = new MsmLoggerService();

            //tek log tanımı olursa sorunsuz çalışacak kod
            //basvuruManager.BasvuruYap(tasitKrediManager, logger1);

            //birden fazla veya hiç log işlemi olmasa dahi çalışacak kod

            List<ILoggerService> listLogger = new List<ILoggerService>();

            listLogger.Add(fileLoggerService);
            listLogger.Add(msmLoggerService);
            

            basvuruManager.BasvuruYap(ihtiyacKrediManager, listLogger);
        }
    }
}
