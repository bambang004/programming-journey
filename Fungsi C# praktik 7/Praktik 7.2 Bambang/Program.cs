using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_7._2_Bambang
{
    internal class Program
    {
        static void SapaNama(string nama)
        {
            Console.WriteLine("hallo, " + nama + " !  ");
            Console.WriteLine("Semangat belajar C# hari ini !");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("masukan nama anda : ");
            string namasiswa = Console.ReadLine();
            SapaNama(namasiswa);
        }
    }
}
