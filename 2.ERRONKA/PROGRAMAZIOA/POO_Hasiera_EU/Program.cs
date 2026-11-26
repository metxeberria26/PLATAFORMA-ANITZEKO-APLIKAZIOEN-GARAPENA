// =====================================================================
//  KLASEAK ETA OBJEKTUAK (POO) - MINECRAFT ETA GTA BILDUMA
//  Izena eta abizenak: Manex Etxeberria Uriarte
//  Data: 2026/11/26
// =====================================================================
//  NOLA LAN EGIN:
//   1. SAIOA (klaseak eta objektuak): 1-7 ariketak.
//   2. SAIOA (kapsulatzea, propietateak, static): 8-12 ariketak.
//   3. SAIOA (herentzia eta polimorfismoa): 13-16 ariketak (+17 erronka).
//   4. SAIOA (proiektua): 18. ariketa, GTA bilduma POOrekin.
//   - Metodo edo eraikitzaile bakoitzean, ezabatu
//     "throw new NotImplementedException();" lerroa eta idatzi zure kodea.
//   - Sakatu F5: programak zure klaseak probatzen ditu automatikoki:
//         [ OK ]  ondo dago
//         [ X  ]  emaitza okerra (espero zena eta zurea ikusiko dituzu)
//         [ -- ]  oraindik egin gabe
//   - Proba batek huts egiten badu: jarri eten-puntu bat (F9) zure
//     kodean eta erabili F10 / F11 pausoz pauso joateko.
//   - Klase guztiak fitxategi honetan daude (entrega errazteko).
//     Industrian, klase bakoitza bere fitxategian joaten da (Ezpata.cs...).
//   - EZ aldatu fitxategiaren amaierako "PROBA AUTOMATIKOAK" atala.
//   - Entrega: Program.cs fitxategi hau bakarrik, Moodleko zereginean.
// =====================================================================

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;

partial class Program   // "partial": klase hau bi zatitan dago (hemen eta fitxategiaren amaieran)
{
    static void Main()
    {
        // Lehenik, zure klaseen proba automatikoak exekutatzen dira:
        ProbakExekutatu();

        // Zure klaseak eskuz probatu nahi badituzu, hemen idatzi:
        // Jokalaria steve = new Jokalaria("Steve");
        // Console.WriteLine(steve.Bizitza);

        // 18. ariketa (proiektua) probatzeko, kendu iruzkina hurrengo lerroari:
        // GtaBilduma();
    }

    // =================================================================
    //  1. SAIOA - Programaren metodo estatikoak, objektuekin
    // =================================================================

