using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciHafta6_a_
{
    class MukemmelSayi
    {
        static void Main(string[] args)
        {
            int ilksayi = 1;
            int ikincisayi = 1;
            int aradeger = 0;
            Console.Write("(Kendisine kadar olan fibonacci sayılarını sıralayacak) Sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            while (ikincisayi+ilksayi<sayi)
            {
                aradeger = ikincisayi;
                ikincisayi = ikincisayi + ilksayi;
                ilksayi = aradeger;
                Console.WriteLine(ikincisayi);
            }
            Console.ReadKey();
        }
    }
}
