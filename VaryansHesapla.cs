using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_1
{
    class VaryansHesapla
    {
        static void Main(string[] args)
        {
            int adet = int.Parse(Console.ReadLine());

            int[] not = new int[adet];
            int toplam = 0,ort = 0;
            double varyans = 0,sSapma=0;

            for (int i = 0; i < adet; i++)
            {
                not[i] = int.Parse(Console.ReadLine());
                toplam += not[i];
            }

            ort = toplam / adet;

            toplam = 0;

            for (int i = 0; i < adet; i++)
            {
                not[i] = not[i] - ort;
                not[i] = not[i] * not[i];
                toplam += not[i];
            }

            varyans = double.Parse(toplam.ToString()) / double.Parse((adet - 1).ToString());
            sSapma = Math.Sqrt(varyans);

            Console.WriteLine("varyans: {0}/standart sapma: {1}",varyans,sSapma);

            Console.ReadKey();
        }
    }
}
