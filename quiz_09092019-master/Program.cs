using System;

namespace quiz_09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable

            about info1 = new about(); 

            Console.WriteLine("Aplikasi "+info1.info()); 
            Console.WriteLine("Dibuat oleh "+info1.nama());
            Console.WriteLine("Dari "+info1.sekolah());

            Console.WriteLine("=============================");

            BangunDatar.luasPersegi();  

            Console.WriteLine("============================="); //pembatas

            BangunDatar.luasSegitiga();  //Luas Segitiga

            Console.WriteLine("============================="); //pembatas

            BangunDatar.luasLingkaran();  //Luas Lingkaran

            //Bangun Ruang

            Console.WriteLine("============================="); //pembatas

            BangunRuang.volumeBalok(); //Volume Balok

            Console.WriteLine("============================="); //pembatas

            BangunRuang.volumeKubus();  //Volume Kubus
        }
    }
}
