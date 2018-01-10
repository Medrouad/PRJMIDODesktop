using System;


namespace TestDataService
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string heure = "10";
            DateTime date = Outils.convertirStringToDateTime("14/04/2017 21:08:44");
            string res = Outils.fusion(date, heure);
            Console.WriteLine(res);

            Vehicule v = ControleurVehicule.getVehiculeDispo(heure, date);
            if (v == null)
            {
                Console.WriteLine("null");
            }
            
        }
    }
}

