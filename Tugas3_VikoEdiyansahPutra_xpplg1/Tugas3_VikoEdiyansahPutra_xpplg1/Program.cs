using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Program input warna===");
            Console.Write("Masukkan angka (1-5): ");
            int warna = int.Parse(Console.ReadLine());

            switch (warna)
            {
                case 1: Console.WriteLine("Warna merah");break;
                case 2: Console.WriteLine("Warna biru");break;
                case 3: Console.WriteLine("Warna hijau");break;
                case 4: Console.WriteLine("Warna kuning");break;
                case 5: Console.WriteLine("Warna hitam");break;
                default: Console.WriteLine("Warna tidak valid");break;
            }
        }
    }
}
