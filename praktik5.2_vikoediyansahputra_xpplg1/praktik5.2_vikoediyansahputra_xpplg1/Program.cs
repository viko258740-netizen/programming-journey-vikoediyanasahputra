using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace praktik5._2_vikoediyansahputra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk menyimpan hasil penjumlahan int total = 0;
            int total = 0;

            Console.WriteLine("Menghitung jumlah angka dari 1 sampai 5:");

            // Perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
                // Tambahkan nilai i saat ini ke variabel total
                total = total + i; // Bisa juga ditulis sebagai: total += i;

                // Tampilkan proses penjumlahan disetiap langkah
                Console.WriteLine("Menambahkan " + i + ", total sementara = " + total);
                {

                    // Tampilkan hasil akhir setelah perulangan selesai
                    Console.WriteLine("\nHasil akhir penjumlahan adalah: " + total);
                }
            }
        }
    }
}
