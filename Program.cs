using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//System.IO => dosyaya veri yazma (StreamWriter), dosyadan veri çekme (StreamReader)
namespace OnuncuDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>(); //Boş liste oluşturma

            isimler.Add("Halil");
            isimler.Add("Şevval");
            isimler.Add("Ali");


            List<string> hayvanlar = new List<string>() //Listeyi dolu oluşturma
            {
                "Arı", "Kedi", "Köpek"
            };


            //For döngüsü ile listenin içine eleman ekleme

            List<int> sayilar = new List<int>();
            //0, 10, 20, 30, 40

            for (int i = 0; i < 5; i++) //Bu döngü 5 defa çalışacak. i = 0, 1, 2, 3, 4
            {
                sayilar.Add(i * 10);
            }

            //Foreach döngüsü ile listenin elemanlarını yazdırma

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadKey();
            Console.Clear();


            //Bir listenin içine kullanıcı tarafından değer atma işlemi
            List<string> ulkeler = new List<string>();

            Console.WriteLine("Kaç tane ülke girişi yapmak istersiniz?");
            int adet = int.Parse(Console.ReadLine()); //"5" => 5

            for (int i = 0; i < adet; i++) //0, 1, 2
            {
                Console.WriteLine((i + 1) + ". ülkeyi girin:");
                ulkeler.Add(Console.ReadLine());

                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();



            //Random komutunu kullanarak bir listenin içerisine 5 adet 0 ile 100 arasından rastgele (çift) sayılar atan ve bu sayılar listeleyen program yazınız. Ayrıca bu sayıların toplamlarını da bulalım.

            //1. Boş liste oluşturun.
            //2. For döngüsü ile listenizi rastgele 5 adet çift sayılar ile doldurun.
            //3. Foreach ile listenizin çıktısını alın. 

            List<int> sayilarListesi = new List<int>();
            Random random = new Random();
            int rastgeleSayi = 0, toplam = 0;

            for (int i = 0; i < 5; i++)
            {
                //Rastgele oluşturulan sayı tek olduğu müddetçe, çift olana kadar tekrardan oluşturulsun.
                do
                {
                    rastgeleSayi = random.Next(0, 100);
                } while (rastgeleSayi % 2 == 1);

                sayilarListesi.Add(rastgeleSayi);
            }

            foreach (var sayi in sayilarListesi)
            {
                Console.WriteLine(sayi);
                toplam = toplam + sayi; // toplam += sayi;
            }

            Console.WriteLine("\nListedeki sayıların toplamı : " + toplam);

            Console.ReadKey();
            Console.Clear();


            //Generic List Metotları
            //listeAdi.MetotAdi(varsa parametre burada kullanılır);

            List<string> urunler = new List<string>() { "Laptop", "Telefon", "Monitor", "Mouse" };

            //listeAdi.IndexOf(eleman) => Bu metot içerisine vermiş olduğumuz elemanın, listede kaçıncı indexte bulunduğunu gösterir.

            int urunIndexNo = urunler.IndexOf("Telefon");
            Console.WriteLine("Telefon ürününün index numarası : " + urunIndexNo);

            Console.ReadKey();
            Console.Clear();

            //listeAdi.Contains(eleman) => Bu metot içerisine vermiş olduğumuz elemanın, listede bulunup bulunmadığını bize boolean tipinde gösterir.
            Console.Write("Aramak istediğiniz ürünü giriniz: ");
            string aranacakUrun = Console.ReadLine();

            bool varMi = urunler.Contains(aranacakUrun);

            if (varMi == true)
            {
                Console.WriteLine(aranacakUrun + " listede mevcuttur.");
            }
            else
            {
                Console.WriteLine(aranacakUrun + " listede mevcut değildir.");
            }

            Console.ReadKey();
            Console.Clear();

            //listeAdi.Insert(index, eleman) => Bu metot listemizin içerisine belirlediğimiz indexe belirlediğimiz elemanı eklememizi sağlar.
            //Eğer belirttiğimiz indexte eleman var ise, var olan bu eleman bir sonraki indexe atanır.

            urunler.Insert(3, "Klavye");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun);
            }

            Console.ReadKey();
            Console.Clear();

            //listeAdi.Remove(eleman) => Bu metodun içine verdiğimiz eleman var ise listeden silinir.
            bool silindiMi1 = urunler.Remove("Monitor");

            //listeAdi.RemoveAt(indexNo) => Bu metodun içindeki index numarasına denk gelen eleman var ise silinir.
            urunler.RemoveAt(0);

            foreach (var item in urunler)
            {
                Console.WriteLine(item);
            }

            //listeAdi.Clear() => Bu metot listenin tüm elemanlarını siler.
            urunler.Clear();



            Console.Read();
        }
    }
}
