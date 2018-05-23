using System;
using System.Windows.Forms;
using Npgsql;
using System.Runtime;

namespace SchoolProject3_year1.Application1.dao
{
    public class PostgresSQL
    {
        private string _username;
        private string _server;
        private string _port;
        private string _database;
        private string _password;
        private NpgsqlConnection _connection;

        public PostgresSQL()
        {
            _username = "kncfbhyp";
            _password = "jEAp7CdRxw1Oprmxys6Jb4NeKNP0RLI7";
            _server = "horton.elephantsql.com";
            _port = "5432";
            _database = "kncfbhyp";
        }

        public void CreateConnection()
        {
            try
            {
              
                // PostgeSQL-style connection string
                var connstring = $"Server={_server};Port={_port};" +
                                 $"User Id={_username};Password={_password};Database={_database};";

                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                Connection = conn;

                //MessageBox.Show("YAY, we have a connection"); -fuck off
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            
        }

        public void CloseConnection()
        {
            Connection?.Close();
        }

        public NpgsqlDataReader QueryDataReader(string sql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sql, Connection);
            return command.ExecuteReader();
        }

        public object queryScalar(string sql)
        {
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(sql, Connection);

            // Execute the query and obtain the value of the first column of the first row
            return command.ExecuteScalar();
        }

        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public string Server
        {
            get => _server;
            set => _server = value;
        }

        public string Port
        {
            get => _port;
            set => _port = value;
        }

        public string Database
        {
            get => _database;
            set => _database = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public NpgsqlConnection Connection
        {
            get => _connection;
            set => _connection = value;
        }
    }
}