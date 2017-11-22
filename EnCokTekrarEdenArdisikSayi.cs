using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_4
{
    class EnCokTekrarEdenArdisikSayi
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 3, 4, 4, 4,4,4,4,4,4,4,4,4, 5, 3, 3, 3, 3, 3, 3 };

            int bas = 0, bit = 0, enbuyukbas=0;
            int enuzun = dizi[0];
            int kontrol = dizi[0];

            int sayac = 0,arasayac = 1;

            for (int i = 1; i < dizi.Count(); i++)
            {
                if (kontrol == dizi[i])
                {
                    arasayac++;
                }
                else if (kontrol != dizi[i])
                {
                    if (arasayac > sayac)
                    {
                        sayac = arasayac;
                        enuzun = kontrol;
                        bit = i;
                        enbuyukbas = bas;
                    }
                    kontrol = dizi[i];
                    arasayac = 1;
                    bas = i;
                }
            }
            if (arasayac > sayac)
            {
                sayac = arasayac;
                enuzun = kontrol;
                bit = dizi.Length-1;
            }
 Console.WriteLine("En çok tekrar eden ardışık sayı = {0}, {1} kere tekrarlanmış, baş:{2} son:{3}",
                enuzun,sayac,enbuyukbas+1,bit+1);

            Console.ReadKey();
        }
    }
}
