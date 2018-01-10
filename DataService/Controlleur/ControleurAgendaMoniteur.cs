using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class ControleurAgendaMoniteur
{
    //permet d'avoir une instance de la connexion a la base de données en ligne 
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();

    //permet de un planning d'un moniteur lors de son inscription
    public static void ajouterPlanningMoniteur(string adresseMail)
    {
        int idMoniteur = ControleurMoniteur.getMoniteurId(adresseMail);
        List<Jour> jours = ControleurJour.getJoursTravail();
        List<Creneaux> creneaux = ControleurCreneaux.getCreneauxTravail();
        foreach (Jour jour in jours)
        {
            int idJour = ControleurJour.getJourId(jour.Jours);
            foreach (Creneaux creneau in creneaux)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                int idCreneau = ControleurCreneaux.getCreneauId(creneau.Creneau);
                cmd.CommandText = "INSERT INTO ladi.DSMSagendaMoniteur(idMoniteur,idJour,idCreneaux,valeur) VALUES(@idMoniteur,@idJour,@idCreneaux,@valeur)";
                cmd.Parameters.AddWithValue("@idMoniteur", idMoniteur);
                cmd.Parameters.AddWithValue("@idJour", idJour);
                cmd.Parameters.AddWithValue("@idCreneaux", idCreneau);
                cmd.Parameters.AddWithValue("@valeur", DisponibiliteMoniteur.DISPONIBLE);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
    }

    //retourne l'agenda complet d'un moniteur 
    public static List<AgendaMoniteur> getAgendaMoniteur(string adresseMail)
    {
        Moniteur moniteur = ControleurMoniteur.getMoniteur(adresseMail);
        List<AgendaMoniteur> agenda = new List<AgendaMoniteur>();
        conn.Open();
        MySqlCommand query = new MySqlCommand("select j.idJour, c.idCreneaux, a.valeur from ladi.DSMSagendaMoniteur a, ladi.DSMSjour j, ladi.DSMScreneaux c,ladi.DSMSpersonne p where a.idJour=j.idJour and a.idCreneaux=c.idCreneaux and a.idMoniteur = p.idPersonne and p.adresseMail =@adresseMail", conn);
        query.Parameters.AddWithValue("@adresseMail", adresseMail);


        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
                Jour jour = ControleurJour.getJour(reader.GetInt32(0));
                Creneaux creneau = ControleurCreneaux.getCreneau(reader.GetInt32(1));
                agenda.Add(new AgendaMoniteur(moniteur, jour, creneau, reader.GetInt32(2)));
            }
        }

        conn.Close();
        Console.WriteLine("agenda moniteur");
        return agenda;
    }

    //mets a jour le planning d'un moniteur lors d'une reservation 
    public static void miseAjourAgenda(Moniteur moniteur, string heure, DateTime jour)
    {
        int idCreneaux = ControleurCreneaux.getCreneauId(heure);
        int idJour = ControleurJour.getJourId(jour);
        int idMoniteur = ControleurMoniteur.getMoniteurId(moniteur.AdresseMail);
        Console.WriteLine("" + idMoniteur + " " + idJour + " " + idCreneaux);

        MySqlCommand query = new MySqlCommand("UPDATE ladi.DSMSagendaMoniteur SET valeur=@valeur WHERE idMoniteur=@idMoniteur and idCreneaux=@idCreneaux and idJour=@idJour", conn);
        query.Parameters.AddWithValue("@valeur", DisponibiliteMoniteur.INDISPONIBLE);
        query.Parameters.AddWithValue("@idMoniteur", idMoniteur);
        query.Parameters.AddWithValue("@idCreneaux", idCreneaux);
        query.Parameters.AddWithValue("@idJour", idJour);


        conn.Open();
        using (MySqlDataReader reader = query.ExecuteReader())
        {
            while (reader.Read())
            {
            }
        }
        conn.Close();
    }

}

