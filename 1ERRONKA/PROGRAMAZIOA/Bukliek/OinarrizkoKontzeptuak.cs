namespace HasieraHutsik
{
    public class OinarrizkoKontzeptuak
    {
        public static void Exekutatu()
        {
            //hau switchetan sartu
            Console.WriteLine("***** OINARRIZKO ERAGIKETAK LANTZEN ***********");
            Console.WriteLine("1.- Adina eskatu eta hurrengo urteko adina erakutsi");
            Console.WriteLine("2.- Bi zenbaki osoren batazbestekoa kalkulatu");
            Console.WriteLine("3.- Bikoitia den edo ez adierazi");
            Console.WriteLine("4.- BEZaren kalkulua");
            Console.WriteLine("5.- 7ren multiploa");
            Console.WriteLine("6.- Triangeluaren azalera kalkulatu");
            Console.WriteLine("7.- Bigarren mailako ekuazioa askatu");
            Console.WriteLine("8.- Jolas parkea kudeatzen");
            Console.WriteLine("9.- Zenbaki handiena");
            Console.WriteLine("10.- BUELTATU");
            Console.Write("Ze ariketa nahi duzun egin? Sartu bere zenbakia:");
            int eragiketa = int.Parse(Console.ReadLine());
            switch (eragiketa)
            {
                case 1:
                    Console.WriteLine("***** ADINAREN KALKULUA *****");
                    Ariketa1();
                    break;
                case 2:
                    Console.WriteLine("***** BI ZENBAKI OSOREN BATAZBESTEKOA *****");
                    Ariketa2();
                    break;
                case 3:
                    Console.WriteLine("***** BIKOITIA OTE DEN JAKITEA *****");
                    Ariketa3();
                    break;
                case 4:
                    Console.WriteLine("***** BEZaren KALKULUA *****");
                    Ariketa4();
                    break;
                case 5:
                    Console.WriteLine(" *****7-ren MULTIPLOA *****");
                    Ariketa5();
                    break;
                case 6:
                    Console.WriteLine(" *****TRAINGELUAREN AZALERA *****");
                    Ariketa6();
                    break;
                case 7:
                    Console.WriteLine(" *****BIGARREN MAILAKO EKUAZIOA *****");
                    Ariketa7();
                    break;
                case 8:
                    Console.WriteLine(" *****JOLAS PARKEA KUDEATZEN *****");
                    Ariketa8();
                    break;
                case 9:
                    Console.WriteLine(" *****ZENBAKI HANDIENA *****");
                    Ariketa9();
                    break;
                case 10:
                    return;
                default:
                    Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                    break;
            }
        }
        static void Ariketa1()
        {
          
        }
        static void Ariketa2()
        {
          
        }
        static void Ariketa3()
        {
            
        }
        static void Ariketa4()
        {
            
        }
        static void Ariketa5()
        {
            
        }
        static void Ariketa6()
        {
           
        }
        static void Ariketa7()
        {
           
        }
        static void Ariketa8()
        {
           
        }
        static void Ariketa9()
        {
           
        }
    }
}
