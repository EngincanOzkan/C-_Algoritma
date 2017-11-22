using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_1
{
    class AsalSayi
    {

        static bool asal_kontrol(int sayi)
        {
            bool asalmi = true;

            for (int i = 2; i < Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) {
                    asalmi = false;
                    break;
                }
            }

            return asalmi;
        }

        static void Main(string[] args)
        {

            int x=0;
            while (asal_kontrol(x))
            {
                Console.Write("Sayı giriniz: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sayı Asal Değil!!");

            Console.ReadKey();
        }
    }
}