    // 7. Erregenerazio-beacon bat: taldeko jokalari BIZI bakoitzari
    //    Bizitza = 20 (bizitza osoa). Hildakoak (Bizitza 0) ez dira sendatzen.
    //    Ez du ezer itzultzen (void): zergatik aldatzen dira, orduan,
    //    Main-eko objektuak? (pista: erreferentziak)
    static void TaldeaSendatu(Jokalaria[] taldea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =================================================================
    //  2. SAIOA - List<T> eta objektuak
    // =================================================================

    // 12. Zerrenda BERRI bat itzuli, bizirik dauden jokalariekin bakarrik.
    //     Jatorrizko zerrenda EZ aldatu.
    //     Adib.: {Steve 20, Alex 0, Herobrine 5} -> {Steve, Herobrine}
    static List<Jokalaria> BiziDirenak(List<Jokalaria> taldea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =================================================================
    //  3. SAIOA - Polimorfismoa
    // =================================================================

    // 16. Munstro guztien erasoen batura (gaueko arriskua). Munstro bakoitzak
    //     BERE Erasoa() erabiliko du (Hezurdura 3, Shulkerra 4...).
    //     DEBEKATUTA: if, switch, "is" edo GetType(). Polimorfismoa erabili!
    //     Adib.: {Hezurdura, Hezurdura, Shulkerra} -> 3 + 3 + 4 = 10
    static int TaldearenErasoa(Munstroa[] munstroak)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // =================================================================
    //  4. SAIOA - 18. ariketa: GTA BILDUMA, POOrekin
    // =================================================================

    // 18.a) Fitxategiko lerro bat (GTA ariketako formatua) Jokoa objektu
    //       bihurtu. true -> JokoNagusia, false -> SpinOff.
    //       "GTA San Andreas-Carl Johnson-GTASA_PS2-true-2004/10/26-45,50€"
    //       Pista: Split('-'), DateTime.ParseExact, decimal.Parse (es-ES).
    static Jokoa JokoaSortu(string lerroa)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 18.b) PROGRAMA (eskuz zuzenduko da). "jokoak.txt" (exe-aren ondoan):
    //   - Hasieran, kargatu jokoak List<Jokoa> batean (JokoaSortu erabiliz).
    //   - Menua (do-while + switch):
    //       1. Erakutsi joko guztiak (ToString erabiliz)
    //       2. Kalkulatu joko baten bilduma-balioa (kodearen bidez)
    //       3. Gehitu joko bat (kodea errepikatuta bada, ez gehitu)
    //       4. Ezabatu joko bat (kodearen bidez)
    //       0. Gorde (FitxategiLerroa erabiliz) eta irten
    //   - Konparatu zure GTA ariketa zaharrarekin (ikus enuntziatua).
    static void GtaBilduma()
    {
    }

    // Laguntzaileak (18. ariketarako; nahi baduzu erabili edo aldatu)
    static string Eskatu(string mezua)
    {
        Console.Write(mezua);
        return Console.ReadLine() ?? "";
    }

    static Jokoa? Bilatu(List<Jokoa> jokoak, string kodea)
    {
        foreach (Jokoa j in jokoak)
        {
            if (j.Kodea == kodea) return j;
        }
        return null;
    }
}

// #####################################################################
//  1. SAIOA - KLASEAK ETA OBJEKTUAK
// #####################################################################

// Klase honetan, atributuak public dira (oraingoz). 2. saioan ikusiko
// dugu zergatik den hobea private + propietateak.
class Ezpata
{
    public string Materiala;
    public int Kaltea;

    // 1. Eraikitzailea: parametroen balioak atributuetan gorde.
    //    Adib.: new Ezpata("Diamantea", 7) -> Materiala "Diamantea", Kaltea 7
    public Ezpata(string materiala, int kaltea)
    {
        Materiala = materiala;
        Kaltea = kaltea;
    }

    // 2. Ezpataren deskribapena itzuli.
    //    Adib.: Diamantea, 7 -> "Ezpata (Diamantea): 7 kalte"
    public string Deskribapena()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 17. ERRONKA (aukerakoa, +0.5): egin Ezpata klaseak IGordegarria
    //     interfazea inplementatu dezan (fitxategiaren amaieran dago).
    //     GordetzekoLerroa() -> "Diamantea;7"
}

class Jokalaria
{
    public string Izena;
    public int Bizitza;     // 20 = 10 bihotz
    public int Gosea;       // 20 = 10 izter (janari-barra beteta)

    // 3. Eraikitzailea: izena jaso. Bizitza 20 eta Gosea 20 hasieran.
    //    Adib.: new Jokalaria("Steve") -> Steve, 20, 20
    public Jokalaria(string izena)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 4. GAINKARGA: bigarren eraikitzailea, hasierako bizitzarekin.
    //    Gosea 20. Bizitza 1 eta 20 artean egon behar da:
    //    20 baino gehiago -> 20;  1 baino gutxiago -> 1.
    //    Adib.: ("Alex", 12) -> 12     ("Alex", 50) -> 20     ("Alex", -3) -> 1
    public Jokalaria(string izena, int bizitza)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 5.a) Kaltea jaso: bizitzari kendu. Bizitza ezin da 0 baino txikiagoa izan.
    //      Kalte negatiboa -> ez egin ezer.
    //      Adib.: 20 bizitza, JasoKaltea(6) -> 14     JasoKaltea(100) -> 0
    public void JasoKaltea(int kaltea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 5.b) Bizirik dagoen: Bizitza > 0
    public bool BiziDa()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 6. Beste jokalari bati eraso (PvP), ezpata batekin.
    //    Kaltea = ezpataren kaltea. Baina erasotzaileak GOSE badu
    //    (Gosea 6 baino gutxiago), ahul dago: kaltearen ERDIA (zatiketa osoa).
    //    Helburuak JasoKaltea erabiliz jasotzen du (ez kendu zuzenean!).
    //    Egindako kaltea itzuli. Erasotzailea hilda badago -> 0 (ez du erasotzen).
    //    Adib.: Steve Diamantea(7)-rekin Alex-i -> Alex-ek 7 galtzen ditu, 7 itzuli
    //           Steve-ren Gosea 4 bada -> 3
    public int Erasotu(Jokalaria helburua, Ezpata ezpata)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 11. (2. saioa) ToString() GAINIDATZI (override), objektua testu gisa
    //     erakusteko. Console.WriteLine(j)-k automatikoki erabiltzen du.
    //     Adib.: "Steve [20 HP, gosea 20]"
    public override string ToString()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }
}

