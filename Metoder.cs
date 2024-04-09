static public class Metoder
{

    static public void Presentation()
    {
        Console.WriteLine("Välkommen till den stora äggjakten");
        Console.WriteLine("Lycka till!");
    }
    static public void VisaMeny()
    {
        Console.WriteLine("\n" + "\n" + 
    @"1. Hitta påskägg" + "\n" +
    "2. Äta påskägg" + "\n" +
    "3. Visa antal påskägg" + "\n" +
    "4. Avsluta programmet");
    }

    static public int HittaPåskägg(int antal)
    {
        int slumpantal = Random.Shared.Next(0, 6);
        antal += slumpantal;
        Console.WriteLine($"Du hittade {slumpantal} påskägg");
        return antal;
    }

    static public int ÄtaPåskägg(int antal)
    {
        int slumpantal = Random.Shared.Next(1, 4);

        if (slumpantal > antal)
        {
            antal -= antal;
        }
        else {
            antal -= slumpantal;
        }
        Console.WriteLine($"Du åt {slumpantal} ägg och har nu {antal} ägg");
        return antal;
    }

    static public void VisaAntalPåskägg(int antal)
    {
        Console.WriteLine($"Du har {antal} påskägg");
    }
}