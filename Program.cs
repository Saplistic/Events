using Generieke_Collecties;

Stapel<int> integers = new();

//voeg een methode toe aan de delegate van de event
integers.OnWijziging += boodschapVermelding;

integers.Opzetten(15);
integers.Opzetten(63);
integers.Afhalen();
integers.Leegmaken();

Console.ReadLine(); //sluit de applicatie niet meteen

//een voorbeeldmethode om op de event te reageren
void boodschapVermelding(object sender, string methode)
{
    Console.WriteLine("Een eigenschap van het object " + sender.ToString() + " werd gewijzigd met methode '" + methode + "'");
}