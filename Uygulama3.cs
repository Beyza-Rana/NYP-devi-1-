using System;
using System.Collections.Generic;

namespace EkipmanTakip
{
    class Ogrenci
    {
        public string OgrenciNo { get; set; }
        public string AdSoyad { get; set; }

        public Ogrenci(string ogrenciNo, string adSoyad)
        {
            OgrenciNo = ogrenciNo;
            AdSoyad = adSoyad;
        }
    }

    class Ekipman
    {
        public string DemirbasNo { get; set; }
        public string Ad { get; set; }
        public bool OduncteMi { get; set; }
        public string? OduncAlanOgrenciNo { get; set; }

        public Ekipman(string demirbasNo, string ad)
        {
            DemirbasNo = demirbasNo;
            Ad = ad;
            OduncteMi = false;
            OduncAlanOgrenciNo = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sistemde kayıtlı varsayılan veriler
            List<Ekipman> ekipmanlar = new List<Ekipman>
            {
                new Ekipman("EKP01", "Kamera"),
                new Ekipman("EKP02", "Tripod")
            };

            List<Ogrenci> ogrenciler = new List<Ogrenci>
            {
                new Ogrenci("101", "Beyza Rana"),
                new Ogrenci("102", "Muhammed Emir")
            };

            while (true)
            {
            
                Console.WriteLine("1 - Ekipman Listesini Gör");
                Console.WriteLine("2 - Ekipman Ödünç Al");
                Console.WriteLine("3 - Ekipman İade Et");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçiminiz (0-3): ");

                string? secim = Console.ReadLine();

                if (secim == "0")
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;
                }
                else if (secim == "1")
                {
                    Console.WriteLine("\n--- Mevcut Ekipmanlar ---");
                    foreach (var ekp in ekipmanlar)
                    {
                        string durum = ekp.OduncteMi ? $"[ÖDÜNÇTE - Alan Ögr. No: {ekp.OduncAlanOgrenciNo}]" : "[MÜSAİT]";
                        Console.WriteLine($"Demirbaş: {ekp.DemirbasNo} | Ad: {ekp.Ad} | Durum: {durum}");
                    }
                }
                else if (secim == "2")
                {
                    Console.Write("\nÖğrenci Numaranızı Giriniz: ");
                    string? ogrNo = Console.ReadLine();

                    
                    Ogrenci? bulunanOgr = ogrenciler.Find(o => o.OgrenciNo == ogrNo);
                    if (bulunanOgr == null)
                    {
                        Console.WriteLine("[HATA] Bu numarada kayıtlı öğrenci bulunamadı!");
                        continue;
                    }

                    Console.Write("Ödünç Alınacak Demirbaş No Giriniz (Örn: EKP01): ");
                    string? demirbasNo = Console.ReadLine();

                 
                    Ekipman? bulunanEkp = ekipmanlar.Find(e => e.DemirbasNo == demirbasNo);
                    if (bulunanEkp == null)
                    {
                        Console.WriteLine("[HATA] Bu demirbaş numarasıyla ekipman bulunamadı!");
                    }
                    else if (bulunanEkp.OduncteMi)
                    {
                        Console.WriteLine($"[REDDEDİLDİ - İKİNCİ ÖDÜNÇ] '{bulunanEkp.Ad}' zaten başka birinde ödünçte!");
                    }
                    else
                    {
                        bulunanEkp.OduncteMi = true;
                        bulunanEkp.OduncAlanOgrenciNo = bulunanOgr.OgrenciNo;
                        Console.WriteLine($"[BAŞARILI] '{bulunanEkp.Ad}' ekipmanı {bulunanOgr.AdSoyad} üzerine ödünç verildi.");
                    }
                }
                else if (secim == "3")
                {
                    Console.Write("\nİade Edilecek Demirbaş No Giriniz (Örn: EKP01): ");
                    string? demirbasNo = Console.ReadLine();

                    Ekipman? bulunanEkp = ekipmanlar.Find(e => e.DemirbasNo == demirbasNo);
                    if (bulunanEkp == null)
                    {
                        Console.WriteLine("[HATA] Bu demirbaş numarasıyla ekipman bulunamadı!");
                    }
                    else if (!bulunanEkp.OduncteMi)
                    {
                        Console.WriteLine($"[REDDEDİLDİ - İKİNCİ İADE] '{bulunanEkp.Ad}' zaten kütüphanede/müsait durumda! İade edilemez.");
                    }
                    else
                    {
                        bulunanEkp.OduncteMi = false;
                        bulunanEkp.OduncAlanOgrenciNo = null;
                        Console.WriteLine($"[BAŞARILI] '{bulunanEkp.Ad}' başarıyla iade alındı.");
                    }
                }
                else
                {
                    Console.WriteLine("[HATA] Geçersiz seçim yaptınız!");
                }
            }
        }
    }
}

