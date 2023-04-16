using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ADOvrai
{
    public class Adherent
    {
        private int num;
        private string nom = "";
        private string prenom = "";
        private string adrRue = "";
        private string adrCP = "";
        private string adrVille = "";
        private string tel = "";
        private string mel = "";

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Num { get => num; set => num = value; }
        public string AdrRue { get => adrRue; set => adrRue = value; }
        public string AdrCP { get => adrCP; set => adrCP = value; }
        public string AdrVille { get => adrVille; set => adrVille = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mel { get => mel; set => mel = value; }
    }
}
