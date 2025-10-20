
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspercabangan1_vikoediyansahputra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            double sisi, panjang, lebar, tinggi, hasil;

            Console.WriteLine("=== PROGRAM MENGHITUNG LUAS & VOLUME ===");
            Console.WriteLine("1. Luas Permukaan Kubus");
            Console.WriteLine("2. Volume Kubus");
            Console.WriteLine("3. Luas Permukaan Balok");
            Console.WriteLine("4. Volume Balok");
            Console.WriteLine("========================================");
            Console.Write("Masukkan pilihan (1-4): ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("\n=== Luas Permukaan Kubus ===");
                    Console.Write("Masukkan sisi kubus: ");
                    sisi = Convert.ToDouble(Console.ReadLine());
                    hasil = 6 * sisi * sisi;
                    Console.WriteLine($"Luas Permukaan Kubus = 6 × {sisi} × {sisi} = {hasil}");break;

                case 2:
                    Console.WriteLine("\n=== Volume Kubus ===");
                    Console.Write("Masukkan sisi kubus: ");
                    sisi = Convert.ToDouble(Console.ReadLine());
                    hasil = sisi * sisi * sisi;
                    Console.WriteLine($"Volume Kubus = {sisi} × {sisi} × {sisi} = {hasil}");break;

                case 3:
                    Console.WriteLine("\n=== Luas Permukaan Balok ===");
                    Console.Write("Masukkan panjang balok: ");
                    panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar balok: ");
                    lebar = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi balok: ");
                    tinggi = Convert.ToDouble(Console.ReadLine());
                    hasil = 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi));
                    Console.WriteLine($"Luas Permukaan Balok = 2 × (({panjang}×{lebar}) + ({panjang}×{tinggi}) + ({lebar}×{tinggi})) = {hasil}");break;

                case 4:
                    Console.WriteLine("\n=== Volume Balok ===");
                    Console.Write("Masukkan panjang balok: ");
                    panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar balok: ");
                    lebar = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi balok: ");
                    tinggi = Convert.ToDouble(Console.ReadLine());
                    hasil = panjang * lebar * tinggi;
                    Console.WriteLine($"Volume Balok = {panjang} × {lebar} × {tinggi} = {hasil}");break;

                default:
                    Console.WriteLine("Pilihan tidak valid!");break;
            }
        }
    }
}
