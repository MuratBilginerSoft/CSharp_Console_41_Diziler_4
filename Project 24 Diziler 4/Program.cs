using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_24_Diziler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array.Sort(Dizinin_İsmi) Dizinin Elemanlarını Küçükten Büyüğe Sıralar.

            int[] Sayılar = new int[] { 2, 67, 43, 56, 1 };

            Console.WriteLine("Standart Sıralanışı");

            for (int i = 0; i < Sayılar.Length; i++)
            {
                Console.WriteLine(Sayılar[i]);
            }


            Array.Reverse(Sayılar);

            Console.WriteLine();
            Console.WriteLine("Standart Ters Sıralanışı");

            for (int i = 0; i < Sayılar.Length; i++)
            {
                Console.WriteLine(Sayılar[i]);
            }

            Array.Sort(Sayılar);

            Console.WriteLine();
            Console.WriteLine("K-B Sıralanışı");

            for (int i = 0; i < Sayılar.Length; i++)
            {
                Console.WriteLine(Sayılar[i]);
            }

            Array.Reverse(Sayılar);

            Console.WriteLine();
            Console.WriteLine("B-K Sıralanışı");

            for (int i = 0; i < Sayılar.Length; i++)
            {
                Console.WriteLine(Sayılar[i]);
            }

            Console.WriteLine();
            Console.WriteLine("B-K Sıralanışı");

            // Array.Clear(Dizi_İsmi,BaşlangıçIndexi,Silinecek_Eleman_Sayısı);

            Array.Clear(Sayılar, 1, 3);

            for (int i = 0; i < Sayılar.Length; i++)
            {
                Console.WriteLine(Sayılar[i]);
            }

            
            Console.WriteLine();
            Console.WriteLine("B-K Sıralanışı");

            Array.Clear(Sayılar, 0, Sayılar.Length);

            //Array.Clear(Sayılar, 2, 1);
            //Array.Clear(Sayılar, 5, 1);
            //Array.Clear(Sayılar, 3, 1);


            for (int i = 0; i < Sayılar.Length; i++)
            {
                Console.WriteLine(Sayılar[i]);
            }

            string Kelime = "Ayşe";
            Console.WriteLine("Boş -"+Kelime);
            //Kelime = "";
            Kelime = string.Empty; // String Değişkenin İçini Boşaltmak İçin Kullanılır.
            Console.WriteLine("Boş -"+Kelime);
            Console.ReadKey();

        }
    }
}
