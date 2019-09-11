using System;

namespace quiz_09092019
{
    class BangunRuang
    {
        public static void volumeBalok()
        {
            Console.WriteLine("Menghitung Volume Balok");

            Console.WriteLine("=============================");

            //Variable
            int panjang, lebar, tinggi, volume;

            //Input
            Console.Write("Panjang = ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lebar = ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            
            volume = panjang * lebar * tinggi ;

            //Output
            Console.WriteLine("Volume Balok adalah "+volume);
        }

        //Volume Kubus
        public static void volumeKubus()
        {
            Console.WriteLine("Menghitung Volume Kubus"); //Text

            Console.WriteLine("=============================");

         
            int sisi, volume;

            //Input
            Console.Write("Sisi = "); 
            sisi = Convert.ToInt32(Console.ReadLine());

            //Processing
            volume = sisi * sisi * sisi ;

            //Output
            Console.WriteLine("Volume Kubus adalah "+volume);
        }
    }
}
