using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
class GestionPaiement
    {
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();


    //permet de calculer le montant theorique que doit payé un client
    public static double montantTheorique(string adresseMail)
    {
        int idClient = ControleurClient.getClientId(adresseMail);
        double res = 0;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select COUNT(*) from ladi.DSMSreservation where idClient=@idClient", conn);
        query.Parameters.AddWithValue("@idClient", idClient);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {        
                res = Convert.ToDouble(reader.GetString(0));
            }
        }
        conn.Close();

        return res*Outils.prix;
    }


     //permet de calculer le montant reelement payé par un client
    public static double montantPaye(string adresseMail)
    {
        int idClient = ControleurClient.getClientId(adresseMail);
        double res = 0;
        conn.Open();
        MySqlCommand query = new MySqlCommand("select SUM(montant) from ladi.DSMSpaiement where idClient=@idClient", conn);
        query.Parameters.AddWithValue("@idClient", idClient);
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                res = Convert.ToDouble(reader.GetString(0));
            }
        }
        conn.Close();

        return res;
    }

     //permet de calculer le montant que doit le client a l'auto ecole ou que le client a payé en trop 
    public static double calculPaiement(string adresseMail) {
        double montantTheorique = GestionPaiement.montantTheorique(adresseMail);
        double montantPaye = GestionPaiement.montantPaye(adresseMail);
        return montantTheorique-montantPaye;
    }
}

