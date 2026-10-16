
using System;
using System.Collections.Generic;

class Uygulama2
{
    public static bool NumaraVarMi(List<string> liste, string aranan)
    {
        if (liste == null || liste.Count == 0)
        {
            return false;
        }

        foreach (string numara in liste)
        {
            if (numara == aranan)
            {
                return true; 
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
    
        List<string> numaralar = new List<string> { "101", "102", "103", "104" };
        List<string> bosListe = new List<string>();

        bool ilkElemanVarMi = NumaraVarMi(numaralar, "101");
        Console.WriteLine($"1. İlk eleman aranıyor ('101'): {ilkElemanVarMi}");

        bool sonElemanVarMi = NumaraVarMi(numaralar, "104");
        Console.WriteLine($"2. Son eleman aranıyor ('104'): {sonElemanVarMi}");

        bool olmayanVarMi = NumaraVarMi(numaralar, "999");
        Console.WriteLine($"3. Olmayan numara aranıyor ('999'): {olmayanVarMi}");

    
        bool bosListedeVarMi = NumaraVarMi(bosListe, "101");
        Console.WriteLine($"4. Boş listede arama yapılıyor: {bosListedeVarMi}");
    }
}




