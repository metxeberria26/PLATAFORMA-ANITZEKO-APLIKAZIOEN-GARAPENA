using System.ComponentModel.Design;
using System.Xml;

namespace HasieraHutsik
{
    public class BegiztaBaldintza
    {
        public static void Exekutatu()
        {
            Console.WriteLine("***** BEGIZTA/BALDINTZAK ***********");
            Console.Write("Zenbatgarren ariketa nahi duzun egin? Sartu 1-tik 16-ra zenbaki bat:");
            int eragiketa = int.Parse(Console.ReadLine());
            switch (eragiketa)
            {
                case 1:
                    Ariketa1();
                    break;
                case 2:
                    Ariketa2();
                    break;
                case 3:
                    Ariketa3();
                    break;
                case 4:
                    Ariketa4();
                    break;
                case 5:
                    Ariketa5();
                    break;
                case 6:
                    Ariketa6();
                    break;
                case 7:
                    Ariketa7();
                    break;
                case 8:
                    Ariketa8();
                    break;
                case 9:
                    Ariketa9();
                    break;
                case 10:
                    Ariketa10();
                    break;
                case 11:
                    Ariketa11();
                    break;
                case 12:
                    Ariketa12();
                    break;
                case 13:
                    Ariketa13();
                    break;
                case 14:
                    Ariketa14();
                    break;
                case 15:
                    Ariketa15();
                    break;
                case 16:
                    Ariketa16();
                    break;
                default:
                    Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                    break;
            }
        }
        static void Ariketa1()
        {
            Console.WriteLine("Sartu zure lehen zenbakia");
            int zenbakia1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sartu zure bigarren zenbakia");
            int zenbakia2 = int.Parse(Console.ReadLine());

            if (zenbakia1 > zenbakia2)
            {
                while (zenbakia2 <= zenbakia1)
                {
                    Console.WriteLine(zenbakia1);
                    zenbakia1--;
                }
            }
            else if (zenbakia1 < zenbakia2)
            {
                while (zenbakia1 <= zenbakia2)
                {
                    Console.WriteLine(zenbakia2);
                    zenbakia2--;
                }
            }
            else
            {
                Console.WriteLine(zenbakia1);
            }
        }

        static void Ariketa2()
        {
            Console.WriteLine("1-100 tarteko zenbakia asmatu");
            int asmatuZenbakia = 45;
            int b;
            do
            {
                Console.WriteLine("Ea asmatzen duzun zenbakia");
                b = int.Parse(Console.ReadLine());

                if (b < asmatuZenbakia)
                {
                    Console.WriteLine("Zenbakia handiagoa da");
                }
                else if (b > asmatuZenbakia)
                {
                    Console.WriteLine("Zenbakia txikiagoa da");
                }
            } while (b != asmatuZenbakia);
            Console.WriteLine("Asmatu duzu!");




        }
        static void Ariketa3()
        {
            Console.WriteLine("1-100 tarteko zenbakia asmatu");

            int asmatuZenbakia = 45;
            int b = 0;

            while (b != asmatuZenbakia)
            {
                Console.WriteLine("Ea asmatzen duzun zenbakia");
                b = int.Parse(Console.ReadLine());

                if (b < asmatuZenbakia)
                {
                    Console.WriteLine("Zenbakia handiagoa da");
                }
                else if (b > asmatuZenbakia)
                {
                    Console.WriteLine("Zenbakia txikiagoa da");
                }
            }

            Console.WriteLine("Asmatu duzu!");
        }
        static void Ariketa4()
        {
            Console.WriteLine("1-100 tarteko zenbakia asmatu");

            int asmatuZenbakia = 45;
            int b = 0;
            int intentuak = 0;

            while (b != asmatuZenbakia)
            {
                Console.WriteLine("Ea asmatzen duzun zenbakia");
                b = int.Parse(Console.ReadLine());

                intentuak++;

                if (b < asmatuZenbakia)
                {
                    Console.WriteLine("Zenbakia handiagoa da");
                }
                else if (b > asmatuZenbakia)
                {
                    Console.WriteLine("Zenbakia txikiagoa da");
                }
            }

            Console.WriteLine("Asmatu duzu!");
            Console.WriteLine("Saiakerak: " + intentuak);
        }
        static void Ariketa5()
        {
            Console.WriteLine("1-100 tarteko zenbakia asmatu");

            int asmatuZenbakia = 45;
            int b = 0;
            int intentuak = 0;
            int suma = 0;

            while (b != asmatuZenbakia)
            {
                Console.WriteLine("Ea asmatzen duzun zenbakia");
                b = int.Parse(Console.ReadLine());

                intentuak++;
                suma = suma + b;

                if (b < asmatuZenbakia)
                {
                    Console.WriteLine("Zenbakia handiagoa da");
                }
                else if (b > asmatuZenbakia)
                {
                    Console.WriteLine("Zenbakia txikiagoa da");
                }
            }

            Console.WriteLine("Asmatu duzu!");
            Console.WriteLine("Saiakerak: " + intentuak);
            Console.WriteLine("Sartutako zenbakien batura: " + suma);
        }
        static void Ariketa6()
        {
            Console.WriteLine("Idatzi zenbaki bat mesedez:");
            int Zenbakia1 = int.Parse(Console.ReadLine());
            int Zenbakia2 = 0;
            Console.WriteLine("*************");
            if (Zenbakia1 > Zenbakia2)
            {
                while (Zenbakia1 - 1 > Zenbakia2)
                {
                    Zenbakia1--;
                    Console.WriteLine(Zenbakia1);
                }
            }
            else
            {
                while (Zenbakia1 + 1 < Zenbakia2)
                {
                    Zenbakia1++;
                    Console.WriteLine(Zenbakia1);
                }
            }
        }

