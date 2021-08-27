using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //başvuran bilgileri alınır, değerlendirilir.
            //IkrediManager dan referans aldığımız için, başvuruyu türden bağımsız olarak almış olduk.
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }

        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
