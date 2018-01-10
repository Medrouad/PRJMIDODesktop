using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class GestionReservation
{

    //permet d'effectuer une reservation
    public static int effectuerReservation(string adresseMail, string heure, DateTime jour)
    {
        Moniteur moniteur = ControleurMoniteur.getMoniteurDisponible(heure, jour);
        if (moniteur == null)
            return -1;
        else
        {
            Console.WriteLine(moniteur.AdresseMail);
            Vehicule vehicule = ControleurVehicule.getVehiculeDispo(heure, jour);
            if (vehicule == null)
            {
                return 0;
            }
            else
            {
                int idVehicule = ControleurVehicule.getVehiculeId(vehicule.Immatriculation);
                Console.WriteLine(idVehicule);
                ControleurReservation.enregistrerRerservation(adresseMail, moniteur, heure, jour);
                ControleurAgendaMoniteur.miseAjourAgenda(moniteur, heure, jour);
                return 1;

            }
        }
    }
}