// #####################################################################
//  2. SAIOA - KAPSULATZEA, PROPIETATEAK ETA STATIC
// #####################################################################

// 8. Esperientzia (XP). Puntuak PRIBATUAK dira: kanpotik ezin dira zuzenean
//    aldatu (cheat-ik ez!).
//    - Puntuak propietatea: irakurri bakarrik (get), ez set publikorik.
//    - Irabazi(kantitatea): negatiboa bada -> ArgumentException jaurti.
//    - Gastatu(kantitatea) (adib. sorginketa-mahaian): nahikoa puntu badago,
//      kendu eta true; bestela, ez kendu ezer eta false.
//    Adib.: XP hutsa, Irabazi(50), Gastatu(30) -> true, Puntuak 20
//           Gastatu(100) -> false, Puntuak 20 jarraitzen du
class Esperientzia
{
    private int puntuak;    // atributu PRIBATUA (letra xehez)

    public int Puntuak      // propietate PUBLIKOA (letra larriz), irakurtzeko bakarrik
    {
        get
        {
            throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
        }
    }

    public void Irabazi(int kantitatea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public bool Gastatu(int kantitatea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }
}

// 9. Jokoaren ezarpenak. Fov (Field of View, ikus-eremua graduetan)
//    propietateak balioa ZUZENTZEN du set-ean:
//    30 baino txikiagoa -> 30;  110 baino handiagoa -> 110.
//    Izena: propietate automatikoa (get; private set;). Eraikitzaileak jartzen du.
//    Eraikitzailea: izena jaso; Fov hasieran 70 (Minecraft-en lehenetsia).
//    Adib.: e.Fov = 150 -> 110     e.Fov = 10 -> 30     e.Fov = 90 -> 90
class Ezarpenak
{
    private int fov;

    public string Izena { get; private set; }

    public Ezarpenak(string izena)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public int Fov
    {
        get
        {
            throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
        }
        set
        {
            throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
        }
    }
}

// 10. STATIC: mundu bakoitzak zenbaki bat jasotzen du sortzean (1, 2, 3...).
//     Kopurua: zenbat mundu sortu diren GUZTIRA (static: klasearena,
//     ez objektu bakoitzarena). Zenbakia: mundu BAKOITZARENA.
//     Eraikitzaileak: Kopurua 1 handitu, eta Zenbakia = Kopurua.
//     Adib.: lehena -> Zenbakia 1, bigarrena -> Zenbakia 2, Kopurua 2
class Mundua
{
    public static int Kopurua = 0;

    public string Izena { get; }
    public int Zenbakia { get; }

    public Mundua(string izena)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }
}

// #####################################################################
//  3. SAIOA - HERENTZIA ETA POLIMORFISMOA
// #####################################################################

// 13. Oinarrizko klasea (superklasea). ABSTRAKTUA: ezin da "new Munstroa" egin.
//     - Eraikitzailea: izena eta bizitza gorde.
//     - JasoKaltea (virtual): bizitza kendu, 0 azpitik inoiz ez.
//     - Erasoa (virtual): 2 itzuli (munstro arrunt baten erasoa).
//     - Soinua (abstract): azpiklase bakoitzak idatzi BEHAR du.
abstract class Munstroa
{
    public string Izena { get; }
    protected int bizitza;          // protected: Munstroa eta bere azpiklaseak bakarrik

