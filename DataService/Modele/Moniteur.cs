using System;

public class Moniteur : Personne
{
    private string photo;

    public Moniteur(string nom, string prenom, DateTime dateNaissance, string adresse, string telephone, string adresseMail, string photo) : base(nom, prenom, dateNaissance, adresse, telephone, adresseMail)
    {
        this.photo = photo;
    }

    public string Photo
    {
        get { return photo; }
        set { photo = value; }
    }

}

