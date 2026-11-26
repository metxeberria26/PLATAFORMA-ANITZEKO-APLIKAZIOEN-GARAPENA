// =====================================================================
//  FITXATEGIAK - RPG PARTIDA GORDE ETA KARGATU
//  Izena eta abizenak: Manex Etxeberria
//  Data: 2026ko urriak 16
// =====================================================================
//  NOLA LAN EGIN:
//   1. SAIOA (irakurri): 1-6 ariketak.   2. SAIOA (idatzi): 7-12 ariketak.
//   2. Metodo bakoitzean, ezabatu "throw new NotImplementedException();"
//      lerroa eta idatzi zure kodea.
//   3. Sakatu F5: programak zure metodoak probatzen ditu automatikoki:
//         [ OK ]  ondo dago
//         [ X  ]  emaitza okerra (espero zena eta zurea ikusiko dituzu)
//         [ -- ]  oraindik egin gabe
//      Probek beren fitxategiak sortzen dituzte karpeta tenporal batean;
//      ez duzu ezer prestatu behar.
//   4. Proba batek huts egiten badu: jarri eten-puntu bat (F9) zure
//      metodoan eta erabili F10 / F11 pausoz pauso joateko.
//   5. Azkenik, egin 13. ariketa (Jokoa metodoa).
//   6. "datuak" karpetan adibide-fitxategiak dituzu probatzeko.
//   7. EZ aldatu fitxategiaren amaierako "PROBA AUTOMATIKOAK" atala.
//   8. Entrega: Program.cs fitxategi hau bakarrik, Moodleko zereginean.
// =====================================================================

