/*
 *  C# Program to Convert Digits to Words
 *  The source code taken from http://www.sanfoundry.com/csharp-program-digits-words/, and modified by me
 */
using System;

public class UbahAngkakeKata
{
    public static void Main()
    {
        int num;
        int nextdigit;
        int numdigits;
        int[] n = new int[20];

        string[] digits = { "nol", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan" };


        Console.WriteLine("Ketikkan angka");
        Console.WriteLine();
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Angka yang Anda masukkan: " + num);
        Console.Write("Dalam kata: ");
        nextdigit = 0;
        numdigits = 0;
        do
        {
            nextdigit = num % 10;
            n[numdigits] = nextdigit;
            numdigits++;
            num = num / 10;
        } while (num > 0);
        numdigits--;
        for (; numdigits >= 0; numdigits--)
            Console.Write(digits[n[numdigits]] + " ");
        Console.WriteLine();
        Console.ReadLine();
    }
}