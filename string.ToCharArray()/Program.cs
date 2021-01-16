using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string.ToCharArray__
{
    class Program
    {
        static void Main(string[] args)
        {
            String kelime = "Kodlamayı Öğreniyoruz";
            char[] chars = kelime.ToCharArray(0, 3);

            Console.Write("Girlen kelimenin ilk üç harfini ve onların indeksini verir");
            Console.WriteLine("\nKelime: " + kelime);

            for (int i = 0; i < chars.Length; i++)
                Console.WriteLine("Indeks numarası " + (i+1) + " : " + chars[i]);

            Console.ReadLine();
        }
    }
}
