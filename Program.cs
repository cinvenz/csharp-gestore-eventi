//Console.WriteLine("Inserisci un nuovo evento:");

//Console.Write("Titolo: ");
//string title = Console.ReadLine();

//Console.Write("Data (formato gg/mm/aaaa): ");
//DateTime data = DateTime.Parse(Console.ReadLine());

//Console.Write("Capienza massima: ");
//int maxCapacity = int.Parse(Console.ReadLine());

//Evento newEvent = new Evento(title, data, maxCapacity);

//Console.WriteLine($"Evento creato con successo: { newEvent }" );

////------------- evento creato -----------------------

//Console.Write("Vuoi prenotare dei posti per questo evento? (si/no): ");
//string inputPrenota = Console.ReadLine();

//if (inputPrenota.ToLower() == "si")
//{
//    Console.Write("Quanti posti vuoi prenotare? ");
//    int postiDaPrenotare = int.Parse(Console.ReadLine());

//    newEvent.PrenotaPosti(postiDaPrenotare);
//    var postiDisponibili = newEvent._maxCapacity - newEvent._numberReservedSeats;
//    Console.WriteLine($"Prenotazione effettuata con successo. Posti prenotati: {newEvent._numberReservedSeats} - Posti disponibili {postiDisponibili}");
//}
//else
//{
//    Console.Write("ok va bene");
//}


//Console.Write("Vuoi disdire dei posti per questo evento? (si/no): ");
//string inputDisdici = Console.ReadLine();

//while (inputDisdici.ToLower() == "si")
//{
//    Console.Write("Quanti posti vuoi disdire? ");
//    int postiDaDisdire = int.Parse(Console.ReadLine());

//    try
//    {
//        newEvent.DisdiciPosti(postiDaDisdire);
//        var postiDisponibili = newEvent.MaxCapacity - newEvent.NumberReservedSeats;
//        Console.WriteLine($"Disdetta avvenuta con successo. Posti disdetti: {postiDaDisdire} - Posti disponibili {postiDisponibili}");
//    }
//    catch (ArgumentException exception)
//    {
//        Console.WriteLine(exception.Message);
//    }

//    Console.Write("Vuoi disdire altri posti? (si/no): ");
//    inputDisdici = Console.ReadLine();
//}

//Console.Write("Ok va bene");

//Fine milestone 3



//PROGRAMMAEVENTI

using System;
using System.Collections.Generic;

Console.WriteLine("Programma di Eventi!");

Console.Write("Qual è il titolo del suo programma eventi? ");
string titleProgramma = Console.ReadLine();

Console.Write("Quanti eventi vuoi aggiungere? ");
int numeriEventi = int.Parse(Console.ReadLine());

ProgrammaEventi programmaEventi = new ProgrammaEventi(titleProgramma);

for (int i = 0; i < numeriEventi; i++)
{
    Console.WriteLine($"Inserisci le informazioni per l'evento numero {i + 1}:");
    Console.Write("Titolo: ");
    string title = Console.ReadLine();

    Console.Write("Data gg/mm/aaaa: ");
    DateTime data = DateTime.Parse(Console.ReadLine());

    Console.Write("Capienza massima: ");
    int maxCapacity = int.Parse(Console.ReadLine());

    Evento newEvent = new Evento(title, data, maxCapacity);
    programmaEventi.AggiungiEvento(newEvent);

    Console.WriteLine($"Evento creato con successo: {newEvent}");

    Console.Write("Vuoi prenotare dei posti per questo evento? (si/no): ");
    string inputPrenota = Console.ReadLine();

    if (inputPrenota.ToLower() == "si")
    {
        Console.Write("Quanti posti vuoi prenotare? ");
        int postiDaPrenotare = int.Parse(Console.ReadLine());

        newEvent.PrenotaPosti(postiDaPrenotare);
        var postiDisponibili = newEvent.MaxCapacity - newEvent.NumberReservedSeats;
        Console.WriteLine($"Prenotazione effettuata con successo. Posti prenotati: {newEvent.NumberReservedSeats} - Posti disponibili {postiDisponibili}");
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

    Console.WriteLine("Ok va bene");
}


Console.Write("Numero Eventi: ");
Console.WriteLine(programmaEventi.CountEventi());

Console.WriteLine("Ecco tutti gli eventi del tuo programma:");
Console.WriteLine(programmaEventi.GetAllTitleEvent());

Console.Write("Inserisci la data per sapere quali eventi ci saranno (formato gg/mm/aaaa): ");
DateTime dataEventoSpecifica = DateTime.Parse(Console.ReadLine());

List<Evento> eventiInData = programmaEventi.GetEventiInData(dataEventoSpecifica);

if (eventiInData.Count == 0)
{
    Console.WriteLine("Non ci sono eventi in questa data.");
}
else
{
    Console.WriteLine($"Ecco tutti gli eventi in data {dataEventoSpecifica}:");
    programmaEventi.StampaListaEventi(eventiInData);
}



Console.Write("vuoi eliminaretutti gli eventi? si/no (si/no): ");
string inputElimina = Console.ReadLine();

if (inputElimina.ToLower() == "si")
{
    Console.WriteLine("Tutti gli eventi sono stati eliminati!");
    programmaEventi.SvuotaLista();
}
else
{
    Console.Write("Arrivederci.");
}





