using System;
namespace BangunDatar
{
    public class PersegiPanjang
    {
        /// <summary>
        /// Panjang dan lebar adalah untuk mendeklarasikan variable
        /// </summary>
        public double panjang, lebar;
        /// <summary>
        /// Untuk memasukkan sisi persegi panjang
        /// </summary>
        public void sisiPersegiPanjang()
        {
            /// Untuk menginput panjang persegi panjang
            Console.Write("Masukkan Panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            /// Untuk menginput lebar persegi panjang
            Console.Write("Masukkan Lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Membuat rumus penghitungan luas persegi panjang yaitu dengan mengalikan p dan l
        /// </summary>
        /// <param name="p"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public double LuasPersegiPanjang(double p, double l)
        {
            ///<example>p * l</example>
            return p * l;
        }
        /// <summary>
        /// Membuat rumus penghitungan keliling persegi panjang yaitu dengan menambahkan p dan l lalu dikalikan dengan 2
        /// </summary>
        /// <param name="p"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public double KelilingPersegiPanjang(double p, double l)
        {
            ///<example> 2 * (p + l)</example>
            return 2 * (p + l);
        }
        /// <summary>
        /// Memunculkan jawaban dari luas dan keliling persegi panjang
        /// </summary>
        public void tampilPersegiPanjang()
        {
            Console.WriteLine("Luas Persegi Panjang = " + this.LuasPersegiPanjang(panjang, lebar));
            Console.ReadKey();
            Console.WriteLine("Keliling Persegi Panjang = " + this.KelilingPersegiPanjang(panjang, lebar));
            Console.ReadKey();
        }
    }
    public class Lingkaran
    {
        /// <summary>
        /// jejari adalah untuk mendeklarasikan variable
        /// </summary>
        public double jejari;
        /// <summary>
        /// Untuk memasukkan jari-jari lingkaran
        /// </summary>
        public void jariLingkaran()
        {
            /// Untuk menginput jari-jari lingkaran
            Console.Write("Masukkan jari-jari = ");
            jejari = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Membuat rumus penghitungan luas lingkaran yaitu dengan mengalikan phi dengan r kuadrat
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public double LuasLingkaran(double r)
        {
            ///<example>3.14 * r * r</example>
            return 3.14 * r * r;
        }
        /// <summary>
        /// Membuat rumus penghitungan keliling lingkaran yaitu dengan mengalikan dua dengan phi dengan r 
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public double KelilingLingaran(double r)
        {
            ///<example>2 * 3.14 * r</example>
            return 2 * 3.14 * r;
        }
        /// <summary>
        /// Memunculkan jawaban dari luas dan keliling lingkaran
        /// </summary>
        public void tampilLing()
        {
            Console.WriteLine("Luas Lingkaran = " + this.LuasLingkaran(jejari));
            Console.ReadKey();
            Console.WriteLine("Keliling Lingkaran = " + this.LuasLingkaran(jejari));
            Console.ReadKey();
        }
    }
    public class Segitiga
    {
        /// <summary>
        /// alas, tinggi, dan sisi adalah untuk mendeklarasikan variable
        /// </summary>
        public double alas, tinggi, sisi;
        /// <summary>
        /// Untuk memasukkan sisi segitiga yang terdiri dari alas dan tinggi
        /// </summary>
        public void sisiS3()
        {
            ///untuk menginput alas
            Console.Write("Masukkan Alas = ");
            alas = Convert.ToDouble(Console.ReadLine());
            ///untuk menginput tinggi
            Console.WriteLine("Masukkan Tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            ///untuk menginput sisi
            Console.WriteLine("Masukkan sisi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Membuat rumus penghitungan luas segitiga yaitu dengan mengalikan alas dengan tinggi lalu dibagi dengan 2
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public double LuasSegitiga(double a, double t)
        {
            ///<example>a * t / 2</example>
            return a * t / 2;
        }
        /// <summary>
        /// Membuat rumus penghitungan keliling segitiga yaitu dengan menambahkan ketiga sisi segitiga
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public double KelilingSegitiga(double s)
        {
            ///<example>s + s + s</example>
            return s + s + s;
        }
        /// <summary>
        /// Memunculkan jawaban dari luas dan keliling segitiga
        /// </summary>
        public void tampilS3()
        {
            Console.WriteLine("Luas Segitiga = " + this.LuasSegitiga(alas, tinggi));
            Console.ReadKey();
            Console.WriteLine("Keliling Segitiga = " + this.KelilingSegitiga(sisi));
            Console.ReadKey();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            ///membuat variable pp, lk, dan s3 untuk memanggil method
            PersegiPanjang pp = new PersegiPanjang();
            Lingkaran lk = new Lingkaran();
            Segitiga s3 = new Segitiga();
            int pilih;
            ///membuat main menu dari aplikasi
            Console.WriteLine("MENU");
            Console.WriteLine("----");
            Console.WriteLine("1. Persegi Panjang");
            Console.WriteLine("2. Lingkaran");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilihan (1/2/3/4) : ");
            ///untuk memilih apa yang ingin di hitung
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (pilih)
            {
                ///untuk menampilkan menghitung persegi panjang
                case 1:
                    pp.sisiPersegiPanjang();
                    pp.tampilPersegiPanjang();
                    break;
                ///untuk menampilkan menghitung lingkaran
                case 2:
                    lk.jariLingkaran();
                    lk.tampilLing();
                    break;
                ///untuk menampilkan menghitung segitiga
                case 3:
                    s3.sisiS3();
                    s3.tampilS3();
                    break;
                ///untuk keluar dan kembali ke menu
                case 4:
                    break;
                ///untuk menampilkan apabila salah dalam mengisi pilihan
                default:
                    Console.WriteLine("Pilihan Salah!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}