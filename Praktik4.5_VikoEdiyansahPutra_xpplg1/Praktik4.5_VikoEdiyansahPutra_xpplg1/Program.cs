using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._5_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur anda: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 18)
            {
                Console.WriteLine("Anda sudah boleh mengendarai motor");
            }
            else
            {
                Console.WriteLine("Anda belum boleh mengendarai motor");
            }
        }
    }
}
