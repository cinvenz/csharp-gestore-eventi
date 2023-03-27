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

    public void StampaListaEventi(List<Evento> listaEventiInData)
    {
        foreach (Evento evento in listaEventiInData)
        {
            Console.WriteLine(evento.ToString());
        }
    }

    public List<Evento> GetEventiInData(DateTime data)
    {
        List<Evento> eventiInData = new List<Evento>();
        foreach (Evento evento in Eventi)
        {
            if (evento.Data == data)
            {
                eventiInData.Add(evento);
            }
        }
        return eventiInData;
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
            result += evento.Data.ToString("dd/MM/yyyy") + " - " + evento.Title;
        }
        return result;
    }

}


