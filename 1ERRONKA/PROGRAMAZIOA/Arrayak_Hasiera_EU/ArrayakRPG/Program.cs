// =====================================================================
//  ARRAYAK - RPG TALDEA
//  Izena eta abizenak: ________________________________
//  Data: ______________
// =====================================================================
//  NOLA LAN EGIN:
//   1. Bete metodoak ordenan (1etik 9ra). Metodo bakoitzean, ezabatu
//      "throw new NotImplementedException();" lerroa eta idatzi zure kodea.
//   2. Sakatu F5: programak zure metodoak probatzen ditu automatikoki:
//         [ OK ]  ondo dago
//         [ X  ]  emaitza okerra (espero zena eta zurea ikusiko dituzu)
//         [ -- ]  oraindik egin gabe
//   3. Proba batek huts egiten badu: jarri eten-puntu bat (F9) zure
//      metodoan eta erabili F10 / F11 pausoz pauso joateko.
//   4. Azkenik, egin 10. ariketa (ZureTaldea metodoa).
//   5. EZ aldatu fitxategiaren amaierako "PROBA AUTOMATIKOAK" atala.
//   6. Entrega: Program.cs fitxategi hau bakarrik, Moodleko zereginean.
// =====================================================================

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Lehenik, zure metodoen proba automatikoak exekutatzen dira:
        ProbakExekutatu();

        // 10. ariketa probatzeko, kendu iruzkina hurrengo lerroari (ezabatu "//"):
         ZureTaldea();
    }

    // =================================================================
    //  1. MAILA - OINARRIZKOA
    // =================================================================
    //  OHARRA: metodo guztiak "static" dira, Main ere static delako.
    //  POO ikastean ulertuko duzu zergatik. Oraingoz: beti static.

    // 1. Taldeak dituen urre-txanpon guztien batura itzultzen du.
    //    Adib.: {10, 25, 5}  ->  40
    //    Array hutsa {}      ->  0
    static int Batura(int[] zenbakiak)
    {
        //throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
        int batura = 0;
        for (int i = 0; i < zenbakiak.Length; i++)
        {
            batura = batura + zenbakiak[i];
        }
        
        return batura;
        
    }

    // 2. Balioen batezbestekoa itzultzen du (double).
    //    Adib.: {10, 20, 30} -> 20.0     {1, 2} -> 1.5
    //    KONTUZ: int / int zatiketak hamartarrak galtzen ditu!
    //    Pista: 1. ariketako metodoa berrerabil dezakezu.
    static double Batezbestekoa(int[] zenbakiak)
    {
       
        int batura = 0;
        double bataz=0;
        for (int i = 0; i < zenbakiak.Length; i++)
        {
            batura = batura + zenbakiak[i];
        }

        double b = batura;
        bataz = b / zenbakiak.Length;
        
        return bataz;
       
    }

    // 3. Balio handiena itzultzen du (bizitza gehien duen pertsonaia).
    //    Adib.: {40, 95, 12} -> 95
    //    KONTUZ: {-5, -2, -9} -> -2   (ez hasi max = 0 jarrita!)
    static int Maximoa(int[] zenbakiak)
    {
        int max = zenbakiak[0];
        foreach(int i in zenbakiak)
        {
            if (i>max)
            {
                max = i;
            }
        }
        return max;
    }

    // =================================================================
    //  2. MAILA - ERTAINA
    // =================================================================

    // 4. Zenbat pertsonaia dauden bizirik (bizitza > 0).
    //    Adib.: {30, 0, 12, 0} -> 2
    static int ZenbatBizirik(int[] bizitza)
    {
        int bizia = 0;
        int kont = 0;
        for(int i =0; i<bizitza.Length; i++)
        {
            if( bizitza[i] != 0)
            {
                kont++;
            }
          
        }
        return kont;
    }

    // 5. Balio handienaren POSIZIOA (indizea) itzultzen du.
    //    Errepikatuta badago, lehenengoaren posizioa.
    //    Adib.: {40, 95, 12} -> 1      {40, 95, 12, 95} -> 1
    static int MaximoarenPosizioa(int[] zenbakiak)
    {
        int handiena = zenbakiak[0];
        int pos = 0;
        for(int i =0;i<zenbakiak.Length;i++)
        {
            if (zenbakiak[i] > handiena)
            {
                handiena=zenbakiak[i];
                pos=i;
            }
        }
        return pos;
    }

    // 6. Objektu baten posizioa inbentarioan. Ez badago: -1.
    //    Adib.: {"ezpata", "edabea", "giltza"}, "giltza"  -> 2
    //           {"ezpata", "edabea", "giltza"}, "ezkutua" -> -1
    static int Bilatu(string[] inbentarioa, string objektua)
    {
        
        for(int i=0; i < inbentarioa.Length;i++)
        {
        if (inbentarioa[i] == objektua)
            {
                return i;
            }
        }
        return -1;
    }

    // =================================================================
    //  3. MAILA - AURRERATUA
    // =================================================================

    // 7. Kalte-eremua: pertsonaia guztiek 'kaltea' puntu galtzen dituzte,
    //    baina bizitza ezin da 0tik behera jaitsi.
    //    Itzuli array BERRI bat. Ez aldatu jatorrizkoa!
    //    Adib.: {30, 5, 0}, 10 -> {20, 0, 0}
    static int[] KalteaEragin(int[] bizitza, int kaltea)
    {
        int[] berria = new int[bizitza.Length];
        for (int i = 0; i < bizitza.Length; i++)
        {
            berria[i] = bizitza[i] - kaltea;
            if (berria[i]<0)
            {
                berria[i] = 0;
            }
               
            
        }
        return berria;
    } 

    // 8. Array berri bat itzultzen du, alderantzizko ordenan.
    //    Adib.: {1, 2, 3} -> {3, 2, 1}
    //    Ez aldatu jatorrizkoa!
    static int[] Alderantzikatu(int[] zenbakiak)
    {
        int[] berria = new int[zenbakiak.Length];

        for (int i = 0; i < zenbakiak.Length; i++)
        {
            berria[i] = zenbakiak[zenbakiak.Length - 1 - i];
        }

        return berria;
    }

    // 9. true balioak gorantz ordenatuta badaude (berdinak onartzen dira).
    //    Adib.: {1, 2, 2, 5} -> true     {3, 1} -> false     {7} -> true
    //    KONTUZ: zenbakiak[i + 1] erabiltzen baduzu, non gelditu behar da begizta?
    static bool GorantzOrdenatuta(int[] zenbakiak)
    {
        for (int i = 0; i < zenbakiak.Length - 1; i++)
        {
            if (zenbakiak[i] > zenbakiak[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    // =================================================================
    //  10. ARIKETA - ZURE TALDEA (eskuz zuzenduko da)
    // =================================================================
    //  a) Galdetu erabiltzaileari zenbat pertsonaia dituen bere taldeak.
    //  b) Sortu tamaina horretako int array bat.
    //  c) for batekin, eskatu pertsonaia bakoitzaren bizitza eta gorde arrayan.
    //  d) Inprimatu, ZURE metodoak erabiliz: bizitza guztira, batezbestekoa,
    //     handiena (eta zein pertsonaiak duen) eta zenbat dauden bizirik.
    //  e) Aplikatu 15 puntuko kalte-eremua eta inprimatu talde berria.
    static void ZureTaldea()
    {
        Console.WriteLine("Zenbat pertsona ditu taldeak?");
        int kopurua = Convert.ToInt32(Console.ReadLine());

        int[] bizitza = new int[kopurua];

        for (int i = 0; i < bizitza.Length; i++)
        {
            Console.WriteLine("Sartu " + (i + 1) + ". pertsonaren bizitza:");
            bizitza[i] = Convert.ToInt32(Console.ReadLine());
        }

        int guztira = 0;
        int handiena = bizitza[0];
        int pertsona = 1;

        for (int i = 0; i < bizitza.Length; i++)
        {
            guztira = guztira + bizitza[i];

            if (bizitza[i] > handiena)
            {
                handiena = bizitza[i];
                pertsona = i + 1;
            }
        }

        double batazbestekoa = (double)guztira / kopurua;

        Console.WriteLine("Bizitza guztira: " + guztira);
        Console.WriteLine("Batazbestekoa: " + batazbestekoa);
        Console.WriteLine("Bizitza handiena: " + handiena);
        Console.WriteLine("Pertsona zenbakia: " + pertsona);

        int[] berria = new int[kopurua];

        for (int i = 0; i < bizitza.Length; i++)
        {
            berria[i] = bizitza[i] - 15;

            if (berria[i] < 0)
            {
                berria[i] = 0;
            }
        }

        Console.WriteLine("Talde berria:");

        for (int i = 0; i < berria.Length; i++)
        {
            Console.WriteLine(berria[i]);
        }
    }

    // =================================================================
    //  ERRONKA (aukerakoa, +0.5 puntu)
    // =================================================================
    // 11. Bigarren balio handiena (handienaren desberdina).
    //     Adib.: {40, 95, 12, 95, 60} -> 60      {9, 3, 9, 3} -> 3
    //     Gutxienez 2 balio desberdin daudela suposa dezakezu.
    static int BigarrenHandiena(int[] zenbakiak)
    {
        int handiena = zenbakiak[0];

        for (int i = 0; i < zenbakiak.Length; i++)
        {
            if (zenbakiak[i] > handiena)
            {
                handiena = zenbakiak[i];
            }
        }

        int bigarrena = 0;
        bool aurkituta = false;

        for (int i = 0; i < zenbakiak.Length; i++)
        {
            if (zenbakiak[i] < handiena)
            {
                if (aurkituta == false || zenbakiak[i] > bigarrena)
                {
                    bigarrena = zenbakiak[i];
                    aurkituta = true;
                }
            }
        }

        return bigarrena;
    }

    // =====================================================================
    // =====================================================================
    //  PROBA AUTOMATIKOAK - EZ ALDATU HEMENDIK BEHERA
    //  Irakasleak prestatutako kodea. Oraindik ez duzu dena ulertu behar
    //  (try-catch eta "=>" aurrerago ikasiko ditugu).
    // =====================================================================
    // =====================================================================

    static int ariketaOnak = 0;
    static int ariketaKopurua = 0;
    static bool ariketaOndo = true;
    static bool ariketaEginGabe = false;
    static bool erronkaOndo = false;

    static void ProbakExekutatu()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("   ARRAYAK - PROBA AUTOMATIKOAK");
        Console.WriteLine("==============================================");

        Ariketa("1. Batura");
        Kasua("Batura({10, 25, 5})", () => Batura(new[] { 10, 25, 5 }), 40);
        Kasua("Batura({7})", () => Batura(new[] { 7 }), 7);
        Kasua("Batura({-3, 3, 10})", () => Batura(new[] { -3, 3, 10 }), 10);
        Kasua("Batura({}) array hutsa", () => Batura(new int[0]), 0);
        AriketaAmaitu(false);

        Ariketa("2. Batezbestekoa");
        Kasua("Batezbestekoa({10, 20, 30})", () => Batezbestekoa(new[] { 10, 20, 30 }), 20.0);
        Kasua("Batezbestekoa({1, 2})", () => Batezbestekoa(new[] { 1, 2 }), 1.5);
        Kasua("Batezbestekoa({1, 2, 2})", () => Batezbestekoa(new[] { 1, 2, 2 }), 5.0 / 3);
        Kasua("Batezbestekoa({5})", () => Batezbestekoa(new[] { 5 }), 5.0);
        AriketaAmaitu(false);

        Ariketa("3. Maximoa");
        Kasua("Maximoa({40, 95, 12})", () => Maximoa(new[] { 40, 95, 12 }), 95);
        Kasua("Maximoa({95, 40, 12}) lehena", () => Maximoa(new[] { 95, 40, 12 }), 95);
        Kasua("Maximoa({12, 40, 95}) azkena", () => Maximoa(new[] { 12, 40, 95 }), 95);
        Kasua("Maximoa({-5, -2, -9}) negatiboak", () => Maximoa(new[] { -5, -2, -9 }), -2);
        AriketaAmaitu(false);

        Ariketa("4. ZenbatBizirik");
        Kasua("ZenbatBizirik({30, 0, 12, 0})", () => ZenbatBizirik(new[] { 30, 0, 12, 0 }), 2);
        Kasua("ZenbatBizirik({0, 0})", () => ZenbatBizirik(new[] { 0, 0 }), 0);
        Kasua("ZenbatBizirik({1, 2, 3})", () => ZenbatBizirik(new[] { 1, 2, 3 }), 3);
        Kasua("ZenbatBizirik({}) array hutsa", () => ZenbatBizirik(new int[0]), 0);
        AriketaAmaitu(false);

        Ariketa("5. MaximoarenPosizioa");
        Kasua("MaximoarenPosizioa({40, 95, 12})", () => MaximoarenPosizioa(new[] { 40, 95, 12 }), 1);
        Kasua("MaximoarenPosizioa({95, 40})", () => MaximoarenPosizioa(new[] { 95, 40 }), 0);
        Kasua("MaximoarenPosizioa({12, 40, 95})", () => MaximoarenPosizioa(new[] { 12, 40, 95 }), 2);
        Kasua("MaximoarenPosizioa({40, 95, 12, 95}) errepikatua", () => MaximoarenPosizioa(new[] { 40, 95, 12, 95 }), 1);
        AriketaAmaitu(false);

        Ariketa("6. Bilatu");
        string[] inb = { "ezpata", "edabea", "giltza" };
        Kasua("Bilatu(inbentarioa, \"giltza\")", () => Bilatu(inb, "giltza"), 2);
        Kasua("Bilatu(inbentarioa, \"ezpata\")", () => Bilatu(inb, "ezpata"), 0);
        Kasua("Bilatu(inbentarioa, \"ezkutua\") ez dago", () => Bilatu(inb, "ezkutua"), -1);
        Kasua("Bilatu({}, \"ezpata\") inbentario hutsa", () => Bilatu(new string[0], "ezpata"), -1);
        AriketaAmaitu(false);

        Ariketa("7. KalteaEragin");
        Kasua("KalteaEragin({30, 5, 0}, 10)", () => KalteaEragin(new[] { 30, 5, 0 }, 10), new[] { 20, 0, 0 });
        Kasua("KalteaEragin({50, 50}, 0)", () => KalteaEragin(new[] { 50, 50 }, 0), new[] { 50, 50 });
        Kasua("KalteaEragin({}, 5) array hutsa", () => KalteaEragin(new int[0], 5), new int[0]);
        int[] jatorrizkoa7 = { 30, 5, 0 };
        Kasua("jatorrizko arraya ez da aldatzen", () => { KalteaEragin(jatorrizkoa7, 10); return jatorrizkoa7; }, new[] { 30, 5, 0 });
        AriketaAmaitu(false);

        Ariketa("8. Alderantzikatu");
        Kasua("Alderantzikatu({1, 2, 3})", () => Alderantzikatu(new[] { 1, 2, 3 }), new[] { 3, 2, 1 });
        Kasua("Alderantzikatu({4, 8})", () => Alderantzikatu(new[] { 4, 8 }), new[] { 8, 4 });
        Kasua("Alderantzikatu({7})", () => Alderantzikatu(new[] { 7 }), new[] { 7 });
        int[] jatorrizkoa8 = { 1, 2, 3 };
        Kasua("jatorrizko arraya ez da aldatzen", () => { Alderantzikatu(jatorrizkoa8); return jatorrizkoa8; }, new[] { 1, 2, 3 });
        AriketaAmaitu(false);

        Ariketa("9. GorantzOrdenatuta");
        Kasua("GorantzOrdenatuta({1, 2, 2, 5})", () => GorantzOrdenatuta(new[] { 1, 2, 2, 5 }), true);
        Kasua("GorantzOrdenatuta({3, 1})", () => GorantzOrdenatuta(new[] { 3, 1 }), false);
        Kasua("GorantzOrdenatuta({1, 5, 3})", () => GorantzOrdenatuta(new[] { 1, 5, 3 }), false);
        Kasua("GorantzOrdenatuta({1, 2, 3, 0})", () => GorantzOrdenatuta(new[] { 1, 2, 3, 0 }), false);
        Kasua("GorantzOrdenatuta({7})", () => GorantzOrdenatuta(new[] { 7 }), true);
        AriketaAmaitu(false);

        Ariketa("11. ERRONKA - BigarrenHandiena (aukerakoa)");
        Kasua("BigarrenHandiena({40, 95, 12, 95, 60})", () => BigarrenHandiena(new[] { 40, 95, 12, 95, 60 }), 60);
        Kasua("BigarrenHandiena({1, 2})", () => BigarrenHandiena(new[] { 1, 2 }), 1);
        Kasua("BigarrenHandiena({9, 3, 9, 3})", () => BigarrenHandiena(new[] { 9, 3, 9, 3 }), 3);
        Kasua("BigarrenHandiena({-1, -5, -3})", () => BigarrenHandiena(new[] { -1, -5, -3 }), -3);
        AriketaAmaitu(true);

        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine($"   Ariketak ondo: {ariketaOnak} / {ariketaKopurua}");
        if (erronkaOndo)
        {
            Console.WriteLine("   Erronka: EGINDA! (+0.5)");
        }
        Console.WriteLine("==============================================");
        Console.WriteLine("   Gogoratu: probak gainditzea ez da dena.");
        Console.WriteLine("   Irakasleak zure kodea ere irakurriko du.");
        Console.WriteLine("==============================================");
    }

    static void Ariketa(string izena)
    {
        Console.WriteLine();
        Console.WriteLine(izena);
        ariketaOndo = true;
        ariketaEginGabe = false;
    }

    static void AriketaAmaitu(bool erronka)
    {
        bool ondo = ariketaOndo && !ariketaEginGabe;
        if (erronka)
        {
            erronkaOndo = ondo;
        }
        else
        {
            ariketaKopurua++;
            if (ondo)
            {
                ariketaOnak++;
            }
        }
    }

    static void Kasua(string deskribapena, Func<object> deia, object espero)
    {
        try
        {
            object lortua = deia();
            if (Berdinak(lortua, espero))
            {
                Idatzi(ConsoleColor.Green, "  [ OK ] ", deskribapena);
            }
            else
            {
                ariketaOndo = false;
                Idatzi(ConsoleColor.Red, "  [ X  ] ", deskribapena + "  ->  espero zen: " + Testua(espero) + "  |  zurea: " + Testua(lortua));
            }
        }
        catch (NotImplementedException)
        {
            ariketaEginGabe = true;
            Idatzi(ConsoleColor.DarkGray, "  [ -- ] ", deskribapena + "  (egin gabe)");
        }
        catch (Exception ex)
        {
            ariketaOndo = false;
            Idatzi(ConsoleColor.Red, "  [ X  ] ", deskribapena + "  ->  ERROREA: " + ex.GetType().Name);
        }
    }

    static bool Berdinak(object? a, object? b)
    {
        if (a is int[] x && b is int[] y)
        {
            if (x.Length != y.Length) return false;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != y[i]) return false;
            }
            return true;
        }
        if (a is double d1 && b is double d2)
        {
            return Math.Abs(d1 - d2) < 0.001;
        }
        return Equals(a, b);
    }

    static string Testua(object? o)
    {
        if (o == null) return "null";
        if (o is int[] a) return "{" + string.Join(", ", a) + "}";
        if (o is string s) return "\"" + s + "\"";
        if (o is double d) return d.ToString("0.###", CultureInfo.InvariantCulture);
        if (o is bool b)
        {
            if (b) return "true";
            return "false";
        }
        return o.ToString() ?? "";
    }

    static void Idatzi(ConsoleColor kolorea, string etiketa, string testua)
    {
        Console.ForegroundColor = kolorea;
        Console.Write(etiketa);
        Console.ResetColor();
        Console.WriteLine(testua);
    }
}
