using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


public class ControleurVehicule
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();

    //permet d'enregistrer un vehicule
    public static void enregistrerVehicule(string immatriculation, string marque, string modele, string couleur, string carburant, string photo)
    {
        Vehicule vehicule = new Vehicule(immatriculation, marque, modele, couleur, carburant, photo);
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;


        cmd.CommandText = "INSERT INTO ladi.DSMSvehicule(immatriculation,marque,modele,couleur,carburant,photo) VALUES(@immatriculation,@marque,@modele,@couleur,@carburant,@photo)";
        cmd.Parameters.AddWithValue("@immatriculation", vehicule.Immatriculation);
        cmd.Parameters.AddWithValue("@marque", vehicule.Marque);
        cmd.Parameters.AddWithValue("@modele", vehicule.Modele);
        cmd.Parameters.AddWithValue("@couleur", vehicule.Couleur);
        cmd.Parameters.AddWithValue("@carburant", vehicule.Carburant);
        cmd.Parameters.AddWithValue("@photo", vehicule.Photo);

        cmd.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine("vehicule ajouté");
    }

    //permet de recuperer un vehicule à partir de son id
    public static Vehicule getVehicule(int idVehicule)
    {
        Vehicule vehicule = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSvehicule where idVehicule=@idVehicule", conn);
        query.Parameters.AddWithValue("@idVehicule", idVehicule);


        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                vehicule = new Vehicule(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(5));
            }
        }
        conn.Close();

        Console.WriteLine("getVehicule effectué");

        return vehicule;
    }

    //permet de recuperer un vehicule à partir de son immatriculation
    public static Vehicule getVehicule(string immatriculation)
    {
        Vehicule vehicule = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSvehicule where immatriculation=@immatriculation", conn);
        query.Parameters.AddWithValue("@immatriculation", immatriculation);


        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                vehicule = new Vehicule(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), "");
            }
        }
        conn.Close();

        Console.WriteLine("getVehicule effectué");

        return vehicule;
    }

    //permet d'effectuer une recherche sur l'ensemble des vehicules
    public static List<Vehicule> rechercherVehicule(string immatriculation, string marque, string modele)
    {
        List<Vehicule> vehicules = new List<Vehicule>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSvehicule where immatriculation like @immatriculation or marque like @marque or modele like @modele", conn);
        query.Parameters.AddWithValue("@immatriculation", immatriculation);
        query.Parameters.AddWithValue("@marque", marque);
        query.Parameters.AddWithValue("@modele", modele);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
                vehicules.Add(new Vehicule(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6)));
            }
        }
        conn.Close();

        Console.WriteLine("recherche effectué");

        return vehicules;
    }

    //permet de recuperer les vehicules disponible à une date donnée
    public static Vehicule getVehiculeDispo(string heure, DateTime jour)
    {
        List<Vehicule> vehicules = new List<Vehicule>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("SELECT immatriculation,marque,modele,couleur,carburant FROM DSMSvehicule as a LEFT JOIN DSMSreservation as b on a.idVehicule = b.idVehicule where (date <> @date or date is null) and (realisee=0 or realisee is null) ", conn);
        string res = Outils.fusion(jour, heure);
        query.Parameters.AddWithValue("@date", res);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                vehicules.Add(new Vehicule(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), ""));
            }
        }
        conn.Close();
        if (vehicules.Count == 0)
        {
            return null;
        }
        Console.WriteLine("recherche vehicule disponible");
        return vehicules[0];
    }

    //permet de recuperer un vehicule à partir de son immatriculation
    public static int getVehiculeId(string immatriculation)
    {
        int idVehicule = -1;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSvehicule where immatriculation=@immatriculation", conn);
        query.Parameters.AddWithValue("@immatriculation", immatriculation);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                idVehicule = int.Parse(reader.GetString(0));
            }
        }
        conn.Close();

        Console.WriteLine("getVehicule par immatriculation");

        return idVehicule;
    }

}

