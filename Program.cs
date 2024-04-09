/* *************************************************
 * Namn: Påskäggsjakten
 * Beskrivning: Ett program som simulerar en påskäggsjakt
 * Av: [Ditt namn]
 * Datum: 2021-09-01
 *********************************************** */

int antalPåskägg = 0;

// Programloop
while (true)
{
    // Meny
    Metoder.VisaMeny();
    string val = Console.ReadLine();

    // Switch-sats

    if (val == "1")
    {
        antalPåskägg = Metoder.HittaPåskägg(antalPåskägg);
    }
    else if (val == "2")
    {
        antalPåskägg = Metoder.ÄtaPåskägg(antalPåskägg);
    }
    else if (val == "3")
    {
        Metoder.VisaAntalPåskägg(antalPåskägg);
    }
    else if (val == "4")
    {   
        Console.WriteLine("Tack för denna gången!");
        break;
    }
    else
    {
        Console.Write("Ditt val måste vara en siffra mellan 1-4: ");
        val = Console.ReadLine();
    }
}

/* ************************************************
 * **************** Metoder ***********************
 ************************************************* */


{

}