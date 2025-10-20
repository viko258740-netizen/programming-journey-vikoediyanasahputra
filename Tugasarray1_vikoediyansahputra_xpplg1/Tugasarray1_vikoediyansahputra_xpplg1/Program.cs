using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugasarray1_vikoediyansahputra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[3];
            char[] jk = new char[3];
            string[] kelas = new string[3];

            Console.Write("Masukkan nama ke-1: ");
            nama[0] = Console.ReadLine();
            Console.Write("Masukan jenis kelamin: ");
            jk[0] = char.Parse(Console.ReadLine());
            Console.Write("Masukan kelas: ");
            kelas[0] = Console.ReadLine();


            Console.Write("Masukan nama ke-2: ");
            nama[1] = Console.ReadLine();
            Console.Write("Masukan jenis kelamin: ");
            jk[1] = char.Parse(Console.ReadLine());
            Console.Write("Masukan kelas: ");
            kelas[1] = Console.ReadLine();

            Console.Write("Masukan nama ke-3: ");
            nama[2] = Console.ReadLine();
            Console.Write("Masukan jenis kelamin: ");
            jk[2] = char.Parse(Console.ReadLine());
            Console.Write("Masukan kelas: ");
            kelas[2] = Console.ReadLine();

            Console.WriteLine("\n===== DATA SISWA =====");
            Console.WriteLine("Nama: " + nama[0] + " | " + jk[0] + " | " + kelas[0]);
            Console.WriteLine("Nama: " + nama[1] + " | " + jk[1] + " | " + kelas[1]);
            Console.WriteLine("Nama: " + nama[2] + " | " + jk[1] + " | " + kelas[1]);
        }
    }
}
