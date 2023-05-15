using System;

class Program
{
    static int BinarySearch(int[] dizi, int ArananDeger)
    {
        int BaslangicDegeri = 0;
        int BitisDegeri = dizi.Length - 1;

        while (BaslangicDegeri <= BitisDegeri)
        {
            int OrtadakiDeger = (BaslangicDegeri + BitisDegeri) / 2;

            if (dizi[OrtadakiDeger] == ArananDeger)
                return OrtadakiDeger;

            if (dizi[OrtadakiDeger] < ArananDeger)
                BaslangicDegeri = OrtadakiDeger + 1;
            else
                BitisDegeri = OrtadakiDeger - 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] dizi = { 4, 8, 3, 84, 47, 76, 9, 24, 68 };
        int aranan = 76;

        int sonuc = BinarySearch(dizi, aranan);

        if (sonuc == -1)
            Console.WriteLine("Aranan eleman bulunamadı.");
        else
            Console.WriteLine("Aranan eleman dizinin {0}. indeksinde bulundu.", sonuc);

        Console.ReadLine();
    }
}