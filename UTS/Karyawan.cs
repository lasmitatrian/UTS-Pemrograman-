﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Karyawan
    {
        public Karyawan()
        {
        }
        public Karyawan(string nik, string nama, int gajibulanan)
        {
            if (gajibulanan < 0)
            {
                Console.WriteLine("gaji harus diatas 0!");
            }
            else
            {
                Nik = nik;
                Nama = nama;
                GajiBulanan = gajibulanan;


            }
        }

        public string Nik { get; set; }
        public string Nama { get; set; }
        public double GajiBulanan { get; set; }
    }

}
