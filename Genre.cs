using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ADOvrai
{
    public class Genre
    {
        private int num;
        private string libelle = "";

        public string Libelle { get => libelle; set => libelle = value; }
        public int Num { get => num; set => num = value; }

    }
}
