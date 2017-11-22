using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_2
{
    class HarfVeTekrari
    {
        static void Main(string[] args)
        {
            string metin = Console.ReadLine();

            int konsayac = 0;

            char[] harf =new char[metin.Length];
            int[] adet= new int[metin.Length];

            for (int i = 0; i < metin.Length; i++)
            {

                bool zatenVar = false;
                for (int k = 0; k < harf.Count(); k++)
                {
                    if (harf[k] == metin[i])
                    {
                        zatenVar = true;
                        break;
                    }
                }

                if (zatenVar)
                    continue;




                int sayac = 0;

                for (int j = i; j < metin.Length; j++)
                {
                    if (metin[i] == metin[j])
                    {

                        sayac++;

                    }
                }
                harf[konsayac] = metin[i];
                adet[konsayac] = sayac;

                konsayac++;
            }

            for (int i = 0; i < harf.Count(); i++)
            {
                if(adet[i]!=0)
                Console.WriteLine("harf: {0},adet: {1}",harf[i],adet[i]);
            }


            Console.ReadKey();
        }
    }
}
