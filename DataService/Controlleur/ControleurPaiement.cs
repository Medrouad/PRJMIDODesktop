using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class ControleurPaiement
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();


    //permet d'enregistrer un paiement
    public static void enregistrerPaiement(string adresseMail, string typePaiement, double montant)
    {
        int idClient = ControleurClient.getClientId(adresseMail);
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "INSERT INTO ladi.DSMSpaiement(idClient,typePaiement,date,montant) VALUES(@idClient,@typePaiement,@date,@montant)";
        cmd.Parameters.AddWithValue("@idClient", idClient);
        cmd.Parameters.AddWithValue("@typePaiement", typePaiement);
        cmd.Parameters.AddWithValue("@date", DateTime.Now);
        cmd.Parameters.AddWithValue("@montant", montant);
        cmd.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine("paiement ajouté");
    }

     //permet de recuperer tous les paiement d'un client
    public static List<Paiement> getPaiementClient(int idClient)
    {
        List<Paiement> paiements = new List<Paiement>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSpaiement where idClient=@idClient", conn);
        query.Parameters.AddWithValue("@idClient", idClient);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                paiements.Add(new Paiement(ControleurClient.getClient(idClient), reader.GetString(2), reader.GetDateTime(3), reader.GetDouble(4)));
            }
        }

        conn.Close();
        Console.WriteLine("paiements");
        return paiements;
    }
}

