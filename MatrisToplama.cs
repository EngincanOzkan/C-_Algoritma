using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_3
{
    class MatrisToplama
    {
        static void Main(string[] args)
        {
            Console.Write("A matrisinin satır sayısı: ");
            int aSatir = int.Parse(Console.ReadLine());
            Console.Write("A matrisinin sütun sayısı: ");
            int aSutun = int.Parse(Console.ReadLine());

            Console.Write("B matrisinin satır sayısı: ");
            int bSatir = int.Parse(Console.ReadLine());
            Console.Write("B matrisinin sütun sayısı: ");
            int bSutun = int.Parse(Console.ReadLine());


            if (aSatir == bSatir && aSutun == bSutun)
            {
                Console.WriteLine("Matrisler arası toplama işlemi yapılabilir.");
                Console.WriteLine("*******************************************");

                int[,] matrisA = new int[aSatir, aSutun];
                int[,] matrisB = new int[bSatir, bSutun];

                int[,] matrisC = new int[bSatir, bSutun];

                for (int i = 0; i < aSatir; i++)
                {
                    for (int j = 0; j < aSutun; j++)
                    {
                        Console.Write("a({0},{1}) degeri: ",i,j);
                     matrisA[i, j] = int.Parse(Console.ReadLine());
                        Console.Write("b({0},{1}) degeri: ", i, j);
                     matrisB[i, j] = int.Parse(Console.ReadLine());

                     matrisC[i, j] = matrisA[i, j] + matrisB[i, j];

                    }
                }

                Console.WriteLine("Bu iki matrisin toplamı: ");

                for (int i = 0; i < aSatir; i++)
                {
                    for (int j = 0; j < aSutun; j++)
                    {
                        Console.Write(matrisC[i,j] + " ");
                    }
                    Console.Write("\n");
                }

            }
            else Console.WriteLine("Bu iki matris arasında toplama işlemi yapılamaz.");

            Console.ReadKey();
        }
    }
}
