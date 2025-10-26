using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_7._3_bambang
{
    internal class Program
    {
        static int Tambah(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("masukan angka pertama: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukan angka kedua :");
            int y = Convert.ToInt32(Console.ReadLine());

            int hasil = Tambah (x, y);
            Console.WriteLine("hasil penjumlahaan "+ hasil );
        }
    }
}
