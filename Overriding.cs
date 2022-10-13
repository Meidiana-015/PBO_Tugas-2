using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu first = new Menu();
            first.menu();
            Console.ReadLine();
        }
    }
    class Menu
    {
        public void menu()
        {
            Console.WriteLine("PROGRAM MENCARI LUAS DAN KELILING BANGUN DATAR");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Lingkaran");
            Console.WriteLine("3. Persegi Panjang");
            Console.WriteLine("4. Segitiga");

            Console.WriteLine();

            Persegi a = new Persegi();

            Console.WriteLine("1. Mencari Luas dan Keliling Persegi");
            Console.WriteLine("-------------------------");
            Console.Write("Sisi : ");
            a.sisi = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas = {0} cm", a.cariLuas());
            Console.WriteLine("Keliling = {0} cm", a.cariKeliling());
            Console.WriteLine();

            Lingkaran d = new Lingkaran();

            Console.WriteLine("2. Mencari Luas dan Keliling Lingkaran");
            Console.WriteLine("-------------------------");
            Console.Write("Jari-Jari : ");
            d.jarijari = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas       = {0} cm", d.cariLuas());
            Console.WriteLine("Keliling   = {0} cm", d.cariKeliling());
            Console.WriteLine();

            PersegiPanjang b = new PersegiPanjang();

            Console.WriteLine("3. Mencari Luas dan Keliling Persegi Panjang");
            Console.WriteLine("---------------------------");
            Console.Write("Panjang : ");
            b.panjang = (int.Parse(Console.ReadLine()));
            Console.Write("Lebar   : ");
            b.lebar = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas    = {0} cm", b.cariLuas());
            Console.WriteLine("Keliling   = {0} cm", b.cariKeliling());
            Console.WriteLine();

            Segitiga c = new Segitiga();

            Console.WriteLine("4. Mencari Keliling Segitiga");
            Console.WriteLine("------------------------");
            Console.Write("Alas   : ");
            c.alas = (int.Parse(Console.ReadLine()));
            Console.Write("Tinggi : ");
            c.tinggi = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas   = {0} cm", c.luas_segitiga());
        }
    }

    public abstract class BangunDatar
    {
        public double _cari;

        public double Cari
        {
            get { return _cari; }
            set { _cari = value; }
        }

        public abstract double cariLuas();

        public abstract double cariKeliling();
    }

    class Persegi : BangunDatar
    {
        private double s;

        public double sisi
        {
            get { return s; }
            set { s = value; }
        }

        public override double cariLuas()
        {
            _cari = s * s;
            return _cari;
        }

        public override double cariKeliling()
        {
            _cari = s * 4;
            return _cari;
        }

    }

    class Lingkaran : BangunDatar
    {
        private double r, luas;

        public double jarijari
        {
            get { return r; }
            set
            {
                r = value;
            }
        }

        public override double cariLuas()
        {
            luas = 3.14 * r * r;
            return luas;
        }
        public override double cariKeliling()
        {
            float k = (float)(2 * Math.PI * r);
            return k;
        }
    }

    class PersegiPanjang : BangunDatar
    {
        private float p, l, luas;

        public float panjang
        {
            get { return p; }
            set
            {
                p = value;
            }
        }

        public float lebar
        {
            get { return l; }
            set
            {
                l = value;
            }
        }

        public override double cariLuas()
        {
            luas = p * l;
            return luas;
        }
        public override double cariKeliling()
        {
            float k = 2 * panjang + 2 * lebar;
            return k;
        }
    }

    class Segitiga
    {
        private float a, t, luas;

        public float alas
        {
            get { return a; }
            set
            {
                a = value;
            }
        }

        public float tinggi
        {
            get { return t; }
            set
            {
                t = value;
            }
        }

        public float luas_segitiga()
        {
            luas = (a * t) / 2;
            return luas;
        }
    }
}
