using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            Console.WriteLine("Masukkan pilihan anda \n1. Penambahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian");

            Console.Write("Masukkan pilihan anda : ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (c)
            {
                case 1:
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;
                case 5:
                    Console.WriteLine("Pilihan anda tidak ada.");
                    break;
            }
           
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
