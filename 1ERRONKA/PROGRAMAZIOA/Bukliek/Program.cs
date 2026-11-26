namespace HasieraHutsik
{
        public class Ariketak
        {
            //LA RAIZ!! hemendik doa dena, static void Main bakarrak egon behar du
            static void Main()
            {
                Console.WriteLine("***** ARIKETAK ***********");
                Console.WriteLine("1.- Oinarrizko Kontzeptuen ariketak");
                Console.WriteLine("2.- Begizta eta baldintzen ariketak");
                Console.WriteLine("3.- Begizta eta baldintzen EXTRA ariketak");
                Console.WriteLine("4.- Karaktere kateen ariketak");
                Console.WriteLine("5.- Nire funtzion ariketak 1, Kalkulagailua");
                Console.WriteLine("6.- Nire funtzion ariketak 2, Irudia");
                Console.WriteLine("7.- Nire funtzioak2425 ");
                Console.WriteLine("8.- IRTEN");

            Console.Write("Ze ariketa nahi duzun egin? Sartu bere zenbakia:");
                int eragiketa = int.Parse(Console.ReadLine());
                switch (eragiketa)
                {
                    case 1:
                        OinarrizkoKontzeptuak.Exekutatu();
                        break;
                    case 2:
                        BegiztaBaldintza.Exekutatu();
                        break;
                    case 3:
                        BegiztaExtrak.Exekutatu();
                        break;
                    case 4:
                        KaraktereKateak.Exekutatu();
                        break;
                    case 5:
                        NireFuntzioak1.Exekutatu();
                        break;
                    case 6:
                        NireFuntzioak2.Exekutatu();
                        break;
                    case 7:
                    NireFuntzioak2425.Exekutatu();
                        break;
                    case 8:
                        return;
                    default:
                         Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                    break;
                }                   
            }

        }
}