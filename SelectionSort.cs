using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_2
{
    class SelectionSort
    {
        static int[] Selection_Sort(int[] dizi)
        {
            int enKucuk,enKucukIndexi=0;
            for (int i = 0; i < dizi.Length; i++)
            {
                enKucuk = dizi[i];

                for (int j = i; j < dizi.Length; j++)
                {
                    if (enKucuk >= dizi[j])
                    {
                        enKucuk = dizi[j];
                        enKucukIndexi = j; }

                }

                int aradeger = dizi[i];
                dizi[i] = enKucuk;
                dizi[enKucukIndexi] = aradeger;
            }
            return dizi;
        }
        static void Main(string[] args)
        {
            //selection sort
            Console.Write("Dizi adedi giriniz: ");
            int adet = int.Parse(Console.ReadLine());
            int[] dizi = new int[adet];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0} karakter: ",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            dizi = Selection_Sort(dizi);
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
