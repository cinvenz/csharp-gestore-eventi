Console.WriteLine("Inserisci un nuovo evento:");

Console.Write("Titolo: ");
string title = Console.ReadLine();

Console.Write("Data (formato gg/mm/aaaa): ");
DateTime data = DateTime.Parse(Console.ReadLine());

Console.Write("Capienza massima: ");
int maxCapacity = int.Parse(Console.ReadLine());

Evento newEvent = new Evento(title, data, maxCapacity);

Console.WriteLine($"Evento creato con successo: { newEvent }" );

//------------- evento creato -----------------------
// Create the Evento instance

Console.Write("Vuoi prenotare dei posti per questo evento? (si/no): ");
string inputPrenota = Console.ReadLine();

if (inputPrenota.ToLower() == "si")
{
    Console.Write("Quanti posti vuoi prenotare? ");
    int postiDaPrenotare = int.Parse(Console.ReadLine());

    newEvent.PrenotaPosti(postiDaPrenotare);
    var postiDisponibili = newEvent._maxCapacity - newEvent._numberReservedSeats;
    Console.WriteLine($"Prenotazione effettuata con successo. Posti prenotati: {newEvent._numberReservedSeats} - Posti disponibili {postiDisponibili}");
}
else
{
    Console.Write("ok va bene");
}


Console.Write("Vuoi disdire dei posti per questo evento? (si/no): ");
string inputDisdici = Console.ReadLine();

while (inputDisdici.ToLower() == "si")
{
    Console.Write("Quanti posti vuoi disdire? ");
    int postiDaDisdire = int.Parse(Console.ReadLine());

    try
    {
        newEvent.DisdiciPosti(postiDaDisdire);
        var postiDisponibili = newEvent.MaxCapacity - newEvent.NumberReservedSeats;
        Console.WriteLine($"Disdetta avvenuta con successo. Posti disdetti: {postiDaDisdire} - Posti disponibili {postiDisponibili}");
    }
    catch (ArgumentException exception)
    {
        Console.WriteLine(exception.Message);
    }

    Console.Write("Vuoi disdire altri posti? (si/no): ");
    inputDisdici = Console.ReadLine();
}

Console.Write("Ok va bene");