        static void Ariketa7()
        {
            Console.WriteLine("Idatzi zure nota");
            int a = int.Parse(Console.ReadLine());

            if (a < 4)
            {
                Console.WriteLine("Zure nota GUTXI da");
            }
            else if (a == 5)
            {
                Console.WriteLine("Zure nota NAHIKO da");
            }
            else if (a == 6)
            {
                Console.WriteLine("Zure nota ONGI da");
            }
            else if (a == 7)
            {
                Console.WriteLine("Zure nota OSOONGI da");
            }
            else if (a == 8)
            {
                Console.WriteLine("Zure nota OSOONGI da");
            }
            else if (a > 8 && a < 10)
            {
                Console.WriteLine("Zure nota BIKAIN da");
            }

        }
        static void Ariketa8()
        {

        }
        static void Ariketa9()
        {
            Console.WriteLine("Idatzi NAN aren 8 zenbakiak");
            int zenbakia = int.Parse(Console.ReadLine());
            int hondarra = zenbakia % 23;
            switch (hondarra)
            {
                case 0: Console.WriteLine("Zure NAN aren letra T da"); break;
                case 1: Console.WriteLine("Zure NAN aren letra R da"); break;
                case 2: Console.WriteLine("Zure NAN aren letra W da"); break;
                case 3: Console.WriteLine("Zure NAN aren letra A da"); break;
                case 4: Console.WriteLine("Zure NAN aren letra G da"); break;
                case 5: Console.WriteLine("Zure NAN aren letra M da"); break;
                case 6: Console.WriteLine("Zure NAN aren letra Y da"); break;
                case 7: Console.WriteLine("Zure NAN aren letra F da"); break;
                case 8: Console.WriteLine("Zure NAN aren letra P da"); break;
                case 9: Console.WriteLine("Zure NAN aren letra D da"); break;
                case 10: Console.WriteLine("Zure NAN aren letra X da"); break;
                case 11: Console.WriteLine("Zure NAN aren letra B da"); break;
                case 12: Console.WriteLine("Zure NAN aren letra N da"); break;
                case 13: Console.WriteLine("Zure NAN aren letra J da"); break;
                case 14: Console.WriteLine("Zure NAN aren letra Z da"); break;
                case 15: Console.WriteLine("Zure NAN aren letra S da"); break;
                case 16: Console.WriteLine("Zure NAN aren letra Q da"); break;
                case 17: Console.WriteLine("Zure NAN aren letra V da"); break;
                case 18: Console.WriteLine("Zure NAN aren letra H da"); break;
                case 19: Console.WriteLine("Zure NAN aren letra L da"); break;
                case 20: Console.WriteLine("Zure NAN aren letra C da"); break;
                case 21: Console.WriteLine("Zure NAN aren letra K da"); break;
                case 22: Console.WriteLine("Zure NAN aren letra E da"); break;

            }
        }
        static void Ariketa10()
        {
            int adina = 0;
            int batura = 0;
            int batazbestekoa;
            int kopurua = 0;
            int adinnagusi = 0;

            do
            {
                Console.WriteLine("Sartu zure adina, negatiboa amaitzeko");
                adina = int.Parse(Console.ReadLine());
                kopurua++;
                batura = batura + adina;
                if (adina >= 18) adinnagusi++;




            } while (adina >= 0);


            Console.WriteLine("pertsona kopurua: " + (kopurua - 1));
            Console.WriteLine("Adinen batura: " + ((batura) - adina));
            Console.WriteLine("Batazbestekoa: " + ((batura - adina) / (kopurua - 1)));
            Console.WriteLine("Adin nagusiak: " + adinnagusi);
        }

