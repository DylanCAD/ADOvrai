using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ADOvrai
{
    public class ManagerAdherent
    {
        public static Adherent DonneAdherentDuReader(MySqlDataReader monReader)
        {
            Adherent unAdherent = new Adherent();
            unAdherent.Num = Convert.ToInt16(monReader["num"]);
            unAdherent.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string;
            unAdherent.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string;
            unAdherent.AdrRue = monReader["adrRue"] == DBNull.Value ? "" : monReader["adrRue"] as string;
            unAdherent.AdrCP = monReader["adrCP"] == DBNull.Value ? "" : monReader["adrCP"].ToString();
            unAdherent.AdrVille = monReader["adrVille"] == DBNull.Value ? "" : monReader["adrVille"] as string;
            unAdherent.Tel = monReader["tel"] == DBNull.Value ? "" : monReader["tel"] as string;
            unAdherent.Mel = monReader["mel"] == DBNull.Value ? "" : monReader["mel"] as string;
            return unAdherent;
        }
        public static List<Adherent> DonneAdherents()
        {
            List<Adherent> lesAdherents = new List<Adherent>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from adherent order by nom";
            monReader = maRequete.ExecuteReader();
            while (monReader.Read())
            {
                Adherent unAdherent = ManagerAdherent.DonneAdherentDuReader(monReader);
                lesAdherents.Add(unAdherent);
            }
            monReader.Close();
            Connection.MaConnection.Close();
            return lesAdherents;


        }
        public static Adherent DonneAdherentParId(int id)
        {
            Adherent unAdherent = new Adherent();
            return unAdherent;
        }
        public static bool ModifierAdherent(Adherent ad)
        {
            bool resultat = true;
            return resultat;
        }

        public static bool AjouterAdherent(Adherent ad)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into adherent set " +
                "nom=@paramNom, prenom=@paramPrenom, adrRue = @paramAdrRue, adrCP=@paramAdrCP, adrVille=@paramAdrVille, tel = @paramTel, mel = @paramMel, num = @paramNumAdherent";
            maRequete.Parameters.Clear();//annule tous les anciens paramètres
            // ajoute les paramètres de la requete de modification
            maRequete.Parameters.AddWithValue("@paramNom", ad.Nom);
            maRequete.Parameters.AddWithValue("@paramPrenom", ad.Prenom);
            maRequete.Parameters.AddWithValue("@paramAdrRue", ad.AdrRue);
            maRequete.Parameters.AddWithValue("@paramAdrCP", ad.AdrCP);
            maRequete.Parameters.AddWithValue("@paramAdrVille", ad.AdrVille);
            maRequete.Parameters.AddWithValue("@paramTel", ad.Tel);
            maRequete.Parameters.AddWithValue("@paramMel", ad.Mel);
            maRequete.Parameters.AddWithValue("@paramNumAdherent", ad.Num);
            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();
                Connection.MaConnection.Close();
                if (resultat > 0)
                {
                    reponse = true;
                }
                else
                {
                    throw new Exception("Une erreur s'est produite, l'adherent n'a pas été mis a jour");
                }
                return reponse;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static bool SupprimerAdherent(Adherent ad)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from adherent where " +
                "num = @paramNum";
            maRequete.Parameters.Clear();//annule tous les anciens paramètres
            // ajoute les paramètres de la requete de modification
            maRequete.Parameters.AddWithValue("@paramNum", ad.Num);
            const string message =
                "Etes vous sur de vouloir supprimer l'adherent";
            const string caption = "Suppression de l'adherent";
            var result = MessageBox.Show(message, caption,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            try
            {

                if (result == DialogResult.Yes)
                {
                    Connection.MaConnection.Open();
                    int resultat = maRequete.ExecuteNonQuery();
                    Connection.MaConnection.Close();
                    MessageBox.Show("L'adherent à bien été supprimé !");
                }
                //else
                //{
                //throw new Exception("Une erreur s'est produite, l'adherent n'a pas été mis a jour");
                //}
                return reponse;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
