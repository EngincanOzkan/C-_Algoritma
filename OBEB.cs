using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_4._1
{
    class OBEBHesap
    {
        static int obeb(int a,int b /*, int c*/)
        {
            //--KISA YOL--
            int enBuyuk = 0;
            if (a > b) enBuyuk = a;
            else enBuyuk = b;

            for (int i = enBuyuk; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0) return i;
            }

            return 1;

            //---UZUN YOL---
            //int ilkA = a, ilkB=b;
            //int sonuc = 1;
            //do
            //{
            //    if (a % c == 0 && b % c == 0)
            //    {
            //        a = a / c;
            //        b = b / c;
            //        sonuc = sonuc * c;
            //    }
            //    else
            //    {
            //        if (a % c == 0) a = a / c;
            //        else if(b%c == 0) b = b / c;

            //        bool asalmi = true;

            //        do
            //        {
            //            asalmi = true;
            //            c++;
            //            for (int i = 2; i < c/2; i++)
            //            {
            //                if (c % i == 0) asalmi = false;
            //            }
            //        } while (!asalmi);
            //    }
            //  } while (sonuc < a || sonuc < b && ilkA / 2 > c && ilkB / 2 > c);
            //if (sonuc > ilkA || sonuc > ilkB) return 1;
            //    else return sonuc;

        }
        static void Main(string[] args)
        {
            Console.Write("a sayısını girin:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b sayısını girin:");
            int b = int.Parse(Console.ReadLine());

            int sonuc = obeb(a, b/*,2*/);
             Console.WriteLine(sonuc);

            Console.ReadKey();
        }
    }
}