        static void Ariketa11()
        {
            Console.WriteLine("sartu zure zenbakia");
            int zenbakia = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(zenbakia + " x " + i + " = " + (zenbakia * i));
            }
        }
        static void Ariketa12()
        {
            Console.WriteLine("Sartu zure zenbakia");
            int zenbakia = int.Parse(Console.ReadLine());
            if (zenbakia < 0)
            {
                Console.WriteLine("zenbaki negatiboek ez dute faktoriala");
            }
            else if (zenbakia == 0)
            {
                Console.WriteLine("0! = 1");
            }
            else
            {
                int faktoriala = zenbakia;
                Console.Write(zenbakia);
                for (int i = zenbakia - 1; i >= 1; i--)
                {
                    Console.Write("x" + i);
                    //Console.WriteLine("{0}x{1}", zenbakia, faktoriala);
                    //Console.WriteLine($"{zenbakia}x{faktoriala}");

                    faktoriala = faktoriala * i;
                    //faktoriala *= i;
                }
                Console.WriteLine("\n" + zenbakia + "! = " + faktoriala);
            }
        }
        static void Ariketa13()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
                Console.WriteLine("***************");
            }
        }
        static void Ariketa14()
        {
            Console.WriteLine("Eman zenbaki oso bat");
            int zenbakia = int.Parse(Console.ReadLine());
            int batuketa = 1;
            while (zenbakia >= batuketa * batuketa)
            {
                Console.WriteLine(batuketa + "^2 = " + batuketa * batuketa);
                batuketa++;
            }
            Console.WriteLine(batuketa - 1 + " izango da gertueneko zenbakia");
            Console.WriteLine((zenbakia - ((batuketa - 1) * (batuketa - 1))) + " da hondarra");

        }
        static void Ariketa15()
        {
            Console.WriteLine("***** Eragiketak ***********");
            Console.WriteLine("Ze eragiketa egin nahi duzu?: aukeratu 1-5era zenbaki bat");
            Console.WriteLine("1 - Batuketa.");
            Console.WriteLine("2 - Kenketa.");
            Console.WriteLine("3 - Zatiketa.");
            Console.WriteLine("4 - Biderketa.");
            Console.WriteLine("5 - irten.");
            int eragiketabat = int.Parse(Console.ReadLine());
            switch (eragiketabat)
            {
                case 1:
                    batuketa();
                    break;
                case 2:
                    kenketa();
                    break;
                case 3:
                    zatiketa();
                    break;
                case 4:
                    biderketa();
                    break;
                case 5:
                    irten();
                    break;
                default:
                    Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                    break;
            }
            static void batuketa()
            {
                int zenbakia;
                int zenbakiabi;
                int batuketa;
                do
                {
                    Console.WriteLine("Sartu lehenengo zenbakia");
                    zenbakia = int.Parse((Console.ReadLine()));
                    Console.WriteLine("Sartu bigarrengo zenbakia");
                    zenbakiabi = int.Parse((Console.ReadLine()));
                    batuketa = zenbakia + zenbakiabi;
                    Console.WriteLine(zenbakia + "+" + zenbakiabi + "=" + batuketa);
                } while (zenbakia != 0);
            }
            static void kenketa()
            {
                int zenbakia;
                int zenbakiabi;
                int kenketa;
                do
                {
                    Console.WriteLine("Sartu lehenengo zenbakia");
                    zenbakia = int.Parse((Console.ReadLine()));
                    Console.WriteLine("Sartu bigarrengo zenbakia");
                    zenbakiabi = int.Parse((Console.ReadLine()));
                    kenketa = zenbakia - zenbakiabi;
                    Console.WriteLine(zenbakia + "-" + zenbakiabi + "=" + kenketa);
                } while (zenbakia != 0);
            }
        }
        static void zatiketa()
        {
            int zenbakia;
            int zenbakiabi;
            int zatiketa;
            do
            {
                Console.WriteLine("Sartu lehenengo zenbakia");
                zenbakia = int.Parse((Console.ReadLine()));
                Console.WriteLine("Sartu bigarrengo zenbakia");
                zenbakiabi = int.Parse((Console.ReadLine()));
                zatiketa = zenbakia / zenbakiabi;
                Console.WriteLine(zenbakia + "/" + zenbakiabi + "=" + zatiketa);
            } while (zenbakia != 0);

        }
        static void biderketa()
        {
            int zenbakia;
            int zenbakiabi;
            int biderketa;
            do
            {
                Console.WriteLine("Sartu lehenengo zenbakia");
                zenbakia = int.Parse((Console.ReadLine()));
                Console.WriteLine("Sartu bigarrengo zenbakia");
                zenbakiabi = int.Parse((Console.ReadLine()));
                biderketa = zenbakia * zenbakiabi;
                Console.WriteLine(zenbakia + "*" + zenbakiabi + "=" + biderketa);
            } while (zenbakia != 0);

        }
        static void irten()
        {
        }

        static void Ariketa16()
        {
            Console.WriteLine("Eman zenbaki bat");
            int zenbakia = int.Parse((Console.ReadLine()));
            int batura = 1;
            while (zenbakia >= batura)
            {
                if (zenbakia % batura == 0)
                {
                    Console.WriteLine(batura);
                    batura++;
                }
                else
                {
                    batura++;
                }
            }

        }
    }
}
