using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._2_vikoediyansahputra_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angka = new int[5];

            Console.Write("Masukan nillai ke-1: ");
            angka[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai ke-2: ");
            angka[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai ke-3: ");
            angka[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai ke-4:  ");
            angka[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai ke-5: ");
            angka[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDATA YANG ANDA MASUKAN");
            Console.WriteLine("nilai ke-1 : " + angka[0]);
            Console.WriteLine("nilai ke-2 : " + angka[1]);
            Console.WriteLine("nilai ke-3 : " + angka[2]);
            Console.WriteLine("nilai ke-4 : " + angka[3]);
            Console.WriteLine("nilai ke-5 : " + angka[4]);
        }
    }
}
