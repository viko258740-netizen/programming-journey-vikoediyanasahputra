using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._9_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan usia: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur < 5)
            {
                Console.WriteLine("Free tiket ");
            }
            else if (umur < 12)
            {
                Console.WriteLine("Harga tiket Rp10.000 ");
            }
            else if (umur < 60)
            {
                Console.WriteLine("Harga Rp.30.000 ");
            }
            else
            {
                Console.WriteLine("Harga Rp.20.000 ");
            }
        }
    }
}
