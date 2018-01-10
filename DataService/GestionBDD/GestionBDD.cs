using System;
using MySql.Data.MySqlClient;
using System.Text;
using System.Data;

public class GestionBDD
{
	//Attributs de la classe
	private string hostname;
	private string userid;
	private string password;
	private string databasename;
	MySqlConnection conn;

    //fichier recuperer du TD

	//Constructeur
	public GestionBDD(string host, string user, string pwd, string bdd)
	{
		hostname = host;
		userid = user;
		password = pwd;
		databasename = bdd;
		conn = Connection();
	}

	//Getter et Setter
	public string Hostname
	{
		get { return hostname; }
		set { hostname = value; }
	}

	public string Userid
	{
		get { return userid; }
		set { userid = value; }
	}

	public string Password
	{
		get { return password; }
		set { password = value; }
	}

	public string Databasename
	{
		get { return databasename; }
		set { databasename = value; }
	}

	//Méthodes d'instance

	//1 - Renvoie une connexion à partir des attributs de la classe
	public MySqlConnection Connection()
	{
		try
		{
			MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
			connectionString.Server = hostname;
			connectionString.UserID = userid;
			connectionString.Password = password;
			connectionString.Database = databasename;
			//connectionString.Port = 8889;
			conn = new MySqlConnection(connectionString.ToString());
			return conn;
		}
		catch (MySql.Data.MySqlClient.MySqlException e)
		{
			Console.WriteLine(e.Message);

		}
		return null;
	}

	//2 - Affiche la version courante du SGBD MySQL
	public void VersionCouranteSGBD()
	{
		try{
			conn.Open();
			Console.WriteLine(conn.ServerVersion);
			conn.Close();
		}
		catch (MySql.Data.MySqlClient.MySqlException e)
		{
			Console.WriteLine(e.Message);

		}

	}

	//3 - Affiche la date et l'heure courante du serveur de base de données
	public void DateCouranteSGBD()
	{
		conn.Open();
		string statement = "select NOW()";
		MySqlCommand cmd = new MySqlCommand(statement, conn);
		DateTime date = (DateTime)cmd.ExecuteScalar();
		Console.WriteLine(date.ToString());
		conn.Close();
	}

	//4 - Affiche la version, la date et l'heure courante et l'utilisateur connecté
	public void InfosCompletesSGBD()
	{
		Console.WriteLine("UserName: {0}", Environment.UserName);
		DateCouranteSGBD();
		VersionCouranteSGBD();
	}

	//5 - Affiche la liste des utilisateurs (les schémas) de la base de données
	public void ListeUtilisateurBDD()
	{
		conn.Open();
		MySqlCommand query = new MySqlCommand("SELECT host, user FROM mysql.user", conn);
		using (MySqlDataReader reader = query.ExecuteReader())
		{
			while (reader.Read())
			{
				Console.WriteLine(reader.GetString(1));
			}
		}
		conn.Close();
	}

	//6 - Création d'un compte avec attribution des privilèges sur la base de données courante
	public void CreerUtilisateur(string user_name, string password)
	{
		conn.Open();
		MySqlCommand query = new MySqlCommand("CREATE USER '" + user_name + "'@'" + Hostname + "' IDENTIFIED BY '" + password + "';", conn);
		query.ExecuteScalar();
		conn.Close();
	}

	//7 - Affiche la liste des tables disponibles sur la base de données courante
	public void ListeTablesBDD()
	{
		conn.Open();
		MySqlCommand query = new MySqlCommand("SHOW TABLES IN " + Databasename, conn);
		using (MySqlDataReader reader = query.ExecuteReader())
		{
			while (reader.Read())
			{
				Console.WriteLine(reader.GetString(0));
			}
		}
		conn.Close();
	}

	//8 - Exécute une requete d'insertion non paramétrée. La requête est passée en argument
	public int ExecuteNonParamInsertQuery(string statement)
	{
		conn.Open();
		MySqlCommand query = new MySqlCommand(statement, conn);
		query.ExecuteScalar();
		conn.Close();
		return 0;
	}

	//9 - Exécute une requete de selection sur la table passée en argument
	public void ExecuteSelectQuery(string table_name)
	{
		conn.Open();
		string statement = "select * from " + table_name;
		MySqlCommand query = new MySqlCommand(statement, conn);
		using (MySqlDataReader reader = query.ExecuteReader())
		{
			while (reader.Read())
			{
				Console.WriteLine(reader.GetString(1));
			}
		}
		conn.Close();
	}

}