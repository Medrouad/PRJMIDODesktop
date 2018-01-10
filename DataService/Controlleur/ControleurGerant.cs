using System;
using MySql.Data.MySqlClient;


public class ControleurGerant
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();

    //cas similaire à un client

    public static void enregistrerGerant(string nom, string prenom, DateTime dateNaissance, string adresse, string telephone, string adresseMail, string password)
    {
        Gerant gerant = new Gerant(nom, prenom, dateNaissance, adresse, telephone, adresseMail, password);
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;


        cmd.CommandText = "INSERT INTO ladi.DSMSpersonne(nom,prenom,dateNaissance,adresse,telephone,adresseMail,password,type) VALUES(@nom,@prenom,@dateNaissance,@adresse,@telephone,@adresseMail,@password,@type)";
        cmd.Parameters.AddWithValue("@nom", gerant.Nom);
        cmd.Parameters.AddWithValue("@prenom", gerant.Prenom);
        cmd.Parameters.AddWithValue("@dateNaissance", gerant.DateNaissance);
        cmd.Parameters.AddWithValue("@adresse", gerant.Adresse);
        cmd.Parameters.AddWithValue("@telephone", gerant.Telephone);
        cmd.Parameters.AddWithValue("@adresseMail", gerant.AdresseMail);
        cmd.Parameters.AddWithValue("@password", gerant.Password);
        cmd.Parameters.AddWithValue("@type", TypePersonne.GERANT);
        cmd.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine("gerant ajouté");
    }

    public static Gerant recuperGerantParMail(string adresseMail)
    {
        Gerant gerant = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("SELECT * FROM ladi.DSMSpersonne WHERE adresseMail='" + adresseMail + "'", conn);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                gerant = new Gerant(reader.GetString(1), reader.GetString(2), Outils.convertirStringToDateTime(reader.GetString(3)), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }
        }
        conn.Close();
        return gerant;
    }


    public static int connexionGerant(string adresseMail, string password)
    {
        Gerant gerant = ControleurGerant.recuperGerantParMail(adresseMail);
        if (gerant == null)
            return -1;
        else if (gerant.Password.Equals(password))
            return 1;
        else
            return 0;
    }

}

