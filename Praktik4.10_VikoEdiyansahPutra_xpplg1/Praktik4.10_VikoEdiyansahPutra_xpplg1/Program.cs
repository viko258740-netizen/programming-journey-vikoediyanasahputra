using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._10_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angka (1-7)");
            int hari = int.Parse(Console.ReadLine());

            switch (hari)
            {
                case 1: Console.WriteLine("Senin"); break;
                case 2: Console.WriteLine("Selasa"); break;
                case 3: Console.WriteLine("Rabu"); break;
                case 4: Console.WriteLine("Kamis"); break;
                case 5: Console.WriteLine("Jumat"); break;
                case 6: Console.WriteLine("Sabtu"); break;
                case 7: Console.WriteLine("Minggu"); break;
                default: Console.WriteLine("Input tidak valid!");
            }

        }
    }
}
