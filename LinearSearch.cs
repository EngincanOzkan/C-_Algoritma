using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_3
{
    class LinearSearch
    {
        static int Linear_Search(int[] dizi,int aranan)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == aranan) return i + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            //linear search ==> Doğrusal arama algoritması
            Console.Write("Dizi adeti giriniz: ");
            int adet = int.Parse(Console.ReadLine());
            int[] dizi = new int[adet];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}. karakter: ", i + 1);
                dizi[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Aranan değer ?:  ");
            int aranan = int.Parse(Console.ReadLine());

            Console.Write("aranan elemanın indexi: "+Linear_Search(dizi,aranan));

            Console.ReadKey();

        }
    }
}
