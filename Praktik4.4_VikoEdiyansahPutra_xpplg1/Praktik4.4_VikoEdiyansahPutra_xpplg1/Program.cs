using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._4_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angkamu: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka >= 0) 
            {
                Console.WriteLine("Angkamu benar ");
            }
            else 
            {
                Console.WriteLine("Angkamu salah ");
            }
        }
    }
}
