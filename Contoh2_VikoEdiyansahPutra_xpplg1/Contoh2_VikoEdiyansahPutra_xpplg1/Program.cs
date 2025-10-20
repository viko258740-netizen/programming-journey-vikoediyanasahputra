using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoh2_VikoEdiyansahPutra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program untuk mempermudah pembayaran di suatu bioskop

            Console.WriteLine("=== PROGRAM PEMBAYARAN BIOSKOP ===");
            Console.WriteLine("Pilih Jenis");       
            Console.WriteLine("1. Horor");
            Console.WriteLine("2. Romantic");
            Console.Write("Masukkan pilihan (1/2): ");
            int jenis = int.Parse(Console.ReadLine());
            int harga = 0;
            string judul = "";

            //Pilihan untuk film Horor
            if (jenis == 1)
            {
                Console.WriteLine("\n---Daftar film Horor---");
                Console.WriteLine("1. Pengabdi setan\tRp.30.000");
                Console.WriteLine("2. KKN Desa Penari\tRp.35.000");
                Console.WriteLine("3. Pabrik gula \tRp.25.000");
                Console.Write("Pilih nomor film: ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "Pengabdi setan";
                    harga = 30000;
                }
                else if (pilih == 2)
                {
                    judul = "KKN Desa penari ";
                    harga = 35000;
                }
                else if (pilih == 3)
                {
                    judul = "Pabrik gula";
                    harga = 25000;
                }
            }
        }
    }
}
