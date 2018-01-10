using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class ControleurClient
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();

    //permet l'inscription d'un nouveau client
    public static void enregistrerClient(string nom, string prenom, DateTime dateNaissance, string adresse, string telephone, string adresseMail, string photo)
    {
        Client client = new Client(nom, prenom, dateNaissance, adresse, telephone, adresseMail, photo);
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;


        cmd.CommandText = "INSERT INTO ladi.DSMSpersonne(nom,prenom,dateNaissance,adresse,telephone,adresseMail,type) VALUES(@nom,@prenom,@dateNaissance,@adresse,@telephone,@adresseMail,@type)";
        cmd.Parameters.AddWithValue("@nom", client.Nom);
        cmd.Parameters.AddWithValue("@prenom", client.Prenom);
        cmd.Parameters.AddWithValue("@dateNaissance", client.DateNaissance);
        cmd.Parameters.AddWithValue("@adresse", client.Adresse);
        cmd.Parameters.AddWithValue("@telephone", client.Telephone);
        cmd.Parameters.AddWithValue("@adresseMail", client.AdresseMail);
        cmd.Parameters.AddWithValue("@type", TypePersonne.CLIENT);
        cmd.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine("client ajouté");
    }

    //permet d'effectuer une recherche sur l'ensemble des clients 
    public static List<Client> rechercherClient(string nom, string prenom)
    {
        List<Client> clients = new List<Client>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpersonne where type=@type and (nom like @nom or prenom like @prenom)", conn);
        query.Parameters.AddWithValue("@type", TypePersonne.CLIENT);
        query.Parameters.AddWithValue("@nom", nom);
        query.Parameters.AddWithValue("@prenom", prenom);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
                clients.Add(new Client(reader.GetString(1), reader.GetString(2), Outils.convertirStringToDateTime(reader.GetString(3)), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(8)));
            }
        }
        conn.Close();

        Console.WriteLine("recherche effectué");

        return clients;
    }

    //permet de recuperer un client à partir d'un son id
    public static Client getClient(int idClient)
    {
        Client client = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpersonne where idPersonne=@idClient and type=@type", conn);
        query.Parameters.AddWithValue("@idClient", idClient);
        query.Parameters.AddWithValue("@type", TypePersonne.CLIENT);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                client = new Client(reader.GetString(1), reader.GetString(2), Outils.convertirStringToDateTime(reader.GetString(3)), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(8));
            }
        }
        conn.Close();

        Console.WriteLine("getClient effectué");

        return client;
    }

    //permet de recuperer un client à partir d'un son adresseMail qui est unique 
    public static Client getClient(string adresseMail)
    {
        Client client = null;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpersonne where adresseMail=@adresseMail and type=@type", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);
        query.Parameters.AddWithValue("@type", TypePersonne.CLIENT);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                client = new Client(reader.GetString(1), reader.GetString(2), Outils.convertirStringToDateTime(reader.GetString(3)), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(8));
            }
        }
        conn.Close();

        Console.WriteLine("getClient effectué par mail");

        return client;
    }

    //permet de recuperer le nombreHeure effective d'un client 
    public static int getNombreHeureEffectiveClient(string adresseMail)
    {
        conn.Open();
        MySqlCommand query = new MySqlCommand("select count(*) from ladi.DSMSreservation r,ladi.DSMSpersonne p  where r.idClient=p.idPersonne and r.realisee=1 and p.adresseMail=@adresseMail", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);
        Int32 count = Convert.ToInt32(query.ExecuteScalar());
        conn.Close();

        Console.WriteLine("nombre d'heure effective");
        return count;
    }

    //permet de recuperer l'id d'un client à partir d'un son adresseMail
    public static int getClientId(string adresseMail)
    {
        int idClient = -1;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpersonne where adresseMail=@adresseMail and type=@type", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);
        query.Parameters.AddWithValue("@type", TypePersonne.CLIENT);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                idClient = int.Parse(reader.GetString(0));
            }
        }
        conn.Close();

        Console.WriteLine("getClient effectué par mail");

        return idClient;
    }


}