    public int Bizitza
    {
        get { return bizitza; }
    }

    public Munstroa(string izena, int bizitza)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public virtual void JasoKaltea(int kaltea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public virtual int Erasoa()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public abstract string Soinua();
}

// 14. Hezurdura (eskeletoa): 20 bizitzarekin sortzen da beti. Erasoa 3 (gezia).
//     Soinua "Klak klak!".
//     Pista: eraikitzailean ": base(izena, 20)"
class Hezurdura : Munstroa
{
    public Hezurdura(string izena) : base(izena, 20)
    {
        // Ez da ezer gehiago behar: base-k egiten du lana
    }

    public override int Erasoa()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public override string Soinua()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }
}

// 15. Shulkerra: 30 bizitza. Erasoa 4. Soinua "Klonk!".
//     Oskola: kaltearen ERDIA bakarrik jasotzen du (zatiketa osoa: 25 -> 12).
//     Pista: JasoKaltea gainidatzi eta base.JasoKaltea(kaltea / 2) deitu.
class Shulkerra : Munstroa
{
    public Shulkerra(string izena) : base(izena, 30)
    {
        // Ez da ezer gehiago behar: base-k egiten du lana
    }

    public override void JasoKaltea(int kaltea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public override int Erasoa()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public override string Soinua()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }
}

// 17. ERRONKA: interfazea. Kontratu bat: "inplementatzen nauenak metodo
//     hau izan BEHAR du". Ez aldatu interfazea; egin Ezpata-k inplementatzea.
interface IGordegarria
{
    string GordetzekoLerroa();
}

// #####################################################################
//  4. SAIOA - 18. ARIKETA: GTA BILDUMA
// #####################################################################

// 18. Jokoa: klase abstraktua. Ezaugarri guztiak propietateak (get bakarrik).
abstract class Jokoa
{
    public string Izenburua { get; }
    public string Protagonista { get; }
    public string Kodea { get; }
    public DateTime Data { get; }
    public decimal OinarriBalioa { get; }

    // 18.c) Eraikitzailea: parametro guztiak propietateetan gorde.
    public Jokoa(string izenburua, string protagonista, string kodea, DateTime data, decimal oinarriBalioa)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // Azpiklase bakoitzak bere balioa ematen du (abstract).
    public abstract decimal UrtekoGehikuntza();
    public abstract bool Nagusia();

    // 18.d) balioa = (urtea - argitaratze-urtea) * UrtekoGehikuntza() + OinarriBalioa
    //       Adib.: San Andreas, 2026 -> 22 * 3,00 + 45,50 = 111,50
    public decimal BildumaBalioa(int urtea)
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 18.e) Objektua fitxategiko lerro bihurtu (JokoaSortu-ren alderantzizkoa).
    //       "GTA San Andreas-Carl Johnson-GTASA_PS2-true-2004/10/26-45,50€"
    //       Pista: Data.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
    //              OinarriBalioa.ToString("0.00", new CultureInfo("es-ES"))
    public string FitxategiLerroa()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    // 18.f) ToString: zuk aukeratu formatua (ez da automatikoki probatzen).
    //       Adib.: "[GTASA_PS2] GTA San Andreas (2004) - Carl Johnson"
    public override string ToString()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }
}

// 18.g) Saga nagusiko jokoak: urteko 3,00. Nagusia() -> true
class JokoNagusia : Jokoa
{
    public JokoNagusia(string izenburua, string protagonista, string kodea, DateTime data, decimal oinarriBalioa)
        : base(izenburua, protagonista, kodea, data, oinarriBalioa)
    {
    }

    public override decimal UrtekoGehikuntza()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public override bool Nagusia()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }
}

// 18.h) Spin-off-ak: urteko 1,50. Nagusia() -> false
class SpinOff : Jokoa
{
    public SpinOff(string izenburua, string protagonista, string kodea, DateTime data, decimal oinarriBalioa)
        : base(izenburua, protagonista, kodea, data, oinarriBalioa)
    {
    }

