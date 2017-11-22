using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukemmelsayi_b_
{
    class MukemmelSayi2
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı giriniz: ");
            int toplam = 0;
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
            {
                for (int j = 1; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        toplam += j;
                    }
                }
                if (toplam == i)
                {
                    Console.WriteLine(i);
                }
                toplam = 0;
            }

            Console.ReadKey();
        }
    }
}
