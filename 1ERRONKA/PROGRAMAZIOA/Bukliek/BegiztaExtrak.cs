namespace HasieraHutsik
{
    public class BegiztaExtrak
    {
        public static void Exekutatu()
        {
            Console.WriteLine("***** BEGIZTA EXTRAK ***********");
            Console.Write("Zenbatgarren ariketa nahi duzun egin? Sartu 1-tik 5-ra zenbaki bat:");
            int eragiketa = int.Parse(Console.ReadLine());
            switch (eragiketa)
            {
                case 1:
                    Extra1();
                    break;
                case 2:
                    Extra2();
                    break;
                case 3:
                    Extra3();
                    break;
                case 4:
                    Extra4();
                    break;
                case 5:
                    Extra5();
                    break;
                default:
                    Console.WriteLine("eragiketa desegokia");
                    break;
            }
        }
        static void Extra1()
        {
            
        }        
        static void Extra2()
        {
          
        }
        static void Extra3()
        {
            
        }
        static void Extra4()
        {
           
        }
        static void Extra5()
        {
            Console.Write("Sartu zenbaki bat: ");
            int zenbakia = int.Parse(Console.ReadLine());

            int batura = 0;

            for (int i = 1; i < zenbakia; i++)
            {
                if (zenbakia % i == 0)
                {
                    batura = batura + i;
                }
            }
            if (batura ==zenbakia)
            {
                Console.WriteLine($"{zenbakia} zenbakia perfektua da.");
            }
            else
            {
                Console.WriteLine($"{zenbakia} zenbakia ez da perfektua.");
            } 

        }
    }
}


