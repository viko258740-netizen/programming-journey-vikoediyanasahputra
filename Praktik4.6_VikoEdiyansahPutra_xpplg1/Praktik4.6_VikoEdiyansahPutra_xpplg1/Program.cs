using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._6_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilaimu: ");
            double nilai = double.Parse(Console.ReadLine());

            if (nilai >= 75) 
            {
                Console.WriteLine("Selamat anda dinyatakan lulus");
            }
            else
            {
                Console.WriteLine("Maaf anda tidak lulus");
            }
        }
    }
}
