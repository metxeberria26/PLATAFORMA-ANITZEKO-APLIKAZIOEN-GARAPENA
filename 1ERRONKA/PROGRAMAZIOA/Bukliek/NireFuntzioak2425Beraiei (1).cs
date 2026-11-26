namespace HasieraHutsik
{
    public class NireFuntzioak2425
    {
        public static void Exekutatu()
        {
            Console.WriteLine("***** NIRE FUNTZIOAK 2425 ***********");
            Console.Write("Zenbatgarren ariketa nahi duzun egin? Sartu 1-tik 3-ra zenbaki bat:");
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
                default:
                    Console.WriteLine("eragiketa desegokia");
                    break;
            }
        }
        static void Ariketa1()
        {

            (int a, int b) = lortuzenbakia();
          
            int ab  = Batuketa(a,b);
            imprimatu(ab, "");


        }
        static void Ariketa2()
        {
            (int a, int b) = lortuzenbakia();
            int eragiketa = lortueragi();
            int ab = Eragiketa(a, b, eragiketa);
         
            imprimatu(ab, "");
        }
        static void Ariketa3()
        {
            int a, b,z;
            do 
            { 
                ( a,  b) = lortuzenbakia();
                z = Batuketa(a, b);

            } while (parrada(z) == false);
              imprimatu(z , " batura bikoitia da");
        }

        static int Batuketa( int a, int b)
        {
            int z = a + b;
            return (z);
        }

        static int Eragiketa(int a, int b, int eragiketa)
        {

            // 1 batuketa
            // 2 kenketa
            // 3 biderketa
            // 4 zatiketa

            switch (eragiketa)
            {
                case 1:
                    return a + b;

                case 2:
                    return a - b;

                case 3:
                    return a * b;

                case 4:
                    return a / b;

                default:
                    return 0;
            }
        }
            static void imprimatu(int a, string testu)
            {
                Console.WriteLine(a + "" + testu);
            }

            static int parseatu(string ab)
            {
                return int.Parse(ab);
            }

            static (int, int) lortuzenbakia()
            {
                Console.WriteLine("sartu 1 zenbakia: ");
                int a = parseatu(Console.ReadLine());
                Console.WriteLine("sartu 2 zenbakia: ");    
                int b = parseatu(Console.ReadLine());

                return (a, b);
            }

            static int lortueragi()
            {
                int b;
                do
                {

                    Console.WriteLine("sartu zenbaki bat: ");
                    string a = Console.ReadLine();
                    b = parseatu(a);

                    } while ((b < 1) || (b > 4));
                     return b;
            }


            static bool parrada(int a)
            {
                //booleang; true edo False
                if (a % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        

    }

}