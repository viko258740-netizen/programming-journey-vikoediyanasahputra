using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik6._1_vikoediyansahputra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] siswa = new string[5];

            siswa[0] = "nina";
            siswa[1] = "viko";
            siswa[2] = "citra";
            siswa[3] = "leo";
            siswa[4] = "akbar";

            Console.WriteLine("DAFTAR NAMA SISWA :");
            Console.WriteLine("siswa ke-1 : " + siswa[0]);
            Console.WriteLine("siswa ke-2 : " + siswa[1]);
            Console.WriteLine("siswa ke-3 : " + siswa[2]);
            Console.WriteLine("siswa ke-4 : " + siswa[3]);
            Console.WriteLine("siswa ke-5 : " + siswa[4]);
        }
    }
}
