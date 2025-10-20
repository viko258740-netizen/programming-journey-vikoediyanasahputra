using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik5._8_vikoediyansahputra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string up;

            do
            {
                // --- Blok proses yang akan diulang ---
                Console.WriteLine("-----------------------");
                Console.Write("Masukkan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai. ");
                // --------------------------------------
                // Pertanyaan untuk mengulang
                Console.WriteLine("Apakah anda ingin mengulangi lagi? (YA/TIDAK): ");
                up = Console.ReadLine().ToUpper(); // Mengambil input dan mengubah ke huruf kecil

                Console.WriteLine(); // Baris kosong untuk kerapian

                // Kondisi diperiksa di akhir: ulangi selama pengguna mengetik "YA"
            } while (up == "YA");
            {
                Console.WriteLine("Thank you. Program selesai. ");
            }
        }
    }
}
