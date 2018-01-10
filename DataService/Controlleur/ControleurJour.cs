using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class ControleurJour
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();

    //permet de recuperer les jours de travail 
    public static List<Jour> getJoursTravail()
    {
        List<Jour> jours = new List<Jour>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("SELECT * FROM DSMSjour WHERE jourSemaine NOT IN (7, 1)", conn);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                jours.Add(new Jour(Outils.convertirStringToDateTime(reader.GetString(1))));
            }
        }
        conn.Close();

        Console.WriteLine("jours de travail");

        return jours;
    }

    //permet de recuperer l'id d'un jour a partir de sa valeur
    public static int getJourId(DateTime date)
    {
        int idJour = -1;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSjour where date=@date", conn);
        string res = Outils.convertirDateFormat(date).Split(' ')[0];
        Console.WriteLine("=======>" + res);
        string res1 = res + " 00:00:00";
        query.Parameters.AddWithValue("@date",res1);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                idJour = int.Parse(reader.GetString(0));
            }
        }
        conn.Close();

        Console.WriteLine("getJourId " + date);

        return idJour;
    }

    //permet de recuperer un jour a partir de sa valeur
    public static Jour getJour(int idJour)
    {
        Jour jour = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSjour where idJour=@idJour", conn);
        query.Parameters.AddWithValue("@idJour", idJour);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                jour = new Jour(Outils.convertirStringToDateTime(reader.GetString(1)));
            }
        }
        conn.Close();

        Console.WriteLine("getJour effectué");

        return jour;
    }

}

