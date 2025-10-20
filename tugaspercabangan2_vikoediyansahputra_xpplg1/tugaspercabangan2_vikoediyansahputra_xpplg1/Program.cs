using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspercabangan2_vikoediyansahputra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double berat, tinggi, imt;

            Console.WriteLine("=== PROGRAM MENGHITUNG INDEKS MASSA TUBUH (IMT) ===");
            Console.Write("Masukkan berat badan (kg): ");
            berat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi badan (meter): ");
            tinggi = Convert.ToDouble(Console.ReadLine());

            // Rumus IMT
            imt = berat / (tinggi * tinggi);

            Console.WriteLine($"\nIndeks Massa Tubuh (IMT) Anda = {imt:F2}");

            // Menentukan kategori dengan percabangan if-else
            if (imt < 18.5)
            {
                Console.WriteLine("Kategori: Berat badan KURUS");
            }
            else if (imt >= 18.5 && imt >= 24.9)
            {
                Console.WriteLine("Kategori: Berat badan NORMAL");
            }
            else if (imt >= 25 && imt <= 29.9)
            {
                Console.WriteLine("Kategori: KELEBIHAN berat badan");
            }
            else
            {
                Console.WriteLine("Kategori: OBESITAS");
            }
        }
    }
}
