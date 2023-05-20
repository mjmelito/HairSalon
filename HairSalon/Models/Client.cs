using System.Collections.Generic;
using MySqlConnector;

namespace HairSalon.Models
{
  public class Client
  {
    public string Name { get; set; }
    public int Id { get; set; }

    public Client(string name)
    {
      Name = name;
    }
    public Client(string name, int id)
    {
      Name = name;
      Id = id;
    }

    public override bool Equals(System.Object otherClient)
    {
      if (!(otherClient is Client))
      {
        return false;
      }
      else
      {
        Client newClient = (Client) otherClient;
        bool idEquality = (this.Id == newClient.Id);
        bool nameEquality = (this.Name == newClient.Name);
        return (idEquality && nameEquality);
      }
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public void Save()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

      cmd.CommandText = "INSERT INTO clients (name) VALUES (@clientName);";

      MySqlParameter param = new MySqlParameter();
      param.ParameterName = "@clientName";
      param.Value = this.Name;

      cmd.Parameters.Add(param);    

      cmd.ExecuteNonQuery();

      Id = (int) cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static Client Find(int id)
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = "SELECT * FROM `clients` WHERE id = @ThisId;";

      MySqlParameter param = new MySqlParameter();
      param.ParameterName = "@ThisId";
      param.Value = id;

      cmd.Parameters.Add(param);

      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      int clientId = 0;
      string clientName = "";
      while (rdr.Read())
      {
        clientId = rdr.GetInt32(0);
        clientName = rdr.GetString(1);
      }
      Client foundClient = new Client(clientName, clientId);

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return foundClient;
    }

    public static List<Client> GetAll()
    {
      List<Client> allClients = new List<Client> { };

      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = "SELECT * FROM clients;";

      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
          int clientId = rdr.GetInt32(0);
          string clientName = rdr.GetString(1);
          Client newClient = new Client(clientName, clientId);
          allClients.Add(newClient);
      }
      conn.Close();
      if (conn != null)
      {
          conn.Dispose();
      }
      return allClients;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      conn.Open();
      
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = "DELETE FROM clients;";
      cmd.ExecuteNonQuery();

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
  }
}
