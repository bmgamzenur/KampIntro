using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aşağıdaki 2 tanımlama da doğrudur. Interface ler de implemente eden class ın referans numarasını tutabiliyor.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //2.tanımlama şekli: ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),new List<ILoggerService> { new SmsLoggerService(),new DatabaseLoggerService()});
            //2.tanımlamaya göre istek şekli: basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmeYap(krediler);

        }
    }
}
