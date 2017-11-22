using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_2
{
    class MatrisSatirdakiEnBuyukBulma
    {
        static int[] enbuyuk(int satir,int sutun, int[,] dizi)
        {
            int[] sonuc = new int[satir];
            int kDeger;
            for (int i = 0; i < satir; i++)
            {
                kDeger = dizi[i, 0];
                for (int j = 1; j < sutun; j++)
                {
                    if (kDeger < dizi[i, j]) kDeger = dizi[i, j];
                }
                sonuc[i] = kDeger;
            }

            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.Write("Satır sayısını girin:");
            int satir = int.Parse(Console.ReadLine());
            Console.Write("Sütun sayısını girin:");
            int sutun = int.Parse(Console.ReadLine());

            int[,] dizi = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("a({0},{1}). eleman: ", i, j);
                    dizi[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("******************************DİZİ********************************");

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }

           int[] enBuyukler = enbuyuk(satir,sutun, dizi);

            Console.Write("En Büyükler: ");

            foreach (var item in enBuyukler)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();

        }
    }
}
