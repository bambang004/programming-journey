using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS_PRAKTIK_7._3_BAMBANG
{
    internal class Program
    {
        static double KonversiSuhu(double celcius)
        {
            double farrenheit = (celcius * 9 / 5) + 32;
            return farrenheit;
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("masukan suhu dalam celcius: ");
            double c = double.Parse(Console.ReadLine());
            double f =(c);
            Console.WriteLine($"{c} °C sama dengan {f}°F");
            

        }
    }
}
