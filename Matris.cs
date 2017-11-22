using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_1
{
    class Matris
    {
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
                    Console.Write("a({0},{1}). eleman: ",i,j);
                    dizi[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("******************************DİZİ********************************");

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(dizi[i,j]+" ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
