using System;

class Calculator 
{ 
    static void Main(string[] args) 
    { 
        int a = 10;   
        int b = 6;

        // Corrected the string interpolation and added the missing $ sign
        Console.WriteLine($"Hasil Penambahan: {a} + {b} = {Penambahan(a, b)}"); 
        Console.WriteLine($"Hasil Pengurangan: {a} - {b} = {Pengurangan(a, b)}"); 

        Console.WriteLine("\nTekan sembarang key untuk keluar"); 
        Console.ReadKey(); 
    } 

    static int Penambahan(int a, int b) 
    { 
        return a + b; // Tugas 2: Menambahkan fungsi Penambahan 
    } 

    static int Pengurangan(int a, int b) 
    { 
        return a - b; // Tugas 3: Menambahkan fungsi Pengurangan 
    } 
}