using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_3
{
    class TersCevirme
    {
        static int[] terscevir(int[] dizi)
        {
            int aradeger = 0;

            for (int i = 0; i < dizi.Length / 2; i++)
            {
                aradeger = dizi[i];
                dizi[i] = dizi[dizi.Length - 1 - i];
                dizi[dizi.Length - 1 - i] = aradeger;
            }


            return dizi;
        }
        static void Main(string[] args)
        {
            int adet = int.Parse(Console.ReadLine());
            int[] sayi = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                sayi[i] = int.Parse(Console.ReadLine());
            }

           sayi = terscevir(sayi);


            Console.WriteLine("********************************************");

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(sayi[i]);
            }

            Console.ReadLine();
        }
    }
}
