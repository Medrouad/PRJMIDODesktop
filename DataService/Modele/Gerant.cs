using System;

public class Gerant : Personne
{
    private string password;

    public Gerant(string nom, string prenom, DateTime dateNaissance, string adresse, string telephone, string adresseMail, string password) : base(nom, prenom, dateNaissance, adresse, telephone, adresseMail)
    {
        this.password = password;
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

}

