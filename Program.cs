﻿using System;

namespace Foreach_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1 den başlayarak girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // a dan z ye kadar tüm harfleri console a yazsın.
            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            // Foreach
            Console.WriteLine("**** Foreach ****");

            string[] arabalar = { "BMW", "Ford", "Nissan", "Toyota" };

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }




        }
    }
}
