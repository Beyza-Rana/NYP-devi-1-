//UYGULAMA-1

using System;

class Program
{
    static void Main(string[] args)
    {
     // Sistemde tek bir ekipmanın olduğu ve ödünçte olduğu durumdaki hali.
        bool ekipmanOduncteMi = true; 

        Console.Write("Ödünç alma süresini gün olarak giriniz: ");
        string? input = Console.ReadLine();

        // 1. KONTROL: Sayı mı ve 1-7 aralığında mı? (abc, 0, 8 testleri için)
        if (!int.TryParse(input, out int gunSayisi) || gunSayisi < 1 || gunSayisi > 7)
        {
            Console.WriteLine("Hata: Geçersiz giriş! Lütfen 1 ile 7 arasında bir sayı giriniz.");
        }
        // 2. KONTROL: Gün sayısı geçerli (1-7 arası) ama ekipman ödünçte (1 ve 7 testleri için)
        else if (ekipmanOduncteMi)
        {
            Console.WriteLine($"[REDDEDİLDİ] Girdiğiniz gün sayısı ({gunSayisi}): Ekipman şu an başka birinde ödünçte olduğu için talebiniz reddedildi.");
        }
        else
        {
            Console.WriteLine($"[ONAYLANDI] Ekipman {gunSayisi} günlüğüne başarıyla ödünç verildi.");
        }


        /* 
       
        Slayttaki senaryoda ekipman seçimi yapılmadan doğrudan gün sayısı sorulduğu için
        ve sistem varsayılan olarak cihazı ödünçte kabul ettiği için 1-7 arasındaki
        tüm değerlerde talep reddedilmektedir.
        Gerçek hayattaki bir otomasyon sisteminde kullanıcı önce ekipman seçmeli,
        seçilen ekipmanın anlık durumuna (müsait/ödünçte) göre karar verilmelidir. 
        Bu nedenle aşağıdaki kodları da yazmak istedim

    
        string ekipman1 = "Kamera";
        bool ekipman1OduncteMi = false; // MÜSAİT

        string ekipman2 = "Tripod";
        bool ekipman2OduncteMi = true;  // ÖDÜNÇTE

        Console.WriteLine("\n--- GELİŞTİRİLMİŞ SEÇENEK ---");
        Console.WriteLine($"1. {ekipman1} (Müsait)");
        Console.WriteLine($"2. {ekipman2} (Ödünçte)");
        Console.Write("İşlem yapmak istediğiniz ekipmanı seçin (1 veya 2): ");
        string? secimInput = Console.ReadLine();

        if (secimInput == "1" || secimInput == "2")
        {
            string secilenEkipman = (secimInput == "1") ? ekipman1 : ekipman2;
            bool secilenOduncteMi = (secimInput == "1") ? ekipman1OduncteMi : ekipman2OduncteMi;

            Console.Write($"'{secilenEkipman}' için gün sayısı giriniz: ");
            string? gunStr = Console.ReadLine();

            if (!int.TryParse(gunStr, out int gun) || gun < 1 || gun > 7)
            {
                Console.WriteLine("[REDDEDİLDİ] Geçersiz gün sayısı!");
            }
            else if (secilenOduncteMi)
            {
                Console.WriteLine($"[REDDEDİLDİ] '{secilenEkipman}' zaten ödünçte.");
            }
            else
            {
                Console.WriteLine($"[ONAYLANDI] '{secilenEkipman}' {gun} günlüğüne verildi.");
            }
          }  
        */
    }
        
        
    }


























}
