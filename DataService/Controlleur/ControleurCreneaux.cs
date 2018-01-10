using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class ControleurCreneaux
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();

    //permet de recuperer les horaires de travails d'un salarié (35H/semaine)
    public static List<Creneaux> getCreneauxTravail()
    {
        List<Creneaux> creneaux = new List<Creneaux>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("SELECT * FROM DSMScreneaux", conn);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                creneaux.Add(new Creneaux(reader.GetString(1)));
            }
        }
        conn.Close();

        Console.WriteLine("jours de travail");

        return creneaux;
    }

    //permet de recuperer l'id d'un creneaux a partir de sa valeur
    public static int getCreneauId(string valeur)
    {
        int idCreneaux = -1;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMScreneaux where valeur=@valeur", conn);
        query.Parameters.AddWithValue("@valeur", valeur);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                idCreneaux = int.Parse(reader.GetString(0));
            }
        }
        conn.Close();

        Console.WriteLine("getCreneauId " + valeur);

        return idCreneaux;
    }

    //permet de recuperer un creneaux a partir de sa valeur
    public static Creneaux getCreneau(int idCreneaux)
    {
        Creneaux creneau = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMScreneaux where idCreneaux=@idCreneaux", conn);
        query.Parameters.AddWithValue("@idCreneaux", idCreneaux);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                creneau = new Creneaux(reader.GetString(1));
            }
        }
        conn.Close();

        Console.WriteLine("getJour effectué");

        return creneau;
    }
}

