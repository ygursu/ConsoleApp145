using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = “Adetler Ve Toplamlar”;
            int sayi = 1;
            int cift_toplam = 0, cift_adet = 0;
            int tek_toplam = 0, tek_adet = 0;
            while (sayi != 0)
            {
                Console.Write(“Bir Sayı Giriniz: “);
                sayi = Int32.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    cift_adet++;
                    cift_toplam = cift_toplam + sayi;
                }
                else
                {
                    tek_adet++;
                    tek_toplam = tek_toplam + sayi;
                }
            }
            Console.WriteLine(“{ 0}
            adet tek sayının toplamı { 1}”, tek_adet, tek_toplam);
            Console.WriteLine(“{ 0}
            adet çift sayının toplamı { 1}”, cift_adet, cift_toplam);
            Console.ReadKey();
        }
    }
}