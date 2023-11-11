using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnuncuDersMetotlar
{
    internal class Program
    {
        #region Açıklamalar
        //Metot nasıl oluşturulur:

        //ErişimBelirleyici static MetotTipi MetotAdi()
        //{
        //}

        //Erişim Belirleyiciler => public, private, internal, protected gibi değerler alabilen erişim belirleyiciler metotların, değişkenlerin, class'ların vs. başına koyulur.

        //Kullandığımız erişim belirleyiciye göre oluşturduğumuz yapının nerelerden çağırılıp kullanılabileceğini belirleriz.

        //public => public olan yapılar projenin her yerinden çağırılabilir.
        //private => private olan yapılar sadece oluşturulduğu class üzerinde kullanılabilir.

        //Metot Tipleri => int, string gibi değişken tipleri olabileceği gibi void, liste veya class tipinde de bir metot oluşturulabilir.

        //Bir metot ismi oluşturulurken verdiğimiz ismin ilk harfi mutlaka büyük harfli olmalıdır.
        #endregion

        #region Metot Oluşturma Türleri
        //Bir metodun geriye değer döndürmemesini istiyorsak, void tipinde oluştururuz.
        //Bir metodun geriye değer döndürmesini istiyorsak, void tipinde oluşturmayız.

        //1.Geriye değer döndürmeyen parametre almayan
        //2.Geriye değer döndürmeyen parametre alan
        //3.Geriye değer döndüren parametre almayan
        //4.Geriye değer döndüren parametre alan
        #endregion

        #region 1.Geriye değer döndürmeyen parametre almayan

        public static void BilgiGetir()
        {
            Console.WriteLine("BilgiGetir metodu çalıştı");
        }

        public static void KullaniciBilgisiAl()
        {
            string ad, soyad;

            Console.WriteLine("Adınızı girin:");
            ad = Console.ReadLine();

            Console.WriteLine("Adınızı girin:");
            soyad = Console.ReadLine();

            Console.WriteLine($"Hoşgeldin {ad} {soyad}");
        }

        public static void KonsoluTemizle()
        {
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region 2.Geriye değer döndürmeyen parametre alan
        public static void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"Sayıların toplamı : {toplam}");
            //Console.WriteLine("Sayıların toplamı : " + toplam);
        }
       
        public static void Listele(List<string> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }

        //Parametre olara verilen listenin elemanlarının toplamını bulan bir metot yazınız.

        public static void ListeElemanlariniTopla(List<int> liste)
        {
            int toplam = 0;

            foreach (var item in liste)
            {
                toplam = toplam + item;
            }
            Console.WriteLine("Toplam : " + toplam);

        }

        #endregion


        #region 3.Geriye değer döndüren parametre almayan
        //Geriye değer döndüren metotların en sonunda mutlaka return anahtar kelimesi kullanılmalıdır.
        public static string IsimDondur()
        {
            Console.WriteLine("Adınız nedir?");
            string ad = Console.ReadLine();

            return ad;
        }

        public static int BuyukSayiyiDondur()
        {
            Console.WriteLine("İki adet sayı girin:");

            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());

            if (s1 > s2)
            {
                return s1;
            }
            else if (s1 < s2)
            {
                return s2;
            }
            else
            {
                Console.WriteLine();
                return 0;
            }

        }



        #endregion
        static void Main(string[] args)
        {
            //BilgiGetir();

            //KonsoluTemizle();

            //KullaniciBilgisiAl();

            //KonsoluTemizle();

            //Topla(8, -22);

            //KonsoluTemizle();

            //List<string> isimler = new List<string>() { "Ali", "Veli", "Can", "Fatih" };

            //Listele(isimler);

            //KonsoluTemizle();

            //List<int> tekSayilar = new List<int>() { 3, 5, 7, 9};
            //List<int> ciftSayilar = new List<int>() { 2, 4, 6, 8 };

            //Console.WriteLine("Tek sayılar için :"); 
            //ListeElemanlariniTopla(tekSayilar);

            //Console.WriteLine("\nÇift sayılar için :");
            //ListeElemanlariniTopla(ciftSayilar);

            //KonsoluTemizle();

            //string isim = IsimDondur();

            //Console.Write("Hoşgeldin " + isim);

            //KonsoluTemizle();


            int sonuc = BuyukSayiyiDondur();

            if (sonuc == 0)
            {
                Console.WriteLine("Eşit sayılar girdiniz!");
            }
            else
            {
                Console.WriteLine(sonuc);
            }


            Console.Read();
        }
    }
}
