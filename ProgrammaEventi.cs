using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ProgrammaEventi
{
    public string Titolo { get; set; }
    public List<Evento> Eventi { get; set; }

    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        Eventi = new List<Evento>();
    }

    public void AggiungiEvento(Evento evento)
    {
        Eventi.Add(evento);
    }

    public List<Evento> EventiPerData(DateTime data)
    {
        List<Evento> eventiPerData = new List<Evento>();
        foreach (Evento evento in Eventi)
        {
            if (evento.Data == data.Date)
            {
                eventiPerData.Add(evento);
            }
        }
        return eventiPerData;
    }

    static string StampaLista(List<Evento> listaEventi)
    {
        string result = "[";
        for (int i = 0; i < listaEventi.Count; i++)
        {
            result += listaEventi[i].ToString();
            if (i != listaEventi.Count - 1)
            {
                result += ", ";
            }
        }
        result += "]";
        return result;
    }

    public int CountEventi()
    {
        return Eventi.Count;
    }

    public void SvuotaLista()
    {
        Eventi.Clear();
    }

    public string GetAllTitleEvent()
    {
        string result = "Nome programma evento: ";
        foreach (Evento evento in Eventi)
        {
            result += evento.Data.ToString() + " - " + evento.Title;
        }
        return result;
    }


}


