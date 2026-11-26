using System.ComponentModel.Design;

namespace HasieraHutsik
{
    public class OinarrizkoKontzeptuak
    {

        public static void Main()   
        {
            //hau switchetan sartu
            Console.WriteLine("***** OINARRIZKO ERAGIKETAK LANTZEN ***********");
            Console.WriteLine("1.- Kaixo Mundua idatziko du");
            Console.WriteLine("2.- Zenbaki osoa sartu eta hurrengo urteko adina erakutsi");
            Console.WriteLine("3.- Bataz bestekoa kalkulatu");
            Console.WriteLine("4.- Bikoitia den edo ez adierazi");
            Console.WriteLine("5.- BEZ-aren kalkulua");
            Console.WriteLine("6.- 7-ren multiplos");
            Console.WriteLine("7.- Triangeluaren azalera kalkulatu");
            Console.WriteLine("8.- Bigarren mailako ekuazioa");
            Console.WriteLine("9.- Jolas parkea kudeatzen");
            Console.WriteLine("10.-zenbaki handiena ");
            Console.Write("Ze ariketa nahi duzun egin? Sartu bere zenbakia:");
            int eragiketa = int.Parse(Console.ReadLine());
            switch (eragiketa)
            {
                case 1:
                    Console.WriteLine("***** KAIXO MUNDUA *****");
                    Ariketa1();


                    break;
                case 2:
                    Console.WriteLine("***** ADINAREN KALKULUA *****");
                    Ariketa2();


                    break;
                case 3:
                    Console.WriteLine("***** BATAZ BESTEKOA *****");
                    Ariketa3();

                    break;
                case 4:
                    Console.WriteLine("***** BIKOITIA EDO BAKOITIA *****");
                    Ariketa4();

                    break;
                case 5:
                    Console.WriteLine(" *****BEZ-aren kalkulua *****");
                    Ariketa5();


                    break;
                case 6:
                    Console.WriteLine(" *****7-ren multiploa *****");
                    Ariketa6();
                    break;
                case 7:
                    Console.WriteLine(" *****TRIANGELUAREN AZALERA *****");
                    Ariketa7();
                    break;
                case 8:
                    Console.WriteLine(" *****JOLAS PARKEA KUDEATZEN *****");
                    Ariketa8();
                    break;
                case 9:
                    Console.WriteLine(" *****SARRERA KOPURUA *****");
                    Ariketa9();
                    break;
                case 10:
                    Console.WriteLine(" *****ZEÑ DEN ALTUENA *****");
                    Ariketa10();
                    break;
            
                default:
                    
                
                    return;
             
            }
        }
        static void Ariketa1()
        {
            Console.WriteLine("Kaixo Mundua");
        }
        static void Ariketa2()
        {
            Console.WriteLine("Sartu Zure adina");
            int adina = int.Parse(Console.ReadLine());
            Console.WriteLine("Hurrengo urteko adina: {0}", adina + 1);
        }
        static void Ariketa3()
        {
            Console.WriteLine("Idatzi bi zenbaki oso eta beraien bataz bestekoa esango dizut");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Hau izango zen batazbesteko zehatza:¨{0}", (float)(A + B) / 2);
            Console.WriteLine("Huau izango zen batazbesteko osoa:¨{0}", (A + B) / 2);
        }
        static void Ariketa4()
        {
            Console.WriteLine("Idatzi zenbaki oso bat ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Zenbaki hau bikoitia da? {0}", C % 2 == 0);
        }
        static void Ariketa5()
        {
            Console.WriteLine("Idatzi diru kantitatea");
            int dirua = int.Parse(Console.ReadLine());
            Console.WriteLine("Idatzi Bez-aren portzentajea");
            int bez = int.Parse(Console.ReadLine());
            Console.WriteLine("Bez-aren kantitatea: {0}", dirua * bez / 100);
            Console.WriteLine("Diru kantitatea BEZ-arekin: {0}", dirua + (dirua * bez / 100));
        }
        static void Ariketa6()
        {
            Console.WriteLine("Idatzi zenabki bat");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("7-ren multiploa da? {0}", a % 7 == 0);
            if (a % 7 == 0)
            {
                Console.WriteLine("Zenbaki hau 7-ren multiploa da");
            }
            else
            {
                Console.WriteLine("Zenbaki hau ez da 7-ren multiploa");
                if (a % 7 == 1)
                {
                    Console.WriteLine("6 zenbakia gehitu behar zaio");
                }
                else if (a % 7 == 2)
                {
                    Console.WriteLine("5 gehitu behar zaio");
                }
                else if (a % 7 == 3)
                {
                    Console.WriteLine("4 gehitu behar zaio");
                }
                else if (a % 7 == 4)
                {
                    Console.WriteLine("3 gehitu behar zaio");
                }
                else if (a % 7 == 5)
                {
                    Console.WriteLine("2 gehitu behar zaio");
                }
                else if (a % 7 == 6)
                {
                    Console.WriteLine("1 gehitu behar zaio");

                }




            }
        }

        static void Ariketa7()
        {
            Console.WriteLine("Idatzi triangeluaren oinarriaren balioa");
            double oinarria = double.Parse(Console.ReadLine());
            Console.WriteLine("Idatzi triangeluaren altuera");
            double altuera = double.Parse(Console.ReadLine());
            Console.WriteLine("Triangeluaren azalera: {0}", (oinarria * altuera) / 2);
        }
        static void Ariketa9()
        {
            Console.WriteLine(" Sarrarera kopurua idatzi");
            float sarrera = float.Parse(Console.ReadLine());
            Console.WriteLine("Zenbat Ume");
            float ume = float.Parse(Console.ReadLine());
            Console.WriteLine("Sarreraren kopurua: {0}", sarrera);
            Console.WriteLine("Ume kopurua: {0}", ume);
            float heldu = sarrera - ume;
            Console.WriteLine("Heldu kopurua: {0}", heldu);
            Console.WriteLine("Guztira ordaindu behar duzuna: {0}", (heldu * 20) + (ume * 15.5));
            float diru = (heldu * 20.0F) + (ume * 15.5F);
            if (diru > 100)
            {
                Console.WriteLine("Diru kantitatea 100 baino handiagoa da, beraz, deskontua izango duzu");
                Console.WriteLine("Deskontua: {0}", diru * 0.05);
                Console.WriteLine("Ordaindu behar duzuna: {0}", diru - (diru * 0.05));
            }
            else
            {
                Console.WriteLine("Diru kantitatea 100  baino txikiagoa da, beraz, ez duzu deskonturik izango");
            }

        }
        static void Ariketa8()
        {

        }

        static void Ariketa10()
        {
            Console.WriteLine("Sartu lehen zenbakia");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Sartu bigarren zenbakia");
            float b = float.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Zenbakiak berdinak dira");
            }
            else if (a > b)
            {
                Console.WriteLine("Lehenengo zenbakia handiena da");
            }
            else
            {
                Console.WriteLine("Bigarren zenbakia handiena da");
            }
        }
    }
}

