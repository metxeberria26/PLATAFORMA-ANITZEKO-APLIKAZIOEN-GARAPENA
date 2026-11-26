using System.ComponentModel.Design;
using System.Diagnostics.Tracing;

namespace HasieraHutsik
{
    public class KaraktereKateak
    {
        public static void Exekutatu()
        {
            Console.WriteLine("***** KARAKTERE KATEAK ***********");
            Console.Write("Zenbatgarren ariketa nahi duzun egin? Sartu 1-tik 7-ra zenbaki bat:");
            int eragiketa = int.Parse(Console.ReadLine());
            switch (eragiketa)
            {
                case 1:
                    KaraktereKate1();
                    break;
                case 2:
                    KaraktereKate2();
                    break;
                case 3:
                    KaraktereKate3();
                    break;
                case 4:
                    KaraktereKate4();
                    break;
                case 5:
                    KaraktereKate5();
                    break;
                case 6:
                    KaraktereKate6();
                    break;
                case 7:
                    KaraktereKate7();
                    break;
                default:
                    Console.WriteLine("Eragiketa desegokia");
                    break;
            }
        }
        static void KaraktereKate1()
        {
            int kontadorea1 = 0;
            int kontadorea2 = 0;
            Console.WriteLine("sartu hitz bat");
            string hitz = Console.ReadLine();
            Console.WriteLine("sartu beste hitz bat");
            string besteHitz = Console.ReadLine();
            foreach (char c in hitz)
            {
                kontadorea1++;

            }
            foreach (char c in besteHitz)
            {
                kontadorea2++;
            }

            Console.WriteLine(hitz + " hitzaren hitz kopurua: " + kontadorea1);
            Console.WriteLine(besteHitz + " hitzaren hitz kopurua: " + kontadorea2);
            if (kontadorea1 > kontadorea2)
            {
                Console.WriteLine(hitz + " hitza luzeagoa da");
            }
            else if (kontadorea1 < kontadorea2)
            {
                Console.WriteLine(besteHitz + " hitza luzeagoa da");
            }
            else
            {
                Console.WriteLine("Bi hitzak hitz kopuru berdina dute");
            }


        }
        static void KaraktereKate2()
        {
            int kontadorea = 0;
            Console.WriteLine("sartu esaldi bat");
            string esaldia = Console.ReadLine();
            foreach (char c in esaldia)
            {
                if (c == ' ')
                {
                    kontadorea++;
                }
            }
            Console.WriteLine("Esaldiak " + kontadorea + " hutsune ditu");
        }
        static void KaraktereKate3()
        {
            string hitz1 = Console.ReadLine();
            Console.WriteLine("sartu hitz bat");
            string hitz = Console.ReadLine();
            foreach (char c in hitz)
            {
                hitz1 = c + hitz1;
            }
            Console.WriteLine("Hitza alderantziz: " + hitz1);
        }
        static void KaraktereKate4()
        {
            Console.WriteLine("sartu izen abizenak");
            string izenAbizenak = Console.ReadLine();
            foreach (char c in izenAbizenak)
            {
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')

                    Console.WriteLine(c.ToString().ToUpper());



            }
        }
        static void KaraktereKate5()
        {
            int kontadorea = 0;
            Console.WriteLine("sartu zure esaldia");
            string esaldia = Console.ReadLine();
            Console.WriteLine("esan zer hizki nahi duzun bilatu");
            char hizki = char.Parse(Console.ReadLine());
            foreach (char c in esaldia)
            {
                if (c == hizki)
                {
                    kontadorea++;
                }
            }
            Console.WriteLine(kontadorea);
        }
        static void KaraktereKate6()
        {
            Console.Write("Sartu hitz bat: ");
            string hitza = Console.ReadLine();

            Console.Write("Zenbat letra nahi dituzu talde bakoitzean? ");
            int n = int.Parse(Console.ReadLine());

            string zatia = "";
            int kontadorea = 0;

            foreach (char letra in hitza)
            {
                zatia = zatia + letra;
                kontadorea++;

                if (kontadorea == n)
                {
                    Console.WriteLine(zatia);
                    zatia = "";
                    kontadorea = 0;
                }
            }

            if (zatia != "")
            {
                Console.WriteLine(zatia);

            }
        }
        static void KaraktereKate7()
        {
            string izena;
            string hizkia;
            int kopurua = 0;

            Console.WriteLine("Sartu izen bat:");
            izena = Console.ReadLine();

            Console.WriteLine("Sartu hizki bat:");
            hizkia = Console.ReadLine();

            foreach (char letra in izena)
            {
                if (letra.ToString() == hizkia)
                {
                    kopurua++;
                }
            }

            if (kopurua > 0)
            {
                Console.WriteLine("BAI");
                Console.WriteLine("Hizkia " + kopurua + " aldiz agertzen da.");
            }
            else
            {
                Console.WriteLine("EZ");
            }
        }


    }
}
        
   

