using System;

public class Reservation
{
    private Client client;
    private Moniteur moniteur;
    private Vehicule vehicule;
    private DateTime date;
    private Boolean realisee = false;

    public Reservation(Client client, Moniteur moniteur, Vehicule vehicule, DateTime date)
    {
        this.client = client;
        this.moniteur = moniteur;
        this.vehicule = vehicule;
        this.date = date;
    }

    public Client Client
    {
        get { return client; }
        set { client = value; }
    }

    public Moniteur Moniteur
    {
        get { return moniteur; }
        set { moniteur = value; }
    }

    public Vehicule Vehicule
    {
        get { return vehicule; }
        set { vehicule = value; }
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public Boolean Realisee
    {
        get { return realisee; }
        set { realisee = value; }
    }

}

