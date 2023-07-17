using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        static List<Kisi> rehber = new List<Kisi>();

        static void Main(string[] args)
        {
            VarsayilanRehberiOlustur();

            while (true)
            {
                Console.WriteLine("Telefon Rehberi Uygulaması");
                Console.WriteLine("1. Telefon Numarası Kaydet");
                Console.WriteLine("2. Telefon Numarası Sil");
                Console.WriteLine("3. Telefon Numarası Güncelle");
                Console.WriteLine("4. Rehberi Listele");
                Console.WriteLine("5. Rehberde Arama");
                Console.WriteLine("6. Çıkış");
                Console.WriteLine();

                Console.Write("Bir işlem seçin (1-6): ");
                string secim = Console.ReadLine();
                Console.WriteLine();

                switch (secim)
                {
                    case "1":
                        TelefonNumarasiKaydet();
                        break;
                    case "2":
                        TelefonNumarasiSil();
                        break;
                    case "3":
                        TelefonNumarasiGuncelle();
                        break;
                    case "4":
                        RehberiListele();
                        break;
                    case "5":
                        RehberdeAra();
                        break;
                    case "6":
                        Console.WriteLine("Uygulama kapatılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void VarsayilanRehberiOlustur()
        {
            Kisi kisi1 = new Kisi("İlkyardım", "112");
            Kisi kisi2 = new Kisi("İtfaiye", "110");
            Kisi kisi3 = new Kisi("Polis", "155");
            Kisi kisi4 = new Kisi("Belediye", "153");
            Kisi kisi5 = new Kisi("Afad", "122");

            rehber.Add(kisi1);
            rehber.Add(kisi2);
            rehber.Add(kisi3);
            rehber.Add(kisi4);
            rehber.Add(kisi5);
        }


        static void TelefonNumarasiKaydet()
        {
            Console.Write("Ad: ");
            string ad = Console.ReadLine();

            Console.Write("Telefon Numarası: ");
            string telefon = Console.ReadLine();

            Kisi kisi = new Kisi(ad, telefon);
            rehber.Add(kisi);

            Console.WriteLine("Kişi rehbere kaydedildi.");
        }

        static void TelefonNumarasiSil()
        {
            Console.Write("Silinecek kişinin adını girin: ");
            string ad = Console.ReadLine();

            Kisi kisi = rehber.Find(x => x.Ad == ad);
            if (kisi != null)
            {
                rehber.Remove(kisi);
                Console.WriteLine("Kişi rehberden silindi.");
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı!");
            }
        }

        static void TelefonNumarasiGuncelle()
        {
            Console.Write("Güncellenecek kişinin adını girin: ");
            string ad = Console.ReadLine();

            Kisi kisi = rehber.Find(x => x.Ad == ad);
            if (kisi != null)
            {
                Console.Write("Yeni telefon numarasını girin: ");
                string yeniTelefon = Console.ReadLine();

                kisi.Telefon = yeniTelefon;

                Console.WriteLine("Kişinin telefon numarası güncellendi.");
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı!");
            }
        }

        static void RehberiListele()
        {
            rehber.Sort((x, y) => x.Ad.CompareTo(y.Ad));

            Console.WriteLine("Rehberdeki kişiler:");
            foreach (var kisi in rehber)
            {
                Console.WriteLine($"{kisi.Ad}: {kisi.Telefon}");
            }
        }

        static void RehberdeAra()
        {
            Console.Write("Aranacak kişinin adını girin: ");
            string ad = Console.ReadLine();

            List<Kisi> bulunanlar = rehber.FindAll(x => x.Ad.Contains(ad));

            if (bulunanlar.Count > 0)
            {
                Console.WriteLine("Arama sonuçları:");
                foreach (var kisi in bulunanlar)
                {
                    Console.WriteLine($"{kisi.Ad}: {kisi.Telefon}");
                }
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı!");
            }
        }
    }

    class Kisi
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }

        public Kisi(string ad, string telefon)
        {
            Ad = ad;
            Telefon = telefon;
        }
    }
}
