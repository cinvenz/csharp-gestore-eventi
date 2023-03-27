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
string input = Console.ReadLine();

if (input.ToLower() == "si")
{
    Console.Write("Quanti posti vuoi prenotare? ");
    int postiDaPrenotare = int.Parse(Console.ReadLine());

    newEvent.PrenotaPosti(postiDaPrenotare);
    var postiDisponibili = newEvent._maxCapacity - newEvent._numberReservedSeats;
    Console.WriteLine($"Prenotazione effettuata con successo. Posti prenotati: {newEvent._numberReservedSeats} - Posti disponibili {postiDisponibili}");
}
else
{
    Console.Write("Grazie e alla prossima");
}