    public override decimal UrtekoGehikuntza()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }

    public override bool Nagusia()
    {
        throw new NotImplementedException(); // <- ezabatu lerro hau eta idatzi zure kodea
    }
}

// =====================================================================
// =====================================================================
//  PROBA AUTOMATIKOAK - EZ ALDATU HEMENDIK BEHERA
//  Irakasleak prestatutako kodea. Ez duzu dena ulertu behar
//  ("=>", "Func" eta "typeof" aurrerago ikasiko ditugu).
// =====================================================================
// =====================================================================

partial class Program
{
    static int ariketaOnak = 0;
    static int ariketaKopurua = 0;
    static bool ariketaOndo = true;
    static bool ariketaEginGabe = false;
    static bool erronkaOndo = false;

    static void ProbakExekutatu()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("   KLASEAK ETA OBJEKTUAK - PROBA AUTOMATIKOAK");
        Console.WriteLine("==============================================");

        Console.WriteLine();
        Console.WriteLine("---------- 1. SAIOA: KLASEAK ETA OBJEKTUAK ----------");

        Ariketa("1. Ezpata - eraikitzailea");
        Kasua("new Ezpata(\"Diamantea\", 7).Materiala", () => new Ezpata("Diamantea", 7).Materiala, "Diamantea");
        Kasua("new Ezpata(\"Diamantea\", 7).Kaltea", () => new Ezpata("Diamantea", 7).Kaltea, 7);
        AriketaAmaitu(false);

        Ariketa("2. Ezpata.Deskribapena");
        Kasua("Diamantea, 7", () => new Ezpata("Diamantea", 7).Deskribapena(), "Ezpata (Diamantea): 7 kalte");
        Kasua("Egurra, 4", () => new Ezpata("Egurra", 4).Deskribapena(), "Ezpata (Egurra): 4 kalte");
        AriketaAmaitu(false);

        Ariketa("3. Jokalaria(izena)");
        Kasua("new Jokalaria(\"Steve\").Izena", () => new Jokalaria("Steve").Izena, "Steve");
        Kasua("new Jokalaria(\"Steve\").Bizitza", () => new Jokalaria("Steve").Bizitza, 20);
        Kasua("new Jokalaria(\"Steve\").Gosea", () => new Jokalaria("Steve").Gosea, 20);
        AriketaAmaitu(false);

        Ariketa("4. Jokalaria(izena, bizitza) - gainkarga");
        Kasua("(\"Alex\", 12).Bizitza", () => new Jokalaria("Alex", 12).Bizitza, 12);
        Kasua("(\"Alex\", 50).Bizitza -> 20", () => new Jokalaria("Alex", 50).Bizitza, 20);
        Kasua("(\"Alex\", -3).Bizitza -> 1", () => new Jokalaria("Alex", -3).Bizitza, 1);
        Kasua("(\"Alex\", 12).Gosea", () => new Jokalaria("Alex", 12).Gosea, 20);
        AriketaAmaitu(false);

        Ariketa("5. JasoKaltea eta BiziDa");
        Kasua("20 - 6", () => { Jokalaria j = new Jokalaria("Steve"); j.JasoKaltea(6); return j.Bizitza; }, 14);
        Kasua("20 - 100 -> 0", () => { Jokalaria j = new Jokalaria("Steve"); j.JasoKaltea(100); return j.Bizitza; }, 0);
        Kasua("kalte negatiboa -> ezer ez", () => { Jokalaria j = new Jokalaria("Steve"); j.JasoKaltea(-10); return j.Bizitza; }, 20);
        Kasua("BiziDa() hasieran", () => new Jokalaria("Steve").BiziDa(), true);
        Kasua("BiziDa() 0 bizitzarekin", () => { Jokalaria j = new Jokalaria("Steve"); j.JasoKaltea(20); return j.BiziDa(); }, false);
        AriketaAmaitu(false);

