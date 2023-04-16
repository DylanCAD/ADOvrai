using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ADOvrai
{
    public class Auteur
    { 
    private int num;
    private string nom = "";
    private string prenom = "";
    private string nationalite = "";

    public string Nationalite { get => nationalite; set => nationalite = value; }
    public string Prenom { get => prenom; set => prenom = value; }
    public string Nom { get => nom; set => nom = value; }
    public int Num { get => num; set => num = value; }
    }
}
