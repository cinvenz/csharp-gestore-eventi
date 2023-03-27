using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Conferenza : Evento
{
    public string Relatore { get; set; }
    public double Prezzo { get; set; }

    public Conferenza(string title, DateTime data, int maxCapacity, string relatore, double prezzo) : base(title, data, maxCapacity)
    {
        Relatore = relatore;
        Prezzo = prezzo;
    }

    public string GetDataOraFormattata()
    {
        return Data.ToString("dd/MM/yyyy HH:mm");
    }

    public string GetPrezzoFormattato()
    {
        return Prezzo.ToString("0.00") + " euro";
    }

    public override string ToString()
    {
        return $"Data Conferenza: {GetDataOraFormattata()} - Nome Conferenza: {Title} - Nome Relatore; {Relatore} - Prezzo Biglietto: {GetPrezzoFormattato()}";
    }
}

