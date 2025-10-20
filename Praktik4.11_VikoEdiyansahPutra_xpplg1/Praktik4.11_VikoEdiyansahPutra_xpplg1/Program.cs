using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._11_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka bulan: ");
            int bulan = int.Parse(Console.ReadLine());

            switch (bulan)
            {
                case 1: Console.WriteLine("Januari"); break;
                case 2: Console.WriteLine("Februari"); break;
                case 3: Console.WriteLine("Maret"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("Mei"); break;
                case 6: Console.WriteLine("Juni"); break;
                case 7: Console.WriteLine("Juli"); break;
                case 8: Console.WriteLine("Agustus"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("Oktober"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("Desember"); break;
                default: Console.WriteLine("Input tidak valid!"); break;
            }
        }
    }
}
