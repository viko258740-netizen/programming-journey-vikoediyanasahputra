using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas4_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Program input jam===");
            Console.Write("Masukkan angka jam: ");
            int jam = int.Parse(Console.ReadLine());

            if (jam >= 6 && jam <= 11)
            {
                Console.WriteLine("Selamat pagi");
            }
            else if (jam >= 12 && jam <= 15)
            {
                Console.WriteLine("Selamat siang");
            }
            else if (jam >= 16 && jam <= 18)
            {
                Console.WriteLine("Selamat sore");
            }
            else 
            {
                Console.WriteLine("Selamat malam");            
            }
        }
    }
}
