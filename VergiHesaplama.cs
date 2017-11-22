using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vergiHafta5
{
    class VergiHesaplama
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************Vergi Hesaplayıcı**********************");
            Console.Write("Aylık Maaşınızı girin: ");
            double maas = double.Parse(Console.ReadLine());
            if (maas * 12 < 15000)  Console.WriteLine("Vergi vermenize gerek yoktur yıllık maaşınız: {0}", maas * 12);
            else if ((maas * 12 >= 15000) && (maas * 12 < 29000))
            {
                Console.WriteLine("Aylık maaşınızın (%10){0} TL'si vergi olarak verilmektedir, Yıllık vergi gideriniz: {1}",(maas/100)*10,((maas*12)/100)*10);
            }
            else if ((maas * 12 >= 30000))
            {
                Console.WriteLine("Aylık maaşınızın (%15){0} TL'si vergi olarak verilmektedir, Yıllık vergi gideriniz: {1}", (maas / 100) * 15, ((maas * 12) / 100) * 15);
            }
            Console.ReadKey();
        }
    }
}
