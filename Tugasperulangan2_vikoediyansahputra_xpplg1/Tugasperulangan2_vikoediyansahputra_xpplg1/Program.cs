using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugasperulangan2_vikoediyansahputra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int i = 1;
            Console.WriteLine("jumlah total dari bilangan 1 sampai 5");
            while (i <= 5)
            {
                total += i;
                i++;
            }
            Console.WriteLine("/nHasil akhir penjumlahan adalah: " + total);
        }
    }
}
