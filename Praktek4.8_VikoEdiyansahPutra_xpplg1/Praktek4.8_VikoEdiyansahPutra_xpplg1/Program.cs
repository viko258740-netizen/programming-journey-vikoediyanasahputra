using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek4._8_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angkamu: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("Angkamu positive ");
            }
            else if (angka < 0)
            {
                Console.WriteLine("Angkamu negative ");
            }
            else
            {
                Console.WriteLine("Angkamu nol ");
            }
        }
    }
}
