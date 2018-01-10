using System;

public class Outils
{
    public static double prix = 50;
    public static DateTime convertirStringToDateTime(string date)
    {
        return DateTime.Parse(date);
    }

    public static string convertirDateFormat(DateTime date)
    {
        return date.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public static string fusion(DateTime jour, string heure)
    {
        string jour2 = jour.ToString("yyyy-MM-dd HH:mm:ss").Split(' ')[0];
        string date = jour2 + " " + heure + ":00:00";
        return date;
    }

    public static string convertirDateFormat2(DateTime jour)
    {
        string jour2 = jour.ToString("yyyy-MM-dd HH:mm:ss").Split(' ')[0];
        string date = jour2 + " 00:00:00";
        return date;
    }
}

