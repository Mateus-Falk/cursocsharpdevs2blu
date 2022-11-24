using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Main.Data
{
    public class ConnectionMySQL
    {
        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String DataBase { get; set; }
        public static String User { get; set; }
        public static String Password { get; set; }

        public static MySqlConnection GetConnection()
        {
            try
            {
                Server = "localhost";
                DataBase = "agendacontatosnew";
                User = "root";
                Password = "MinguiPetaBidu#3Dogs";
                ConnectionString = $"Persist Security Info=False;server={Server};database={DataBase};uid={User};server={Server};database={DataBase};uid={User};pwd='{Password}'";

                var conn = new MySqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message, "Erro ao Conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
    }
}
