using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ADOvrai
{
    internal class Connection
    {
        private static string connectionString = "server=btssio.dedyn.io;port=3306;Database=CADOTDY_biblio;Uid=CADOTDY;password=11022003";
        private static MySqlConnection maConnection = new MySqlConnection(connectionString);

        public static MySqlConnection MaConnection
        {
            get { return Connection.maConnection; }
        }
    }
}
