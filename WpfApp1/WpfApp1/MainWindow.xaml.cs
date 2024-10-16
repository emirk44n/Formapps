using System;
using System.Collections.Generic;

class Program
{
    private static void Main(string[] args)
    {
        SpiralMatris.RunSpiralMatris();
        MatrisCarpimi.RunMatrisCarpimi();
        AsalSayilarToplami.RunAsalSayilarToplami();
        }
}

// 1. Spiral Matris
class SpiralMatris
{
    public static void RunSpiralMatris() 
    {
        Console.Write("Boyut girin: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matris = new int[N, N];
        int sol = 0, sağ = N - 1, üst = 0, alt = N - 1;
        int sayı = 1;

        while (sayı <= N * N)
        {
            for (int i = sol; i <= sağ; i++) matris[üst, i] = sayı++;
            üst++;

            for (int i = üst; i <= alt; i++) matris[i, sağ] = sayı++;
            sağ--;

            for (int i = sağ; i >= sol; i--) matris[alt, i] = sayı++;
            alt--;

            for (int i = alt; i >= üst; i--) matris[i, sol] = sayı++;
            sol++;
        }

         for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(matris[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }
    }
}

// 2. Matris Çarpımı
class MatrisCarpimi
{
    public static void RunMatrisCarpimi() 
    {
        Console.Write("Lütfen matrislerin boyutunu giriniz (N): ");
        int N = int.Parse(Console.ReadLine());

        int[,] matris1 = new int[N, N];
        int[,] matris2 = new int[N, N];
        int[,] sonucMatrisi = new int[N, N];

        Console.WriteLine("Birinci matrisin elemanlarını giriniz:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Matris1[{i + 1},{j + 1}]: ");
                matris1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("İkinci matrisin elemanlarını giriniz:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Matris2[{i + 1},{j + 1}]: ");
                matris2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                int toplam = 0;
                for (int k = 0; k < N; k++)
                    toplam += matris1[i, k] * matris2[k, j];
                sonucMatrisi[i, j] = toplam;
            }
        }

        Console.WriteLine("Matrislerin çarpım sonucu:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(sonucMatrisi[i, j].ToString().PadLeft(6));
            Console.WriteLine();
        }
    }
}

// 3. Asal Sayıların Toplamı
class AsalSayilarToplami
{
    public static void RunAsalSayilarToplami()
    {
        Console.Write("N sayısını giriniz: ");
        int N = int.Parse(Console.ReadLine());

        int toplam = 0;
        for (int sayi = 2; sayi <= N; sayi++)
        {
            if (AsalMi(sayi)) toplam += sayi;
        }

        Console.WriteLine($"0'dan {N}'ye kadar olan asal sayıların toplamı: {toplam}");
    }

    static bool AsalMi(int sayi)
    {
        if (sayi < 2) return false;
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0) return false;
        }
        return true;
    }
}

