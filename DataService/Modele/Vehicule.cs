using System;

public class Vehicule
{

    private string immatriculation;
    private string marque;
    private string modele;
    private string couleur;
    private string carburant;
    private string photo;




    public Vehicule(string immatriculation, string marque, string modele, string couleur, string carburant, string photo)
    {
        this.immatriculation = immatriculation;
        this.marque = marque;
        this.modele = modele;
        this.couleur = couleur;
        this.carburant = carburant;
        this.photo = photo;
    }

    public string Immatriculation
    {
        get { return immatriculation; }
        set { immatriculation = value; }
    }

    public string Marque
    {
        get { return marque; }
        set { marque = value; }
    }

    public string Modele
    {
        get { return modele; }
        set { modele = value; }
    }

    public string Couleur
    {
        get { return couleur; }
        set { couleur = value; }
    }

    public string Carburant
    {
        get { return carburant; }
        set { carburant = value; }
    }

    public string Photo
    {
        get { return photo; }
        set { photo = value; }
    }
}

