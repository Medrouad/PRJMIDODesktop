using System;

public class Paiement
{

    private Client client;
    private string typePaiement;
    private DateTime date;
    private double montant;


    public Paiement(Client client, string typePaiement, DateTime date, double montant)
    {
        this.client = client;
        this.typePaiement = typePaiement;
        this.date = date;
        this.montant = montant;
    }


    public Client Client
    {
        get { return client; }
        set { client = value; }
    }

    public string TypePaiement
    {
        get { return typePaiement; }
        set { typePaiement = value; }
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public double Montant
    {
        get { return montant; }
        set { montant = value; }
    }
}

