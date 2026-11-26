static void menu
{
    string aukera = "";

}
static void KalkulatuBildumaBalioa()
{
    Erakutsidatuak();
    Console.WriteLine("\nZein bildumari buruzko balioa kalkulatu nahi duzu?");
    string kodea = Console.ReadLine();
    string[] aldagaiak = ItzuliKalkulatzekoAldagaiak(kodea);
    bool saga = bool.Parse(aldagaiak[0]);
    DateTime data = DateTime.Parse(aldagaiak[1]); //Data.Year; urtea bakarrik jakiteko
    double prezioa = double.Parse(aldagaiak[2].Replace("€", ""));
    double gehikuntza = 1.50;
    if (saga == true)
    {
        gehikuntza = 3.00;
    }
    int urteak = DateTime.Now.Year - data.Year; //Now-k oraingo urtea eta besteak jokoaren urtea
    double prezio_berria = (urteak * gehikuntza) + prezioa;
    Console.WriteLine($"Bildumaren balioa gaurko egunez: {prezio_berria}€ da. Guztira {prezio_berria} hazi da!");
}

static void Erakutsidatuak()
{
    string[] lerroak = File.ReadAllLines("jokoak.txt");

    for (int i = 0; i < lerroak.Length; i++)
    {
        string[] zatiak = lerroak[i].Split('-');
        Console.WriteLine($"| {zatiak[0]} | {zatiak[1]} | {zatiak[2]} | {zatiak[3]} | {zatiak[4]} | {zatiak[5]} |");
    }
}
static string[] ItzuliKalkulatzekoAldagaiak(string kodea)
{
    string[] aldagaiak = new string[3];
    string[] lerroak = File.ReadAllLines("jokoak.txt");
    for (int i = 0; i < lerroak.Length; i++)
    {
        string[] zatiak = lerroak[i].Split('-');
        if (zatiak[2] == kodea)
        {
            aldagaiak[0] = zatiak[3]; // saga
            aldagaiak[1] = zatiak[4]; // data
            aldagaiak[2] = zatiak[5]; // prezioa
            return aldagaiak;
        }
    }
}
KalkulatuBildumaBalioa();
 