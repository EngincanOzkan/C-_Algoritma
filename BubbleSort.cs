using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_1
{
    class BubbleSort
    {

            static int[] Buble_Sort(int[] dizi)
            {
            int esit = 1;

            while (esit != dizi.Length)
            {
                esit = 1;
                for (int i = 0; i < dizi.Length - 1; i++)
                {
                    if (dizi[i] > dizi[i + 1])
                    {
                        int aradeger = dizi[i + 1];
                        dizi[i + 1] = dizi[i];
                        dizi[i] = aradeger;
                    }
                    else
                    {
                        esit++;
                    }
                }
            }
                 return dizi;
            }

        static void Main(string[] args)
        {
            Console.Write("Dizi adeti giriniz: ");
            int adet = int.Parse(Console.ReadLine());
            int[] dizi = new int[adet];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}. karakter: ", i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }

            dizi = Buble_Sort(dizi);
            Console.Write("Dizinin sıralı hali: ");
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();
        }

    }
}
