using System;

public abstract class Personne
{
    protected string nom;
    protected string prenom;
    protected DateTime dateNaissance;
    protected string adresse;
    protected string telephone;
    protected string adresseMail;


    public Personne(string nom, string prenom, DateTime dateNaissance, string adresse, string telephone, string adresseMail)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.dateNaissance = dateNaissance;
        this.adresse = adresse;
        this.telephone = telephone;
        this.adresseMail = adresseMail;
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }

    public DateTime DateNaissance
    {
        get { return dateNaissance; }
        set { dateNaissance = value; }
    }

    public string Adresse
    {
        get { return adresse; }
        set { adresse = value; }
    }

    public string Telephone
    {
        get { return telephone; }
        set { telephone = value; }
    }

    public string AdresseMail
    {
        get { return adresseMail; }
        set { adresseMail = value; }
    }





}

