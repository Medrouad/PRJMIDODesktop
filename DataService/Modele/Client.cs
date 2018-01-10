using System;

public class Client : Personne
{
    private string photo;

    //Constructeur d'un client en appelant le constructeur de le classe mere 
    public Client(string nom, string prenom, DateTime dateNaissance, string adresse, string telephone, string adresseMail, string photo) : base(nom, prenom, dateNaissance, adresse, telephone, adresseMail)
    {
        this.photo = photo;
    }

    //getter et setter 
    public string Photo
    {
        get { return photo; }
        set { photo = value; }
    }

}
