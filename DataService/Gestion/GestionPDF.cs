using System;
using System.IO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;




public class GestionPDF
{
    private static MySqlConnection conn = new GestionBDD("vps197081.ovh.net", "ladi", "atoz", "ladi").Connection();


    //permet de generer le pdf pour un client
    public static void genererPDFClient(string adresseMail)
    {
        Client client = ControleurClient.getClient(adresseMail);

        using (FileStream stream = new FileStream("..//..//Client_"+client.Nom+"_"+client.Prenom+".pdf", FileMode.Create))
        {
            int nombreHeureEffective = ControleurClient.getNombreHeureEffectiveClient(adresseMail);
            List<Reservation> reservations = ControleurReservation.getReservationClient(client.AdresseMail);

            Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, stream);
            pdfDoc.Open();
            Paragraph p1 = new Paragraph();
            p1.Add(new Phrase("\n\n\n   " + client.Nom + " " + client.Prenom,new Font(Font.NORMAL,24)));
            p1.Add(new Phrase("\n\n\t   " + client.Adresse, new Font(Font.NORMAL, 24)));
            p1.Add(new Phrase("\n\n\t   " + client.Telephone, new Font(Font.NORMAL, 24)));
            p1.Add(new Phrase("\n\n\t   " + client.AdresseMail, new Font(Font.NORMAL, 24)));
            pdfDoc.Add(p1);

            Image logo = Image.GetInstance("C:\\Users\\med\\Documents\\Visual Studio 2015\\Projects\\DesktopIHM\\DesktopIHM\\Images\\téléchargement.jpg");
            logo.SetAbsolutePosition(900, 1400);
            pdfDoc.Add(logo);
            Phrase ph1 = new Phrase("\n\n\n   Nombre d'heure effectives : " + nombreHeureEffective+"H", new Font(Font.NORMAL, 24));
            pdfDoc.Add(ph1);
            Phrase ph2 = new Phrase("\n\n\n   Mon planning : ", new Font(Font.NORMAL, 24));
            pdfDoc.Add(ph2);
            PdfPTable table = new PdfPTable(3);
            foreach(Reservation reservation in reservations)
            {
                table.AddCell(reservation.Moniteur.Nom + " " + reservation.Moniteur.Prenom);
                table.AddCell(reservation.Vehicule.Immatriculation);
                table.AddCell(reservation.Date.ToString());
            }
            pdfDoc.Add(table);

            double res = GestionPaiement.calculPaiement(client.AdresseMail);
            if (res < 0)
            {
                Phrase ph3 = new Phrase("\n\n\n   L'auto école vous doit : "+Math.Abs(res)+"€", new Font(Font.NORMAL, 24));
                pdfDoc.Add(ph3);
            }
            else
            {
                Phrase ph3 = new Phrase("\n\n\n   Vous devez  : " + res + "€ à l'auto école", new Font(Font.NORMAL, 24));
                pdfDoc.Add(ph3);
            }
           
           

            pdfDoc.Close();
            stream.Close();
        }

    }

    //permet de generer le pdf pour un moniteur(planning)
    public static void genererPDFMoniteur(string adresseMail)
    {
        Moniteur moniteur = ControleurMoniteur.getMoniteur(adresseMail);

        using (FileStream stream = new FileStream("..//..//Moniteur_" + moniteur.Nom + "_" + moniteur.Prenom + ".pdf", FileMode.Create))
        {
            List<AgendaMoniteur> planning = ControleurAgendaMoniteur.getAgendaMoniteur(moniteur.AdresseMail);

            Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, stream);
            pdfDoc.Open();
            Paragraph p1 = new Paragraph();
            p1.Add(new Phrase("\n\n\n   " + moniteur.Nom + " " + moniteur.Prenom, new Font(Font.NORMAL, 24)));
            p1.Add(new Phrase("\n\n\t   " + moniteur.Adresse, new Font(Font.NORMAL, 24)));
            p1.Add(new Phrase("\n\n\t   " + moniteur.Telephone, new Font(Font.NORMAL, 24)));
            p1.Add(new Phrase("\n\n\t   " + moniteur.AdresseMail, new Font(Font.NORMAL, 24)));
            pdfDoc.Add(p1);

            Image logo = Image.GetInstance("C:\\Users\\med\\Documents\\Visual Studio 2015\\Projects\\DesktopIHM\\DesktopIHM\\Images\\téléchargement.jpg");
            logo.SetAbsolutePosition(900, 1400);
            pdfDoc.Add(logo);
            Phrase ph2 = new Phrase("\n\n\n   Mon planning : ", new Font(Font.NORMAL, 24));
            pdfDoc.Add(ph2);
            PdfPTable table = new PdfPTable(3);
            string etat = "";
            foreach (AgendaMoniteur a in planning)
            {
                if (a.Valeur == 1)
                    etat = "disponible";
                else
                    etat = "indisponible";
                table.AddCell(a.Creneau.Creneau + "h");
                table.AddCell(a.Jour.Jours.ToString().Split(' ')[0]);
                table.AddCell(etat);
            }
            pdfDoc.Add(table);




            pdfDoc.Close();
            stream.Close();
        }

    }
}
