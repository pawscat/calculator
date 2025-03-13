using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            // int a = 10;
            // int b = 6;

            Console.Write("Inputkan Nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Tambah (a,b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a,b, Kurang (a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Kali (a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Bagi (a, b));

            Console.WriteLine("\nTekan Sembarang untuk keluar");
            Console.ReadKey();
        }
        static int Tambah (int a, int b)
        {
            return a + b; 
        }
        static int Kurang (int a, int b)
        {
            return a - b;
        }
        static int Kali (int a, int b)
        {
            return a * b;
        }
        static int Bagi (int a, int b)
        // static float Bagi(int a, int b)
        // static double Bagi(int a, int b)
        {
            return a / b;
            // return a / b(float);
        }
    }
}
