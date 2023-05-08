using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ADOvrai
{
    public class Livre
    {
        private int num;
        private string ISBN;
        private string titre;
        private string prix;
        private string editeur;
        private string annee;
        private string langue;
        private string numAuteur;
        private string numGenre;

        public int Num { get => num; set => num = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Prix { get => prix; set => prix = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public string Annee { get => annee; set => annee = value; }
        public string Langue { get => langue; set => langue = value; }
        public string NumAuteur { get => numAuteur; set => numAuteur = value; }
        public string NumGenre { get => numGenre; set => numGenre = value; }
    }
}
