using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class Evento
{

    private string _title;
    private DateTime _data;
    public int _maxCapacity;
    public int _numberReservedSeats;

    public Evento(string title, DateTime data, int maxCapacity)
    {
        _title = title;
        _data = data;
        _maxCapacity = maxCapacity;
        _numberReservedSeats = 0;
    }

    public DateTime Data
    {
        get { return _data; }
        set
        {
            if (value < DateTime.Now)
            {
                throw new ArgumentException("La data non può essere già passata");
            }
            _data = value;
        }
    }

    public string Title
    {
        get { return _title; }
        set
        {
            if (value == "" || value == null)
            {
                throw new ArgumentException("Il titolo non può essere vuoto");
            }
            _title = value;
        }
    }

    public int MaxCapacity
    {
            get => _maxCapacity; private set
        {
            if (value > 0)
            {
                _maxCapacity = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "La capienza massima deve essere un numero positivo");
            }
        }
    }

    public int NumberReservedSeats
    {
        get { return _numberReservedSeats; }
    }


    //PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati.
    //Se l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevare un’eccezione.

    public void PrenotaPosti(int postiDaPrenotare)
    {
        if (Data < DateTime.Now)
        {
            throw new InvalidOperationException("L'evento è già passato");
        }

        int postiDisponibili = _maxCapacity - _numberReservedSeats;
        if (postiDisponibili == 0)
        {
            throw new InvalidOperationException("Non ci sono posti disponibili");
        }
        if (postiDaPrenotare > postiDisponibili)
        {
            throw new InvalidOperationException("La tua richiesta di prenotazione supera il numero di posti disponibili");
        }

        _numberReservedSeats += postiDaPrenotare;
    }

    // DisdiciPosti: riduce del i posti prenotati del numero di posti indicati come parametro.
    // Se l’evento è già passato o non ci sono i posti da disdire sufficienti, deve sollevare un’eccezione.
    public void DisdiciPosti(int postiDaDisdire)
    {
        if (Data < DateTime.Now)
        {
            throw new InvalidOperationException("L'evento è passato, non puoi disdire i posti");
        }
        if (_numberReservedSeats < postiDaDisdire)
        {
            throw new ArgumentException("Vuoi disdire più posti di quanti prenotati");
        }
        _numberReservedSeats -= postiDaDisdire;
    }

    // L’override del metodo ToString() in modo che venga restituita una stringa contenente: data formattata – titolo
    // Per formattare la data correttamente usate nomeVariabile.ToString("dd/MM/yyyy"); applicata alla vostra variabile DateTime.

    public override string ToString()
    {
        return _data.ToString("dd/MM/yyyy") + " - " + Title;
    }


}



