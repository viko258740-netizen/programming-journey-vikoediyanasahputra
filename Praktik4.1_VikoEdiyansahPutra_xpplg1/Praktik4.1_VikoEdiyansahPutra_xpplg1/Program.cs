using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._1_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0) 
            {
                Console.WriteLine("Angka positive ");
            }
        }
    }
}
