using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //birer tane manager ve log istenirse
        /*
        public void BasvuruYap(IKrediManager krediManager, ILoggerService logger)
        {
            krediManager.Hesapla();
            logger.Log();

        }
        
        ---------------------------------------------------
        */



        //birden fazla log istenirse

        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggers)
        {
            krediManager.Hesapla();

            //tek satır kodda bir kaç tane farklı log u göremeyeceğimden FOREACH en mantıklı çözümdür

            foreach (var log in loggers)
            {
                log.Log();
            }

        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
 
    }
}
