using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoh1_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Program untuk mengetahui karakter yang diinginkan
            ///Apakah huruf besar,huruf kecil,spasi,digit,atau yang lainnya
            Console.Write("Masukkan Karakter: ");
            char karakter = Console.ReadKey().KeyChar;// Membaca 1 karakter
            Console.WriteLine();//Pindah baris

            if (char.IsUpper(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalah huruf besar ");
            }
            else if (char.IsLower(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalah huruf kecil ");
            }
            else if (char.IsWhiteSpace(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalah spasi ");
            }
            else
            {
                Console.WriteLine("Karakter yang diinputkan adalah karakteer lainnya (simbol).");
            }
        }
    }
}
