using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_4
{
    class HayyamUcgeni
    {
        static void Main(string[] args)
        {
            Console.Write("Hayyam üçgeninin satır sayısını girin: ");
            int satir = int.Parse(Console.ReadLine());
            int sutun = satir * 2 - 1;
            int[,] ucgen = new int[satir, sutun];
            ucgen[0, satir-1] = 1;
            for (int i = 1; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (j - 1 >= 0 && j + 1< sutun) ucgen[i, j] = ucgen[i - 1, j - 1] + ucgen[i - 1, j + 1];
                    else if(j-1<0) ucgen[i, j] = 0 + ucgen[i - 1, j + 1];
                    else if(j+1==satir*2-1) ucgen[i, j] = ucgen[i - 1, j - 1] + 0;
                }
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < satir*2-1; j++)
                {
                    if (ucgen[i, j] == 0) Console.Write(" ");
                    else
                        Console.Write(ucgen[i, j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
