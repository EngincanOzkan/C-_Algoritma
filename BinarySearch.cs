using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace soru_4
    {
        public class BinarySearch
        {


            static int[] Selection_Sort(int[] dizi)
            {
                int enKucuk, enKucukIndexi = 0;
                for (int i = 0; i < dizi.Length - 1; i++)
                {
                    enKucuk = dizi[i];

                    for (int j = i; j < dizi.Length; j++)
                    {
                        if (enKucuk >= dizi[j])
                        {
                            enKucuk = dizi[j];
                            enKucukIndexi = j;
                        }
                    }

                    int aradeger = dizi[i];
                    dizi[i] = enKucuk;
                    dizi[enKucukIndexi] = aradeger;
                }
                return dizi;
            }


            static int Binary_Search(int[] dizi, int aranan)
            {
                dizi = Selection_Sort(dizi);
                int arama = dizi.Length-1,sayac=0;
                while (dizi[arama/2] != aranan && sayac != dizi.Length)
                {
                if (aranan < dizi[arama / 2])
                {
                    arama = arama / 2;
                }
                else if (aranan > dizi[arama / 2])
                {
                    arama = arama + arama / 2;
                }
                else if (aranan == dizi[arama / 2]) { break; }

                sayac++;
                }
            if (dizi[arama/2] == aranan) return (arama/2)+1;
            else  return -1;


            }
            public static void Main(string[] args)
            {
                Console.Write("Dizi adeti giriniz: ");
                int adet = Convert.ToInt32(Console.ReadLine());
                int[] dizi = new int[adet];
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write("{0}. karakter: ", i + 1);
                    dizi[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Aranan sayıyı giriniz: ");
                int aranan = int.Parse(Console.ReadLine());
                Console.Write("Aranan sayıyının indeksi: ");
                Console.Write(Binary_Search(dizi, aranan));

                Console.ReadKey();


            }
        }
    }
