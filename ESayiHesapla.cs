using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_4
{
    class ESayiHesapla
    {
        static double faktoriyel(double sayi)
        {
            double fak=1;
            for (int i = 1; i <= sayi; i++)
            {
                fak *= i;
            }
            return fak;
        }
        static double e_hesapla(int sayi)
        {
            double toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += 1 / faktoriyel(i);
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(e_hesapla(x));
            Console.ReadKey();
        }
    }
}
