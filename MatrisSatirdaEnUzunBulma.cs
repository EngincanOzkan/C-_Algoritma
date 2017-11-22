using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_5
{
    class MatrisSatirdaEnUzunBulma
    {
        static string[] enUzun(int satir,int sutun, string[,] dizi)
        {
            string[] enUzunlar = new string[satir];
            int enUzunHarfAdet = 0,enUzunIndex=0;
            for (int i = 0; i < satir; i++)
            {
                enUzunHarfAdet = 0;
                enUzunIndex = 0;

                for (int j = 0; j < sutun; j++)
                {
                    if (enUzunHarfAdet < dizi[i, j].Length)
                    {
                        enUzunHarfAdet = dizi[i, j].Length;
                        enUzunIndex = j;
                    }
                }
                enUzunlar[i] = dizi[i, enUzunIndex];
            }
            return enUzunlar;
        }

        static void Main(string[] args)
        {
            Console.Write("İsimler matrisinin satır sayısını girin: ");
            int satir = int.Parse(Console.ReadLine());
            Console.Write("İsimler matrisinin sütun sayısını girin: ");
            int sutun = int.Parse(Console.ReadLine());

            string[,] isimler = new string[satir, sutun];

            for (int i = 0; i < satir; i++)
            {

                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("a({0},{1}) değeri: ",i,j);
                    isimler[i, j] = Console.ReadLine();
                }
            }

            string[] enUzunlar = enUzun(satir, sutun, isimler);

            Console.WriteLine("**********************************");

            Console.Write("En uzun kelimeler: ");

            for (int i = 0; i < enUzunlar.Length; i++)
            {
                Console.Write(enUzunlar[i]+" ");
            }


            Console.ReadKey();

        }
    }
}