        Ariketa("6. Erasotu (PvP)");
        Kasua("Steve -> Alex, Diamantea(7): itzulitako kaltea", () => new Jokalaria("Steve").Erasotu(new Jokalaria("Alex"), new Ezpata("Diamantea", 7)), 7);
        Kasua("Alex-en bizitza ondoren", () => { Jokalaria alex = new Jokalaria("Alex"); new Jokalaria("Steve").Erasotu(alex, new Ezpata("Diamantea", 7)); return alex.Bizitza; }, 13);
        Kasua("Steve-ren bizitza ez da aldatzen", () => { Jokalaria steve = new Jokalaria("Steve"); steve.Erasotu(new Jokalaria("Alex"), new Ezpata("Diamantea", 7)); return steve.Bizitza; }, 20);
        Kasua("Gosea 4 -> 7 / 2 = 3", () => { Jokalaria steve = new Jokalaria("Steve"); steve.Gosea = 4; return steve.Erasotu(new Jokalaria("Alex"), new Ezpata("Diamantea", 7)); }, 3);
        Kasua("Gosea 6 -> ez dago gose (7)", () => { Jokalaria steve = new Jokalaria("Steve"); steve.Gosea = 6; return steve.Erasotu(new Jokalaria("Alex"), new Ezpata("Diamantea", 7)); }, 7);
        Kasua("Erasotzailea hilda -> 0", () => { Jokalaria steve = new Jokalaria("Steve"); steve.JasoKaltea(20); return steve.Erasotu(new Jokalaria("Alex"), new Ezpata("Diamantea", 7)); }, 0);
        AriketaAmaitu(false);

        Ariketa("7. TaldeaSendatu (erreferentziak)");
        Kasua("{Steve 8, Alex 0, Herobrine 19} -> bizitzak", () =>
        {
            Jokalaria s = new Jokalaria("Steve"); s.JasoKaltea(12);
            Jokalaria a = new Jokalaria("Alex"); a.JasoKaltea(20);
            Jokalaria h = new Jokalaria("Herobrine"); h.JasoKaltea(1);
            TaldeaSendatu(new[] { s, a, h });
            return new[] { s.Bizitza, a.Bizitza, h.Bizitza };
        }, new[] { 20, 0, 20 });
        AriketaAmaitu(false);

        Console.WriteLine();
        Console.WriteLine("---------- 2. SAIOA: KAPSULATZEA, PROPIETATEAK, STATIC ----------");

        Ariketa("8. Esperientzia (kapsulatzea)");
        Kasua("ez du atributu publikorik", () => typeof(Esperientzia).GetFields(BindingFlags.Public | BindingFlags.Instance).Length, 0);
        Kasua("Puntuak-ek ez du set publikorik", () => { PropertyInfo? pi = typeof(Esperientzia).GetProperty("Puntuak"); return pi != null && pi.GetSetMethod() == null; }, true);
        Kasua("XP berria -> 0", () => new Esperientzia().Puntuak, 0);
        Kasua("Irabazi(50), Gastatu(30) -> true", () => { Esperientzia x = new Esperientzia(); x.Irabazi(50); return x.Gastatu(30); }, true);
        Kasua("Irabazi(50), Gastatu(30) -> Puntuak", () => { Esperientzia x = new Esperientzia(); x.Irabazi(50); x.Gastatu(30); return x.Puntuak; }, 20);
        Kasua("Gastatu(100) 20rekin -> false", () => { Esperientzia x = new Esperientzia(); x.Irabazi(20); return x.Gastatu(100); }, false);
        Kasua("Gastatu(100) 20rekin -> Puntuak 20", () => { Esperientzia x = new Esperientzia(); x.Irabazi(20); x.Gastatu(100); return x.Puntuak; }, 20);
        Kasua("Irabazi(-5) -> ArgumentException", () => { try { new Esperientzia().Irabazi(-5); return "ez da jaurti"; } catch (ArgumentException) { return "ArgumentException"; } }, "ArgumentException");
        AriketaAmaitu(false);

