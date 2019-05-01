using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krywan1 = new Karyawan();
            krywan1.Nik = "190302124";
            krywan1.Nama = "Paijo";
            krywan1.GajiBulanan = 3000000;

            Karyawan krywan2 = new Karyawan();
            krywan2.Nik = "190302125";
            krywan2.Nama = "Jono";
            krywan2.GajiBulanan = 2000000;

            Console.WriteLine("No. \tNik/Nama\tGaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", krywan1.Nik, krywan1.Nama, krywan1.GajiBulanan);
            Console.WriteLine("2.\t{0} {1}\t\t{2}", krywan2.Nik, krywan2.Nama, krywan2.GajiBulanan);
            krywan1.GajiBulanan += krywan1.GajiBulanan * 0.1;
            krywan2.GajiBulanan += krywan2.GajiBulanan * 0.1;

            Console.WriteLine("\n\n");
            Console.WriteLine(" yee kenaikan gaji 10%");
            Console.WriteLine("\n");
            Console.WriteLine("No. \tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", krywan1.Nik, krywan1.Nama, krywan1.GajiBulanan);
            Console.WriteLine("2.\t{0} {1}\t\t{2}", krywan2.Nik, krywan2.Nama, krywan2.GajiBulanan);

            Console.ReadKey();

        }
    }
}
