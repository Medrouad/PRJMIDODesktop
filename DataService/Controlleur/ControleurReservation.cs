using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class ControleurReservation
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();


    //permet d'enregistrer une reservation
    public static void enregistrerRerservation(string adresseMail, Moniteur moniteur, string heure, DateTime jour)
    {
        int idClient = ControleurClient.getClientId(adresseMail);
        int idMoniteur = ControleurMoniteur.getMoniteurId(moniteur.AdresseMail);
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        Vehicule vehicule = ControleurVehicule.getVehiculeDispo(heure, jour);
        int idVehicule = ControleurVehicule.getVehiculeId(vehicule.Immatriculation);
        cmd.CommandText = "INSERT INTO ladi.DSMSreservation(idClient,idMoniteur,idVehicule,date) VALUES(@idClient,@idMoniteur,@idVehicule,@date)";
        cmd.Parameters.AddWithValue("@idClient", idClient);
        cmd.Parameters.AddWithValue("@idMoniteur", idMoniteur);
        cmd.Parameters.AddWithValue("@idVehicule", idVehicule);
        cmd.Parameters.AddWithValue("@date", Outils.convertirDateFormat(Outils.convertirStringToDateTime(Outils.fusion(jour, heure))));
        cmd.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine("reservation ajouté");
    }

    //permet de recuperer tous les reservations d'un client à partir d'un idclient
    public static List<Reservation> getReservationClient(int idClient)
    {
        List<Reservation> reservations = new List<Reservation>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSreservation where realisee=0 and idClient=@idClient", conn);
        query.Parameters.AddWithValue("@idClient", idClient);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                reservations.Add(new Reservation(ControleurClient.getClient(idClient), ControleurMoniteur.getMoniteur(reader.GetInt32(2)), ControleurVehicule.getVehicule(reader.GetInt32(3)), Outils.convertirStringToDateTime(reader.GetString(4))));
            }
        }

        conn.Close();
        Console.WriteLine("reservations");
        return reservations;
    }

     //permet de recuperer tous les reservations d'un client à partir d'une adresseMail
    public static List<Reservation> getReservationClient(string adresseMail)
    {
        List<Reservation> reservations = new List<Reservation>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSreservation r,ladi.DSMSpersonne p  where r.idClient=p.idPersonne and r.realisee=0 and p.adresseMail=@adresseMail", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                reservations.Add(new Reservation(ControleurClient.getClient(adresseMail), ControleurMoniteur.getMoniteur(reader.GetInt32(2)), ControleurVehicule.getVehicule(reader.GetInt32(3)), Outils.convertirStringToDateTime(reader.GetString(4))));
            }
        }

        conn.Close();
        Console.WriteLine("reservations");
        return reservations;
    }

     //permet de recuperer tous les reservations d'un véhicule à partir d'une adresseMail
    public static List<Reservation> getReservationVehicule(string immatriculation)
    {
        List<Reservation> reservations = new List<Reservation>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select * from ladi.DSMSreservation r,ladi.DSMSvehicule v where r.idVehicule=v.idVehicule and r.realisee=0 and v.immatriculation=@immatriculation", conn);
        query.Parameters.AddWithValue("@immatriculation", immatriculation);

        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                reservations.Add(new Reservation(ControleurClient.getClient(reader.GetInt32(1)), ControleurMoniteur.getMoniteur(reader.GetInt32(2)), ControleurVehicule.getVehicule(immatriculation), Outils.convertirStringToDateTime(reader.GetString(4))));
            }
        }

        conn.Close();
        Console.WriteLine("reservations");
        return reservations;
    }





}

