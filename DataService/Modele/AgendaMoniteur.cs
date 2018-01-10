using System;

public class AgendaMoniteur
{
    private Moniteur moniteur;
    private Jour jour;
    private Creneaux creneau;
    private int valeur;

    public AgendaMoniteur(Moniteur moniteur, Jour jour, Creneaux creneau, int valeur)
    {
        this.moniteur = moniteur;
        this.jour = jour;
        this.creneau = creneau;
        this.valeur = valeur;
    }

    public Moniteur Moniteur
    {
        get { return moniteur; }
        set { moniteur = value; }
    }

    public Jour Jour
    {
        get { return jour; }
        set { jour = value; }
    }

    public Creneaux Creneau
    {
        get { return creneau; }
        set { creneau = value; }
    }

    public int Valeur
    {
        get { return valeur; }
        set { valeur = value; }
    }


}

