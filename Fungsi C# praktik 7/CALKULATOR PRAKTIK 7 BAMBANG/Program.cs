using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    
    
        
        
            

namespace CALKULATOR_PRAKTIK_7_BAMBANG
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string hitungLagi;
                do
                {
                    Console.Clear();
                    Console.WriteLine("--- KALKULATOR SEDERHANA ---");
                    TampilkanMenu();

                    Console.Write("\nMasukkan pilihan operasi (1-4): ");
                    string pilihan = Console.ReadLine();

                    double angka1, angka2, hasil = 0;

                    // Panggil fungsi untuk ambil input angka
                    if (AmbilInputAngka(out angka1, out angka2))
                    {
                        switch (pilihan)
                        {
                            case "1":
                                hasil =  (angka1 + angka2);
                                Console.WriteLine($"\nHasil: {angka1}+ {angka2}+ {hasil}");
                                break;
                            case "2":
                                hasil = (angka1 - angka2);
                                Console.WriteLine($"\nHasil : {angka1}- {angka2}= {hasil}");
                                break;
                            case "3":
                                hasil = (angka1 * angka2);
                                Console.WriteLine($"\nHasil : {angka1}* {angka2}* {hasil} ");
                                break;
                            case "4":// pembagian 
                                if (angka2 == 0)
                                {
                                    
                                    Console.WriteLine($"\nError: Tidak dapat melakukan pembagian dengan nol. : ");
                                }
                                else
                                {
                                hasil = (angka1- angka2);
                                    Console.WriteLine($"\n Hasil : {angka1} / {angka2} = {hasil} ");
                                }
                                break;
                            default:
                                Console.WriteLine("\n pilian yang anda masukan tidak valid .");
                                break;
                        }
                    }

                    Console.Write("\nApakah ingin menghitung lagi? (y/n): ");
                    hitungLagi = Console.ReadLine().ToLower();

                } while (hitungLagi.ToLower() == "y");

                Console.WriteLine("Terima kasih telah menggunakan kalkulator ini. " + " Tekan tombol apa saja untuk keluar .");
            }

            // ===== Fungsi Menampilkan Menu =====
            static void TampilkanMenu()
            {
                Console.WriteLine("Pilih operasi:");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
            }

            // ===== Fungsi Ambil Input Angka =====
            static bool AmbilInputAngka(out double angka1, out double angka2)
            {
                Console.Write("Masukkan angka pertama: ");
                if (!double.TryParse(Console.ReadLine(), out angka1))
                {
                    Console.WriteLine("Input tidak valid!");
                    angka2 = 0;
                    return false;
                }

                Console.Write("Masukkan angka kedua: ");
                if (!double.TryParse(Console.ReadLine(), out angka2))
                {
                    Console.WriteLine("Input tidak valid!");
                    return false;
                }

                return true;
              
            }
            static double Tambah(double a,  double b)
        {
            return a * b;
        }

           static double kurang(double a, double b)
        {
            return a * b;
        }
           static double kali (double a, double b)
        {
            return a * b;
        }
          static double Bagi(double a, double b)
        {
            return a * b;
        }
    }

}
    

