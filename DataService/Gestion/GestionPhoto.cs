using System;
using System.IO;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Data;
using System.Collections.Generic;

public class GestionPhoto
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();

    //permet d'inserer une image d'un client en bd
    public static void insererImageClient(string adresseMail, string image)
    {
        int idClient = ControleurClient.getClientId(adresseMail);

        MySqlCommand query = new MySqlCommand("UPDATE ladi.DSMSpersonne SET photo=@photo WHERE idPersonne=@idClient ", conn);
        query.Parameters.AddWithValue("@photo", image);
        query.Parameters.AddWithValue("@idClient", idClient);
        conn.Open();
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
            }
        }
        conn.Close();
    }

    //permet d'inserer une image d'un moniteur en bd
    public static void insererImageMoniteur(string adresseMail, string image)
    {
        int idMoniteur = ControleurMoniteur.getMoniteurId(adresseMail);

        MySqlCommand query = new MySqlCommand("UPDATE ladi.DSMSpersonne SET photo=@photo WHERE idPersonne=@idMoniteur ", conn);
        query.Parameters.AddWithValue("@photo", image);
        query.Parameters.AddWithValue("@idMoniteur", idMoniteur);
        conn.Open();
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
            }
        }
        conn.Close();
    }

    //permet d'inserer une image d'un vehicule en bd
    public static void insererImageVehicule(string immatriculation, string image)
    {

        MySqlCommand query = new MySqlCommand("UPDATE ladi.DSMSvehicule SET photo=@photo WHERE immatriculation=@immatriculation ", conn);
        query.Parameters.AddWithValue("@photo", image);
        query.Parameters.AddWithValue("@immatriculation", immatriculation);
        conn.Open();
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
            }
        }
        conn.Close();
    }

    //permet d'afficher une image d'un client depuis bd dans l'IHM
    public static string afficherImageClientS(string adresseMail)
    {
        string res = "";
        conn.Open();
        MySqlCommand query = new MySqlCommand("select photo from ladi.DSMSpersonne where adresseMail=@adresseMail and type=@type", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);
        query.Parameters.AddWithValue("@type", TypePersonne.CLIENT);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                res = reader.GetString(0);
            }
        }
        conn.Close();

        return res;
    }

    //permet d'afficher une image d'un client depuis bd dans l'IHM
    public static string afficherImageClient(string adresseMail)
    {
        string res = "";
        conn.Open();
        MySqlCommand query = new MySqlCommand("select photo from ladi.DSMSpersonne where adresseMail=@adresseMail and type=@type", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);
        query.Parameters.AddWithValue("@type", TypePersonne.CLIENT);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                res = reader.GetString(0);
            }
        }
        conn.Close();

        return res;
    }


    //permet d'afficher une image d'un moniteur depuis bd dans l'IHM
    public static string afficherImageMoniteur(string adresseMail)
    {
        string res = "";
        conn.Open();
        MySqlCommand query = new MySqlCommand("select photo from ladi.DSMSpersonne where adresseMail=@adresseMail and type=@type", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);
        query.Parameters.AddWithValue("@type", TypePersonne.MONITEUR);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                res = reader.GetString(0);
            }
        }
        conn.Close();

        return res;
    }

    //permet d'afficher une image d'un vehicule depuis bd dans l'IHM
    public static string afficherImageVoiture(string immatriculation)
    {
        string res = "";
        conn.Open();
        MySqlCommand query = new MySqlCommand("select photo from ladi.DSMSvehicule where immatriculation=@immatriculation", conn);
        query.Parameters.AddWithValue("@immatriculation", immatriculation);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                res = reader.GetString(0);
            }
        }
        conn.Close();

        return res;
    }
}

/*public static void insererImageClient(string adresseMail, Image image)
  {
	  int idClient = ControleurClient.getClientId(adresseMail);

	  MemoryStream ms = new MemoryStream();
	  image.Save(ms, image.RawFormat);
	  byte[] img = ms.ToArray();

	  MySqlCommand query = new MySqlCommand("UPDATE ladi.DSMSpersonne SET photo=@photo WHERE idPersonne=@idClient ", conn);
	  query.Parameters.AddWithValue("@photo", img);
	  query.Parameters.AddWithValue("@idClient", idClient);
	  conn.Open();
	  using (MySqlDataReader reader = query.ExecuteReader())
	  {
		  while (reader.Read())
		  {
		  }
	  }
	  conn.Close();
  }

public static void insererImageMoniteur(string adresseMail, Image image)
{
	int idMoniteur = ControleurMoniteur.getMoniteurId(adresseMail);

	MemoryStream ms = new MemoryStream();
	image.Save(ms, image.RawFormat);
	byte[] img = ms.ToArray();

	MySqlCommand query = new MySqlCommand("UPDATE ladi.DSMSpersonne SET photo=@photo WHERE idPersonne=@idMoniteur ", conn);
	query.Parameters.AddWithValue("@photo", img);
	query.Parameters.AddWithValue("@idMoniteur", idMoniteur);
	conn.Open();
	using (MySqlDataReader reader = query.ExecuteReader())
	{
		while (reader.Read())
		{
		}
	}
	conn.Close();
}

public static MemoryStream afficherImageClient(string adresseMail)
{
	conn.Open();
	string query = "select photo from ladi.DSMSpersonne where adresseMail=\"" + adresseMail + "\"";
	MySqlCommand cmd = new MySqlCommand(query, conn);
	cmd.ExecuteNonQuery();

	DataTable dataTable = new DataTable();
	MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(query, conn);

	sqlAdapter.Fill(dataTable);
	byte[] arrary = new byte[0];
	arrary = (byte[])dataTable.Rows[0][0];
	MemoryStream ms = new MemoryStream(arrary);
	//Image image = Image.FromStream(ms);
	conn.Close();
	return ms;
}*/