        Ariketa("9. Ezarpenak (propietatea balidazioarekin)");
        Kasua("Izena", () => new Ezarpenak("Steve").Izena, "Steve");
        Kasua("Fov hasieran", () => new Ezarpenak("Steve").Fov, 70);
        Kasua("Fov = 90", () => { Ezarpenak e = new Ezarpenak("Steve"); e.Fov = 90; return e.Fov; }, 90);
        Kasua("Fov = 150 -> 110", () => { Ezarpenak e = new Ezarpenak("Steve"); e.Fov = 150; return e.Fov; }, 110);
        Kasua("Fov = 10 -> 30", () => { Ezarpenak e = new Ezarpenak("Steve"); e.Fov = 10; return e.Fov; }, 30);
        Kasua("Izena-k ez du set publikorik", () => { PropertyInfo? pi = typeof(Ezarpenak).GetProperty("Izena"); return pi != null && pi.GetSetMethod() == null; }, true);
        AriketaAmaitu(false);

        Ariketa("10. Mundua (static)");
        Kasua("bi mundu: zenbakiak jarraian", () => { Mundua a = new Mundua("Biziraupena"); Mundua b = new Mundua("Sormena"); return b.Zenbakia - a.Zenbakia; }, 1);
        Kasua("Kopurua 2 handitzen da", () => { int lehen = Mundua.Kopurua; new Mundua("A"); new Mundua("B"); return Mundua.Kopurua - lehen; }, 2);
        Kasua("azkenaren Zenbakia == Kopurua", () => { Mundua a = new Mundua("Hardcore"); return a.Zenbakia == Mundua.Kopurua; }, true);
        Kasua("Izena", () => new Mundua("Skyblock").Izena, "Skyblock");
        AriketaAmaitu(false);

        Ariketa("11. Jokalaria.ToString (override)");
        Kasua("Steve", () => new Jokalaria("Steve").ToString(), "Steve [20 HP, gosea 20]");
        Kasua("Alex, 8", () => new Jokalaria("Alex", 8).ToString(), "Alex [8 HP, gosea 20]");
        AriketaAmaitu(false);

        Ariketa("12. BiziDirenak (List<T>)");
        Kasua("{Steve 20, Alex 0, Herobrine 5} -> izenak", () =>
        {
            Jokalaria a = new Jokalaria("Alex"); a.JasoKaltea(20);
            List<Jokalaria> t = new List<Jokalaria> { new Jokalaria("Steve"), a, new Jokalaria("Herobrine", 5) };
            List<Jokalaria> b = BiziDirenak(t);
            string[] izenak = new string[b.Count];
            for (int i = 0; i < b.Count; i++) izenak[i] = b[i].Izena;
            return izenak;
        }, new[] { "Steve", "Herobrine" });
        Kasua("jatorrizkoa ez da aldatzen (Count)", () =>
        {
            Jokalaria a = new Jokalaria("Alex"); a.JasoKaltea(20);
            List<Jokalaria> t = new List<Jokalaria> { new Jokalaria("Steve"), a };
            BiziDirenak(t);
            return t.Count;
        }, 2);
        Kasua("zerrenda hutsa", () => BiziDirenak(new List<Jokalaria>()).Count, 0);
        AriketaAmaitu(false);

        Console.WriteLine();
        Console.WriteLine("---------- 3. SAIOA: HERENTZIA ETA POLIMORFISMOA ----------");

        Ariketa("13. Munstroa (oinarrizko klasea)");
        Kasua("Munstroa abstraktua da", () => typeof(Munstroa).IsAbstract, true);
        Kasua("Hezurdura \"Bonny\": Izena (base)", () => new Hezurdura("Bonny").Izena, "Bonny");
        Kasua("Hezurdura: JasoKaltea(6) -> 14", () => { Munstroa m = new Hezurdura("B"); m.JasoKaltea(6); return m.Bizitza; }, 14);
        Kasua("Hezurdura: JasoKaltea(999) -> 0", () => { Munstroa m = new Hezurdura("B"); m.JasoKaltea(999); return m.Bizitza; }, 0);
        AriketaAmaitu(false);

