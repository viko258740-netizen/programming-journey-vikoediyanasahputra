using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Program mendata lansia===");
            Console.Write("Masukkan umur anda: ");
            int umur = int.Parse(Console.ReadLine());

            if ( umur >= 60)
            {
                Console.WriteLine("Anda adalah lansia");
            }
            else
            {
                Console.WriteLine("Anda bukan lansia");
            }
        }
    }
}
