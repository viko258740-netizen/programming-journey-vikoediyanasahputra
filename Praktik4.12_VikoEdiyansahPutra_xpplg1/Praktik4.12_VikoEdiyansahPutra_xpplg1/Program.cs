using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._12_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Menu makanan===");
            Console.WriteLine("1. Sate kelinci");
            Console.WriteLine("2. Nasi Goreng");
            Console.WriteLine("3. Ayam goreng");
            Console.WriteLine("Pilih menu (1-3): ");
            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:Console.WriteLine("Anda memilih sate kelinci. Harga Rp.10.000");break;
                case 2:Console.WriteLine("Anda memilih nasi goreng. Harga Rp.12.000");break;
                case 3:Console.WriteLine("Anda memilih ayam goreng. Harga Rp.25.000");break;
                default: Console.WriteLine("Menu tidak tersedia");break;
            }
        }
    }
}
