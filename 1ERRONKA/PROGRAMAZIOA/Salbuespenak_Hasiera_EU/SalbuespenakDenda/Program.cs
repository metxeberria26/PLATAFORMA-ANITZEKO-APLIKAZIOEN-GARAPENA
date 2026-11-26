// =====================================================================
//  SALBUESPENAK - RPG DENDA
//  Izena eta abizenak: ________________________________
//  Data: ______________
// =====================================================================
//  NOLA LAN EGIN:
//   1. Bete metodoak ordenan (1etik 6ra). Metodo bakoitzean, ezabatu
//      "throw new NotImplementedException();" lerroa eta idatzi zure kodea.
//   2. Sakatu F5: programak zure metodoak probatzen ditu automatikoki:
//         [ OK ]  ondo dago
//         [ X  ]  emaitza okerra (espero zena eta zurea ikusiko dituzu)
//         [ -- ]  oraindik egin gabe
//   3. Proba batek huts egiten badu: jarri eten-puntu bat (F9) zure
//      metodoan eta erabili F10 / F11 pausoz pauso joateko.
//   4. Azkenik, egin 7. ariketa (ZenbakiaEskatu eta Denda metodoak).
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

        // 7. ariketa probatzeko, kendu iruzkina hurrengo lerroari (ezabatu "//"):
        // Denda();
    }

    // =================================================================
    //  1. MAILA - OINARRIZKOA
    // =================================================================

    // 1. Testua zenbaki oso bihurtzen du. Ezin bada (FormatException),
    //    0 itzultzen du. Erabili try-catch.
    //    Adib.: "42" -> 42     "-7" -> -7     "abc" -> 0     "" -> 0
    static int ZenbakiaEdoZero(string testua)
    {
        int zenbakia = 0;
        Console.WriteLine("Eman zenbaki bat");

        try
        {
            zenbakia = int.Parse(testua);
            Console.WriteLine(zenbakia);
        }
        catch (FormatException)
        {
            Console.WriteLine(0);
        }
        return zenbakia;
    }

    // 2. a / b zatiketa osoa. b = 0 bada (DivideByZeroException), 0 itzultzen du.
    //    Erabili try-catch.
    //    Adib.: (10, 2) -> 5     (7, 0) -> 0
    //    Pentsatu: if batekin ere egin zitekeen? Zein da hobea? (ikus 3. ariketa)
    static int ZatiketaSegurua(int a, int b)
    {
        try
        {
            return (a / b);
        }
        catch (DivideByZeroException)
        {
            return 0;
        }

    }

    // =================================================================
    //  2. MAILA - ERTAINA
    // =================================================================

    // 3. Arrayko i posizioko elementua itzultzen du. Posizioa ez badago, -1.
    //    KONTUZ: ariketa honetan EZ erabili try-catch. Erabili if bat
    //    (saihestu errorea, harrapatu beharrean).
    //    Adib.: ({10, 20, 30}, 1) -> 20     ({10, 20, 30}, 3) -> -1
    static int ElementuaLortu(int[] zenbakiak, int i)
    {
        if (i >= 0 && i < zenbakiak.Length)
        {
            return zenbakiak[i];

        }
        else
        {
            return -1;
        }


    }

    // 4. Testua zenbaki oso bihurtzean ZER gertatzen den esaten du:
    //    "OK"                 -> ondo bihurtzen bada
    //    "FormatException"    -> ez bada zenbaki bat
    //    "OverflowException"  -> zenbakia handiegia bada int baterako
    //    Erabili catch bat salbuespen mota bakoitzeko.
    //    Adib.: "12" -> "OK"    "kaixo" -> "FormatException"    "99999999999" -> "OverflowException"
    static string ErroreMota(string testua)
    {

        try
        {
            int a = int.Parse(testua);
            return "OK";
        }
        catch (FormatException)
        {
            return "FormatException";
        }
        catch (OverflowException)
        {
            return "OverflowException";
        }
    }

    // =================================================================
    //  3. MAILA - AURRERATUA
    // =================================================================

    // 5. Baliozko zenbaki guztien batura. Zenbaki ez direnak SALTATU egiten
    //    dira eta begiztak JARRAITU egiten du.
    //    Pista: non jarri behar da try-catch-a, begiztaren barruan ala kanpoan?
    //    Adib.: {"10", "abc", "5"} -> 15     {"x", "y"} -> 0
    static int BaliozkoakBatu(string[] testuak)
    {
        int batura = 0;

        foreach(string t in testuak)
        {
            try
            {
                int zenbakiak = int.Parse(t);
                batura += zenbakiak;
            }
            catch(FormatException)
            {

            }
        }
        return batura;  
    }

    // 6. Dendan erosi: geratzen den urrea itzultzen du (urrea - prezioa).
    //    Erosketa ezinezkoa bada, ZUK jaurti salbuespen bat:
    //      - prezioa < 0         -> throw new ArgumentException("Prezioa ezin da negatiboa izan");
    //      - prezioa > urrea     -> throw new ArgumentException("Ez duzu urre nahikorik");
    //    Adib.: (100, 30) -> 70     (20, 30) -> ArgumentException
    static int ErosketaEgin(int urrea, int prezioa)
    {
        try
        {
            if (prezioa < 0)
            {
                throw new ArgumentException("Prezioa ezin da negatiboa izan");
            }

            if (prezioa > urrea)
            {
                throw new ArgumentException("Ez duzu urre nahikorik");
            }

            return urrea - prezioa;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Errorea: " + ex.Message);
            throw;
        }
    }

    // =================================================================
    //  7. ARIKETA - DENDA (eskuz zuzenduko da)
    // =================================================================
    //  a) ZenbakiaEskatu: erakutsi mezua, irakurri zenbaki bat kontsolatik
    //     (Convert.ToInt32) eta, baliozkoa ez bada, esan zergatik eta BERRIZ
    //     eskatu, baliozko zenbaki bat sartu arte (while + try-catch).
    //     Tratatu FormatException eta OverflowException, mezu desberdinekin.
    static int ZenbakiaEskatu(string mezua)
    {
        //throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
        int zenbakia = 0;
        bool zuzena = false;

        while (!zuzena)
        {
            try
            {
                Console.WriteLine(mezua);
                zenbakia = Convert.ToInt32(Console.ReadLine());
                zuzena = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ez da zenbaki bat");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Zenbakia handiegia da");
            }
        }

        return zenbakia;
    }

    //  b) Denda: eskatu urrea eta objektuaren prezioa (ZenbakiaEskatu erabiliz),
    //     deitu ErosketaEgin-i eta inprimatu geratzen den urrea.
    //     ErosketaEgin-ek salbuespena jaurtitzen badu, harrapatu (ArgumentException)
    //     eta inprimatu haren mezua (ex.Message). Programak EZ du lehertu behar.
    static void Denda()
    {
        int urrea = ZenbakiaEskatu("Sartu urrea:");
        int prezioa = ZenbakiaEskatu("Sartu prezioa:");

        try
        {
            int a = ErosketaEgin(urrea, prezioa);
            Console.WriteLine(a);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // =================================================================
    //  ERRONKA (aukerakoa, +0.5 puntu)
    // =================================================================
    // 8. Testua zenbaki bihurtu eta [min, max] tartean dagoela egiaztatu.
    //    - Ez bada zenbaki bat -> FormatException (int.Parse-k berak jaurtitzen du)
    //    - Tartetik kanpo      -> throw new ArgumentOutOfRangeException("testua", "Tartetik kanpo");
    //    - Bestela             -> zenbakia itzuli
    //    Adib.: ("5", 1, 10) -> 5     ("50", 1, 10) -> ArgumentOutOfRangeException
    static int ZenbakiaTartean(string testua, int min, int max)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =====================================================================
    // =====================================================================
    //  PROBA AUTOMATIKOAK - EZ ALDATU HEMENDIK BEHERA
    //  Irakasleak prestatutako kodea. Ez duzu dena ulertu behar
    //  ("=>" eta "Action" aurrerago ikasiko ditugu).
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
        Console.WriteLine("   SALBUESPENAK - PROBA AUTOMATIKOAK");
        Console.WriteLine("==============================================");

        Ariketa("1. ZenbakiaEdoZero");
        Kasua("ZenbakiaEdoZero(\"42\")", () => ZenbakiaEdoZero("42"), 42);
        Kasua("ZenbakiaEdoZero(\"-7\")", () => ZenbakiaEdoZero("-7"), -7);
        Kasua("ZenbakiaEdoZero(\"abc\")", () => ZenbakiaEdoZero("abc"), 0);
        Kasua("ZenbakiaEdoZero(\"\") testu hutsa", () => ZenbakiaEdoZero(""), 0);
        Kasua("ZenbakiaEdoZero(\"3.5\") hamartarra", () => ZenbakiaEdoZero("3.5"), 0);
        AriketaAmaitu(false);

        Ariketa("2. ZatiketaSegurua");
        Kasua("ZatiketaSegurua(10, 2)", () => ZatiketaSegurua(10, 2), 5);
        Kasua("ZatiketaSegurua(-9, 3)", () => ZatiketaSegurua(-9, 3), -3);
        Kasua("ZatiketaSegurua(7, 0) zeroz zatitu", () => ZatiketaSegurua(7, 0), 0);
        Kasua("ZatiketaSegurua(0, 5)", () => ZatiketaSegurua(0, 5), 0);
        AriketaAmaitu(false);

        Ariketa("3. ElementuaLortu");
        int[] z = { 10, 20, 30 };
        Kasua("ElementuaLortu({10, 20, 30}, 1)", () => ElementuaLortu(z, 1), 20);
        Kasua("ElementuaLortu({10, 20, 30}, 0)", () => ElementuaLortu(z, 0), 10);
        Kasua("ElementuaLortu({10, 20, 30}, 2) azkena", () => ElementuaLortu(z, 2), 30);
        Kasua("ElementuaLortu({10, 20, 30}, 3) kanpoan", () => ElementuaLortu(z, 3), -1);
        Kasua("ElementuaLortu({10, 20, 30}, -1) negatiboa", () => ElementuaLortu(z, -1), -1);
        AriketaAmaitu(false);

        Ariketa("4. ErroreMota");
        Kasua("ErroreMota(\"12\")", () => ErroreMota("12"), "OK");
        Kasua("ErroreMota(\"kaixo\")", () => ErroreMota("kaixo"), "FormatException");
        Kasua("ErroreMota(\"\")", () => ErroreMota(""), "FormatException");
        Kasua("ErroreMota(\"99999999999\") handiegia", () => ErroreMota("99999999999"), "OverflowException");
        AriketaAmaitu(false);

        Ariketa("5. BaliozkoakBatu");
        Kasua("BaliozkoakBatu({\"10\", \"abc\", \"5\"})", () => BaliozkoakBatu(new[] { "10", "abc", "5" }), 15);
        Kasua("BaliozkoakBatu({\"-3\", \"3\", \"7\"})", () => BaliozkoakBatu(new[] { "-3", "3", "7" }), 7);
        Kasua("BaliozkoakBatu({\"x\", \"y\"}) baliogabeak", () => BaliozkoakBatu(new[] { "x", "y" }), 0);
        Kasua("BaliozkoakBatu({\"abc\", \"20\"}) lehena gaizki", () => BaliozkoakBatu(new[] { "abc", "20" }), 20);
        Kasua("BaliozkoakBatu({}) array hutsa", () => BaliozkoakBatu(new string[0]), 0);
        AriketaAmaitu(false);

        Ariketa("6. ErosketaEgin");
        Kasua("ErosketaEgin(100, 30)", () => ErosketaEgin(100, 30), 70);
        Kasua("ErosketaEgin(50, 50)", () => ErosketaEgin(50, 50), 0);
        KasuaSalbuespena("ErosketaEgin(20, 30) urre gutxi", () => ErosketaEgin(20, 30), "ArgumentException");
        KasuaSalbuespena("ErosketaEgin(20, -5) prezio negatiboa", () => ErosketaEgin(20, -5), "ArgumentException");
        AriketaAmaitu(false);

        Ariketa("8. ERRONKA - ZenbakiaTartean (aukerakoa)");
        Kasua("ZenbakiaTartean(\"5\", 1, 10)", () => ZenbakiaTartean("5", 1, 10), 5);
        Kasua("ZenbakiaTartean(\"1\", 1, 10) muga", () => ZenbakiaTartean("1", 1, 10), 1);
        Kasua("ZenbakiaTartean(\"10\", 1, 10) muga", () => ZenbakiaTartean("10", 1, 10), 10);
        KasuaSalbuespena("ZenbakiaTartean(\"50\", 1, 10)", () => ZenbakiaTartean("50", 1, 10), "ArgumentOutOfRangeException");
        KasuaSalbuespena("ZenbakiaTartean(\"abc\", 1, 10)", () => ZenbakiaTartean("abc", 1, 10), "FormatException");
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
            Idatzi(ConsoleColor.Red, "  [ X  ] ", deskribapena + "  ->  harrapatu gabeko salbuespena: " + ex.GetType().Name);
        }
    }

    static void KasuaSalbuespena(string deskribapena, Action deia, string esperoMota)
    {
        try
        {
            deia();
            ariketaOndo = false;
            Idatzi(ConsoleColor.Red, "  [ X  ] ", deskribapena + "  ->  espero zen: " + esperoMota + "  |  zurea: ez da salbuespenik jaurti");
        }
        catch (NotImplementedException)
        {
            ariketaEginGabe = true;
            Idatzi(ConsoleColor.DarkGray, "  [ -- ] ", deskribapena + "  (egin gabe)");
        }
        catch (Exception ex)
        {
            string mota = ex.GetType().Name;
            if (mota == esperoMota)
            {
                Idatzi(ConsoleColor.Green, "  [ OK ] ", deskribapena + "  ->  " + mota + ": " + ex.Message);
            }
            else
            {
                ariketaOndo = false;
                Idatzi(ConsoleColor.Red, "  [ X  ] ", deskribapena + "  ->  espero zen: " + esperoMota + "  |  zurea: " + mota);
            }
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
