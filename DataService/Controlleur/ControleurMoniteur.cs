using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


public class ControleurMoniteur
{

    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();

    //cas similaire à un client

    public static void enregistrerMoniteur(string nom, string prenom, DateTime dateNaissance, string adresse, string telephone, string adresseMail, string photo)
    {
        Moniteur moniteur = new Moniteur(nom, prenom, dateNaissance, adresse, telephone, adresseMail, photo);
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;


        cmd.CommandText = "INSERT INTO ladi.DSMSpersonne(nom,prenom,dateNaissance,adresse,telephone,adresseMail,photo,type) VALUES(@nom,@prenom,@dateNaissance,@adresse,@telephone,@adresseMail,@photo,@type)";
        cmd.Parameters.AddWithValue("@nom", moniteur.Nom);
        cmd.Parameters.AddWithValue("@prenom", moniteur.Prenom);
        cmd.Parameters.AddWithValue("@dateNaissance", moniteur.DateNaissance);
        cmd.Parameters.AddWithValue("@adresse", moniteur.Adresse);
        cmd.Parameters.AddWithValue("@telephone", moniteur.Telephone);
        cmd.Parameters.AddWithValue("@adresseMail", moniteur.AdresseMail);
        cmd.Parameters.AddWithValue("@photo", moniteur.Photo);
        cmd.Parameters.AddWithValue("@type", TypePersonne.MONITEUR);
        cmd.ExecuteNonQuery();
        conn.Close();
        ControleurAgendaMoniteur.ajouterPlanningMoniteur(moniteur.AdresseMail);
        Console.WriteLine("moniteur ajouté");
    }

    public static Moniteur getMoniteur(int idMoniteur)
    {
        Moniteur moniteur = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpersonne where idPersonne=@idMoniteur and type=@type", conn);
        query.Parameters.AddWithValue("@idMoniteur", idMoniteur);
        query.Parameters.AddWithValue("@type", TypePersonne.MONITEUR);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                moniteur = new Moniteur(reader.GetString(1), reader.GetString(2), Outils.convertirStringToDateTime(reader.GetString(3)), reader.GetString(4), reader.GetString(5), reader.GetString(6), "");
            }
        }
        conn.Close();

        Console.WriteLine("getMoniteur effectué");

        return moniteur;
    }

    public static Moniteur getMoniteur(string adresseMail)
    {
        Moniteur moniteur = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpersonne where adresseMail=@adresseMail and type=@type", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);
        query.Parameters.AddWithValue("@type", TypePersonne.MONITEUR);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                moniteur = new Moniteur(reader.GetString(1), reader.GetString(2), Outils.convertirStringToDateTime(reader.GetString(3)), reader.GetString(4), reader.GetString(5), reader.GetString(6), "");
            }
        }
        conn.Close();

        Console.WriteLine("getClient effectué par mail");

        return moniteur;
    }

    public static List<Moniteur> rechercherMoniteur(string nom, string prenom)
    {
        List<Moniteur> moniteurs = new List<Moniteur>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpersonne where type=@type and (nom like @nom or prenom like @prenom)", conn);
        query.Parameters.AddWithValue("@type", TypePersonne.MONITEUR);
        query.Parameters.AddWithValue("@nom", nom);
        query.Parameters.AddWithValue("@prenom", prenom);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
                moniteurs.Add(new Moniteur(reader.GetString(1), reader.GetString(2), Outils.convertirStringToDateTime(reader.GetString(3)), reader.GetString(4), reader.GetString(5), reader.GetString(6), ""));
            }
        }
        conn.Close();

        Console.WriteLine("recherche effectué");

        return moniteurs;
    }


    public static int getMoniteurId(string adresseMail)
    {
        int idMoniteur = -1;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpersonne where adresseMail=@adresseMail and type=@type", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);
        query.Parameters.AddWithValue("@type", TypePersonne.MONITEUR);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                idMoniteur = int.Parse(reader.GetString(0));
            }
        }
        conn.Close();

        Console.WriteLine("getMoniteur effectué par mail");

        return idMoniteur;
    }

    public static Moniteur getMoniteurDisponible(string heure, DateTime jour)
    {
        List<Moniteur> moniteurs = new List<Moniteur>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select p.nom, p.prenom, p.dateNaissance, p.adresse, p.telephone, p.adresseMail from ladi.DSMSagendaMoniteur a,ladi.DSMSjour j, ladi.DSMScreneaux c, ladi.DSMSpersonne p where a.idJour=j.idJour and a.idCreneaux=c.idCreneaux and a.idMoniteur = p.idPersonne and a.valeur=@valeurDispo and j.date=@jour and c.valeur=@valeurHeure", conn);
        query.Parameters.AddWithValue("@valeurDispo", DisponibiliteMoniteur.DISPONIBLE);
        query.Parameters.AddWithValue("@valeurHeure", heure);
        query.Parameters.AddWithValue("@jour", Outils.convertirDateFormat2(jour));


        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                moniteurs.Add(new Moniteur(reader.GetString(0), reader.GetString(1), Outils.convertirStringToDateTime(reader.GetString(2)), reader.GetString(3), reader.GetString(4), reader.GetString(5), ""));
            }
        }
        conn.Close();

        if (moniteurs.Count == 0)
        {
            return null;
        }
        Moniteur moniteur = moniteurs[0];
        Console.WriteLine("moniteur disponible");
        return moniteur;
    }

}
