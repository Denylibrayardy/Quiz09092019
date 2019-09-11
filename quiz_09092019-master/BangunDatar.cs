using System;

namespace quiz_09092019
{
    class BangunDatar
    {
    
        public static void luasPersegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");

            Console.WriteLine("=============================");
            
        
            int sisi, luas;

            
            Console.Write("Sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

            
            luas = sisi * sisi;
            //output
            Console.WriteLine("Luas Persegi adalah "+luas);
        }

        public static void luasSegitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");

            Console.WriteLine("=============================");

            //variable
            int alas, tinggi;
            double luas, half;
            half=0.5;

            //input
            Console.Write("Alas = ");

            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi = ");

            tinggi = Convert.ToInt32(Console.ReadLine());
            
            //proses
            luas = half * alas * tinggi;

            //output
            Console.WriteLine("Luas Segitiga adalah "+luas);
        }

        
        public static void luasLingkaran()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");

            Console.WriteLine("=============================");

            //variabel
            int jari;
            double luas; 
            double phi;
            phi=3.14;

            //input
            Console.Write("Jari-jari = ");
            jari = Convert.ToInt32(Console.ReadLine());

            //proses
            luas = phi * jari * jari;

            //output
            Console.WriteLine("Luas Lingkaran adalah "+luas);
        }
    }
}