        Ariketa("14. Hezurdura");
        Kasua("Bizitza 20", () => new Hezurdura("B").Bizitza, 20);
        Kasua("Erasoa() 3", () => new Hezurdura("B").Erasoa(), 3);
        Kasua("Soinua()", () => new Hezurdura("B").Soinua(), "Klak klak!");
        AriketaAmaitu(false);

        Ariketa("15. Shulkerra");
        Kasua("Bizitza 30", () => new Shulkerra("Kutxa").Bizitza, 30);
        Kasua("Erasoa() 4", () => new Shulkerra("Kutxa").Erasoa(), 4);
        Kasua("Soinua()", () => new Shulkerra("Kutxa").Soinua(), "Klonk!");
        Kasua("JasoKaltea(25) -> 30 - 12", () => { Munstroa s = new Shulkerra("Kutxa"); s.JasoKaltea(25); return s.Bizitza; }, 18);
        Kasua("JasoKaltea(1000) -> 0", () => { Munstroa s = new Shulkerra("Kutxa"); s.JasoKaltea(1000); return s.Bizitza; }, 0);
        AriketaAmaitu(false);

        Ariketa("16. TaldearenErasoa (polimorfismoa)");
        Kasua("{Hezurdura, Hezurdura, Shulkerra} -> 10", () => TaldearenErasoa(new Munstroa[] { new Hezurdura("A"), new Hezurdura("B"), new Shulkerra("C") }), 10);
        Kasua("{} -> 0", () => TaldearenErasoa(new Munstroa[0]), 0);
        AriketaAmaitu(false);

        Ariketa("17. ERRONKA - IGordegarria (aukerakoa)");
        Kasua("Ezpata-k IGordegarria inplementatzen du", () => typeof(IGordegarria).IsAssignableFrom(typeof(Ezpata)), true);
        Kasua("GordetzekoLerroa()", () =>
        {
            object o = new Ezpata("Diamantea", 7);
            if (o is IGordegarria g) return g.GordetzekoLerroa();
            return "(ez du inplementatzen)";
        }, "Diamantea;7");
        AriketaAmaitu(true);

        Console.WriteLine();
        Console.WriteLine("---------- 4. SAIOA: GTA BILDUMA ----------");

        string sa = "GTA San Andreas-Carl Johnson-GTASA_PS2-true-2004/10/26-45,50€";
        string lcs = "GTA Liberty City Stories-Toni Cipriani-GTALCS_PSP-false-2005/10/24-12,30€";

        Ariketa("18. Jokoa, JokoNagusia, SpinOff eta JokoaSortu");
        Kasua("JokoaSortu(San Andreas) -> JokoNagusia", () => JokoaSortu(sa) is JokoNagusia, true);
        Kasua("JokoaSortu(LCS) -> SpinOff", () => JokoaSortu(lcs) is SpinOff, true);
        Kasua("Kodea", () => JokoaSortu(sa).Kodea, "GTASA_PS2");
        Kasua("Protagonista", () => JokoaSortu(sa).Protagonista, "Carl Johnson");
        Kasua("Data.Year", () => JokoaSortu(sa).Data.Year, 2004);
        Kasua("San Andreas, BildumaBalioa(2026)", () => JokoaSortu(sa).BildumaBalioa(2026), 111.50m);
        Kasua("LCS, BildumaBalioa(2026)", () => JokoaSortu(lcs).BildumaBalioa(2026), 43.80m);
        Kasua("FitxategiLerroa() (joan-etorria)", () => JokoaSortu(sa).FitxategiLerroa(), sa);
        Kasua("FitxategiLerroa() spin-off", () => JokoaSortu(lcs).FitxategiLerroa(), lcs);
        AriketaAmaitu(false);

        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine($"   Ariketak ondo: {ariketaOnak} / {ariketaKopurua}");
        if (erronkaOndo)
        {
            Console.WriteLine("   Erronka: EGINDA! (+0.5)");
        }
        Console.WriteLine("==============================================");
        Console.WriteLine("   Gogoratu: probak gainditzea ez da dena.");
        Console.WriteLine("   18. ariketako menua eskuz zuzenduko da.");
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
        if (o is decimal d) return d.ToString("0.00", CultureInfo.InvariantCulture);
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