using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Lehenik, zure metodoen proba automatikoak exekutatzen dira:
        ProbakExekutatu();

        // Zure metodoak "datuak" karpetako fitxategiekin probatu nahi badituzu:
        // Console.WriteLine(LerroKopurua("datuak/inbentarioa.txt"));

        // 13. ariketa probatzeko, kendu iruzkina hurrengo lerroari (ezabatu "//"):
        // Jokoa();
    }

    // #################################################################
    //  1. SAIOA - FITXATEGIAK IRAKURTZEA
    // #################################################################

    // =================================================================
    //  1. MAILA - OINARRIZKOA
    // =================================================================

    // 1. Fitxategiak zenbat lerro dituen. Erabili File.ReadAllLines.
    //    Adib.: "ezpata / edabea / giltza" (3 lerro) -> 3     fitxategi hutsa -> 0
    static int LerroKopurua(string bidea)
    {
        
    }

    // 2. Fitxategiaren lehen lerroa. Erabili StreamReader eta using.
    //    Fitxategia hutsik badago (ReadLine-k null itzultzen du) -> "" (testu hutsa).
    //    Adib.: "kaixo / agur" -> "kaixo"     fitxategi hutsa -> ""
    static string LehenLerroa(string bidea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 3. Fitxategiko lerro guztiak array batean. Fitxategia EZ BADAGO,
    //    array hutsa itzuli (ez lehertu!). Erabili File.Exists.
    //    Adib.: "a / b" -> {"a", "b"}     ez dagoen fitxategia -> {}
    static string[] LerroakEdoHutsa(string bidea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =================================================================
    //  2. MAILA - ERTAINA
    // =================================================================

    // 4. Lerro bakoitzean zenbaki bat dago (urre-txanponak). Batu guztiak.
    //    Zenbaki ez diren lerroak SALTATU (try-catch begiztaren barruan).
    //    Adib.: "10 / 25 / 5" -> 40     "10 / abc / 5" -> 15
    static int ZenbakiakBatu(string bidea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 5. CSV fitxategia: lerro bakoitza "Izena;Bizitza" da.
    //    Bizitzen array bat itzuli (int[]), ordena berean.
    //    Pista: lerroa.Split(';') -> {"Gerlaria", "80"}
    //    Adib.: "Gerlaria;80 / Magoa;45" -> {80, 45}
    static int[] Bizitzak(string bidea)
    {
        string[] lerroak = LerroakEdoHutsa(bidea);
        int[] bizitzak = new int[lerroak.Length];
        for (int i=0; i <lerroak.Length;i++)
        {
            string[] zatiak = lerroak[i].Split(";");
            bizitzak[i] = int.Parse (zatiak[1]);
        }
        return bizitzak;
    } 

    // =================================================================
    //  3. MAILA - AURRERATUA
    // =================================================================

    // 6. Konfigurazio-fitxategia: lerro bakoitza "gakoa=balioa" da.
    //    Gako baten balioa itzuli. Gakoa ez badago edo fitxategia ez badago -> "".
    //    Adib.: "zailtasuna=normala / bolumena=7", "bolumena" -> "7"
    //    KONTUZ: "bolu" ez da "bolumena" (gako osoa konparatu).
    static string EzarpenaIrakurri(string bidea, string gakoa)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // #################################################################
    //  2. SAIOA - FITXATEGIAK IDAZTEA
    // #################################################################

    // =================================================================
    //  1. MAILA - OINARRIZKOA
    // =================================================================

    // 7. Inbentarioa gorde: objektu bakoitza lerro batean.
    //    Fitxategia badago, GAINIDATZI. Erabili File.WriteAllLines.
    //    Adib.: {"ezpata", "edabea"} -> fitxategian 2 lerro
    static void InbentarioaGorde(string bidea, string[] objektuak)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 8. Fitxategia ezabatu. Bazegoen eta ezabatu bada -> true.
    //    Ez bazegoen -> false (ez lehertu).
    static bool FitxategiaEzabatu(string bidea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =================================================================
    //  2. MAILA - ERTAINA
    // =================================================================

    // 9. Taldea CSV fitxategian gorde: lerro bakoitza "izena;bizitza".
    //    Erabili StreamWriter eta using (ez ahaztu ixtea!).
    //    Adib.: {"Gerlaria", "Magoa"}, {80, 45} -> "Gerlaria;80" / "Magoa;45"
    static void TaldeaGorde(string bidea, string[] izenak, int[] bizitzak)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 10. Borroka-erregistroa (log): mezua fitxategiaren AMAIERAN gehitu,
    //     lehengo lerroak ezabatu gabe. Fitxategia ez badago, sortu.
    //     Pista: new StreamWriter(bidea, true)
    //     Adib.: bi aldiz deituta ("a", gero "b") -> fitxategian "a" / "b"
    static void LogeanIdatzi(string bidea, string mezua)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =================================================================
    //  3. MAILA - AURRERATUA
    // =================================================================

    // 11. Konfigurazio-fitxategian gako baten balioa aldatu ("gakoa=balioa").
    //     - Gakoa badago -> lerro hori ordezkatu.
    //     - Ez badago    -> lerro berria gehitu amaieran.
    //     - Fitxategia ez badago -> sortu, lerro horrekin.
    //     Pista: lehenik IRAKURRI dena (array batean), gero IDATZI dena.
    //     Adib.: "zailtasuna=normala / bolumena=7", ("bolumena", "3")
    //            -> "zailtasuna=normala / bolumena=3"
    static void EzarpenaAldatu(string bidea, string gakoa, string balioa)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 12. Partida gorde. Fitxategiak 4 lerro izango ditu, ordena honetan:
    //        izena=Ane
    //        maila=3
    //        urrea=150
    //        inbentarioa=ezpata,edabea,giltza
    //     Pista: string.Join(",", inbentarioa) -> "ezpata,edabea,giltza"
    //     (Split-en alderantzizkoa). Inbentario hutsa -> "inbentarioa="
    static void PartidaGorde(string bidea, string izena, int maila, int urrea, string[] inbentarioa)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =================================================================
    //  13. ARIKETA - JOKOA (eskuz zuzenduko da)
    // =================================================================
    //  Programa honek "partida.sav" fitxategia erabiltzen du (exe-aren karpetan).
    //  a) Fitxategia badago: kargatu eta erakutsi izena, maila, urrea eta
    //     inbentarioa (erabili EzarpenaIrakurri). Bestela: eskatu izena, eta
    //     hasi maila=1, urrea=100 eta inbentario hutsarekin.
    //  b) Eskatu zenbat urre irabazi duen abentura honetan (balidatu try-catch-ekin,
    //     baliozko zenbaki bat sartu arte). Gehitu urrea eta igo maila bat.
    //  c) Gorde partida (PartidaGorde) eta idatzi lerro bat "partida.log"-ean
    //     (LogeanIdatzi) data eta orduarekin. Pista: DateTime.Now.
    //  d) Exekutatu programa BI aldiz: bigarrenean datuak kargatu behar dira.
    static void Jokoa()
    {
    }

    // =================================================================
    //  ERRONKA (aukerakoa, +0.5 puntu)
    // =================================================================
    // 14. Partida-fitxategitik inbentarioa kargatu (string[]).
    //     Erabili zure EzarpenaIrakurri eta Split(',').
    //     KONTUZ: "inbentarioa=" (hutsa) -> {} eta EZ {""}.
    //     Adib.: "inbentarioa=ezpata,edabea" -> {"ezpata", "edabea"}
    static string[] InbentarioaKargatu(string bidea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =====================================================================
    // =====================================================================
    //  PROBA AUTOMATIKOAK - EZ ALDATU HEMENDIK BEHERA
    //  Irakasleak prestatutako kodea. Ez duzu dena ulertu behar
    //  ("=>" eta "Func" aurrerago ikasiko ditugu).
    // =====================================================================
    // =====================================================================

    static int ariketaOnak = 0;
    static int ariketaKopurua = 0;
    static bool ariketaOndo = true;
    static bool ariketaEginGabe = false;
    static bool erronkaOndo = false;
    static string probaKarpeta = "";

    static void ProbakExekutatu()
    {
        probaKarpeta = Path.Combine(Path.GetTempPath(), "FitxategiakProbak");
        Directory.CreateDirectory(probaKarpeta);

        Console.WriteLine("==============================================");
        Console.WriteLine("   FITXATEGIAK - PROBA AUTOMATIKOAK");
        Console.WriteLine("==============================================");
        Console.WriteLine("   Proba-fitxategiak: " + probaKarpeta);

        Console.WriteLine();
        Console.WriteLine("---------- 1. SAIOA: IRAKURRI ----------");

        Ariketa("1. LerroKopurua");
        string f1 = Fitx("inb.txt", "ezpata", "edabea", "giltza");
        string fHutsa = Fitx("hutsa.txt");
        Kasua("LerroKopurua(3 lerro)", () => LerroKopurua(f1), 3);
        Kasua("LerroKopurua(fitxategi hutsa)", () => LerroKopurua(fHutsa), 0);
        AriketaAmaitu(false);

        Ariketa("2. LehenLerroa");
        string f2 = Fitx("agurrak.txt", "kaixo", "agur");
        Kasua("LehenLerroa(\"kaixo\" / \"agur\")", () => LehenLerroa(f2), "kaixo");
        Kasua("LehenLerroa(fitxategi hutsa)", () => LehenLerroa(fHutsa), "");
        AriketaAmaitu(false);

        Ariketa("3. LerroakEdoHutsa");
        string f3 = Fitx("ab.txt", "a", "b");
        Kasua("LerroakEdoHutsa(\"a\" / \"b\")", () => LerroakEdoHutsa(f3), new[] { "a", "b" });
        Kasua("LerroakEdoHutsa(ez dagoen fitxategia)", () => LerroakEdoHutsa(EzDagoena()), new string[0]);
        AriketaAmaitu(false);

        Ariketa("4. ZenbakiakBatu");
        string f4a = Fitx("urrea1.txt", "10", "25", "5");
        string f4b = Fitx("urrea2.txt", "10", "abc", "5", "");
        Kasua("ZenbakiakBatu(\"10 / 25 / 5\")", () => ZenbakiakBatu(f4a), 40);
        Kasua("ZenbakiakBatu(\"10 / abc / 5 / (hutsa)\")", () => ZenbakiakBatu(f4b), 15);
        Kasua("ZenbakiakBatu(fitxategi hutsa)", () => ZenbakiakBatu(fHutsa), 0);
        AriketaAmaitu(false);

        Ariketa("5. Bizitzak");
        string f5 = Fitx("taldea.csv", "Gerlaria;80", "Magoa;45", "Arkularia;0");
        Kasua("Bizitzak(Gerlaria;80 / Magoa;45 / Arkularia;0)", () => Bizitzak(f5), new[] { 80, 45, 0 });
        Kasua("Bizitzak(fitxategi hutsa)", () => Bizitzak(fHutsa), new int[0]);
        AriketaAmaitu(false);

        Ariketa("6. EzarpenaIrakurri");
        string f6 = Fitx("ezarpenak.ini", "zailtasuna=normala", "bolumena=7", "hizkuntza=eu");
        Kasua("EzarpenaIrakurri(.., \"bolumena\")", () => EzarpenaIrakurri(f6, "bolumena"), "7");
        Kasua("EzarpenaIrakurri(.., \"hizkuntza\") azkena", () => EzarpenaIrakurri(f6, "hizkuntza"), "eu");
        Kasua("EzarpenaIrakurri(.., \"grafikoak\") ez dago", () => EzarpenaIrakurri(f6, "grafikoak"), "");
        Kasua("EzarpenaIrakurri(.., \"bolu\") gako osoa ez", () => EzarpenaIrakurri(f6, "bolu"), "");
        Kasua("EzarpenaIrakurri(ez dagoen fitxategia)", () => EzarpenaIrakurri(EzDagoena(), "bolumena"), "");
        AriketaAmaitu(false);

        Console.WriteLine();
        Console.WriteLine("---------- 2. SAIOA: IDATZI ----------");

        Ariketa("7. InbentarioaGorde");
        string f7 = Bidea("gorde7.txt");
        Kasua("InbentarioaGorde({\"ezpata\", \"edabea\"})", () => { InbentarioaGorde(f7, new[] { "ezpata", "edabea" }); return Irakurri(f7); }, new[] { "ezpata", "edabea" });
        Kasua("InbentarioaGorde gainidatzi ({\"giltza\"})", () => { InbentarioaGorde(f7, new[] { "giltza" }); return Irakurri(f7); }, new[] { "giltza" });
        AriketaAmaitu(false);

        Ariketa("8. FitxategiaEzabatu");
        string f8 = Fitx("ezabatu.txt", "x");
        Kasua("FitxategiaEzabatu(badago) -> true", () => FitxategiaEzabatu(f8), true);
        string f8b = Fitx("ezabatu2.txt", "y");
        Kasua("ondoren fitxategia ez dago", () => { FitxategiaEzabatu(f8b); return File.Exists(f8b); }, false);
        Kasua("FitxategiaEzabatu(ez dago) -> false", () => FitxategiaEzabatu(EzDagoena()), false);
        AriketaAmaitu(false);

        Ariketa("9. TaldeaGorde");
        string f9 = Bidea("taldea9.csv");
        Kasua("TaldeaGorde({Gerlaria, Magoa}, {80, 45})", () => { TaldeaGorde(f9, new[] { "Gerlaria", "Magoa" }, new[] { 80, 45 }); return Irakurri(f9); }, new[] { "Gerlaria;80", "Magoa;45" });
        Kasua("TaldeaGorde gainidatzi ({Lapurra}, {30})", () => { TaldeaGorde(f9, new[] { "Lapurra" }, new[] { 30 }); return Irakurri(f9); }, new[] { "Lapurra;30" });
        AriketaAmaitu(false);

        Ariketa("10. LogeanIdatzi");
        string f10 = Bidea("borroka.log");
        Kasua("LogeanIdatzi(\"a\") fitxategi berria", () => { LogeanIdatzi(f10, "a"); return Irakurri(f10); }, new[] { "a" });
        Kasua("LogeanIdatzi(\"b\") amaieran gehitu", () => { LogeanIdatzi(f10, "b"); return Irakurri(f10); }, new[] { "a", "b" });
        AriketaAmaitu(false);

        Ariketa("11. EzarpenaAldatu");
        string f11 = Fitx("ezarpenak11.ini", "zailtasuna=normala", "bolumena=7");
        Kasua("EzarpenaAldatu(\"bolumena\", \"3\") ordezkatu", () => { EzarpenaAldatu(f11, "bolumena", "3"); return Irakurri(f11); }, new[] { "zailtasuna=normala", "bolumena=3" });
        Kasua("EzarpenaAldatu(\"hizkuntza\", \"eu\") gehitu", () => { EzarpenaAldatu(f11, "hizkuntza", "eu"); return Irakurri(f11); }, new[] { "zailtasuna=normala", "bolumena=3", "hizkuntza=eu" });
        string f11b = Bidea("berria11.ini");
        Kasua("EzarpenaAldatu(ez dagoen fitxategia)", () => { EzarpenaAldatu(f11b, "bolumena", "5"); return Irakurri(f11b); }, new[] { "bolumena=5" });
        AriketaAmaitu(false);

        Ariketa("12. PartidaGorde");
        string f12 = Bidea("partida12.sav");
        Kasua("PartidaGorde(Ane, 3, 150, {ezpata, edabea})", () => { PartidaGorde(f12, "Ane", 3, 150, new[] { "ezpata", "edabea" }); return Irakurri(f12); }, new[] { "izena=Ane", "maila=3", "urrea=150", "inbentarioa=ezpata,edabea" });
        Kasua("PartidaGorde(Jon, 1, 0, {}) inbentario hutsa", () => { PartidaGorde(f12, "Jon", 1, 0, new string[0]); return Irakurri(f12); }, new[] { "izena=Jon", "maila=1", "urrea=0", "inbentarioa=" });
        AriketaAmaitu(false);

        Ariketa("14. ERRONKA - InbentarioaKargatu (aukerakoa)");
        string f14a = Fitx("p14a.sav", "izena=Ane", "maila=2", "urrea=10", "inbentarioa=ezpata,edabea,giltza");
        string f14b = Fitx("p14b.sav", "izena=Jon", "maila=1", "urrea=0", "inbentarioa=");
        Kasua("InbentarioaKargatu(ezpata,edabea,giltza)", () => InbentarioaKargatu(f14a), new[] { "ezpata", "edabea", "giltza" });
        Kasua("InbentarioaKargatu(\"inbentarioa=\") hutsa", () => InbentarioaKargatu(f14b), new string[0]);
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

    // Proba-fitxategi bat sortzen du lerro horiekin eta haren bide osoa itzultzen du.
    static string Fitx(string izena, params string[] lerroak)
    {
        string bidea = Path.Combine(probaKarpeta, izena);
        File.WriteAllLines(bidea, lerroak);
        return bidea;
    }

    // Bide bat itzultzen du, aurretik fitxategia ezabatuta (idazketa-probetarako).
    static string Bidea(string izena)
    {
        string bidea = Path.Combine(probaKarpeta, izena);
        if (File.Exists(bidea)) File.Delete(bidea);
        return bidea;
    }

    static string EzDagoena()
    {
        return Bidea("ez_dago_" + Guid.NewGuid().ToString("N") + ".txt");
    }

    static string[] Irakurri(string bidea)
    {
        if (!File.Exists(bidea)) return new[] { "(fitxategia ez da sortu)" };
        return File.ReadAllLines(bidea);
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
            Idatzi(ConsoleColor.Red, "  [ X  ] ", deskribapena + "  ->  harrapatu gabeko salbuespena: " + ex.GetType().Name + " (" + ex.Message + ")");
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
        if (a is string[] sx && b is string[] sy)
        {
            if (sx.Length != sy.Length) return false;
            for (int i = 0; i < sx.Length; i++)
            {
                if (sx[i] != sy[i]) return false;
            }
            return true;
        }
        return Equals(a, b);
    }

    static string Testua(object? o)
    {
        if (o == null) return "null";
        if (o is int[] a) return "{" + string.Join(", ", a) + "}";
        if (o is string[] sa)
        {
            string[] komatxoekin = new string[sa.Length];
            for (int i = 0; i < sa.Length; i++)
            {
                komatxoekin[i] = "\"" + sa[i] + "\"";
            }
            return "{" + string.Join(", ", komatxoekin) + "}";
        }
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
