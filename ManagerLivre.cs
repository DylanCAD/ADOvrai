using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ADOvrai
{
    public class ManagerLivre
    {
        public static Livre DonneLivreDuReader(MySqlDataReader monReader)
        {
            Livre unLivre = new Livre();
            unLivre.Num = Convert.ToInt16(monReader["num"]);
            unLivre.ISBN1 = monReader["isbn"] == DBNull.Value ? "" : monReader["isbn"] as string;
            unLivre.Titre = monReader["titre"] == DBNull.Value ? "" : monReader["titre"] as string;
            unLivre.Prix = monReader["prix"] == DBNull.Value ? "" : monReader["prix"].ToString();
            unLivre.Editeur = monReader["editeur"] == DBNull.Value ? "" : monReader["editeur"] as string;
            unLivre.Annee = monReader["annee"] == DBNull.Value ? "" : monReader["annee"].ToString();
            unLivre.Langue = monReader["langue"] == DBNull.Value ? "" : monReader["langue"] as string;
            unLivre.NumAuteur = monReader["numauteur"] == DBNull.Value ? "" : monReader["numauteur"].ToString();
            unLivre.NumGenre = monReader["numgenre"] == DBNull.Value ? "" : monReader["numgenre"].ToString();
            return unLivre;
        }
        public static List<Livre> DonneLivres()
        {
            List<Livre> lesLivres = new List<Livre>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from livre order by titre";
            monReader = maRequete.ExecuteReader();
            while (monReader.Read())
            {
                Livre unLivre = ManagerLivre.DonneLivreDuReader(monReader);
                lesLivres.Add(unLivre);
            }
            monReader.Close();
            Connection.MaConnection.Close();
            return lesLivres;


        }
        public static Livre DonneLivreParId(int id)
        {
            Livre unLivre = new Livre();
            return unLivre;
        }
        public static bool ModifierLivre(Livre g)
        {
            bool resultat = true;
            return resultat;
        }

        public static bool AjouterLivre(Livre l)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into livre set " +
                "isbn=@paramISBN1, titre=@paramTitre, prix=@paramPrix, editeur=@paramEditeur, annee=@paramAnnee, langue=@paramLangue, numauteur=@paramNumAuteur, numgenre=@paramNumGenre";
            maRequete.Parameters.Clear();//annule tous les anciens paramètres
            // ajoute les paramètres de la requete de modification
            maRequete.Parameters.AddWithValue("@paramISBN1", l.ISBN1);
            maRequete.Parameters.AddWithValue("@paramTitre", l.Titre);
            maRequete.Parameters.AddWithValue("@paramPrix", l.Prix);
            maRequete.Parameters.AddWithValue("@paramEditeur", l.Editeur);
            maRequete.Parameters.AddWithValue("@paramAnnee", l.Annee);
            maRequete.Parameters.AddWithValue("@paramLangue", l.Langue);
            maRequete.Parameters.AddWithValue("@paramNumAuteur", l.NumAuteur);
            maRequete.Parameters.AddWithValue("@paramNumGenre", l.NumGenre);

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
                    throw new Exception("Une erreur s'est produite, le livre n'a pas été mis a jour");
                }
                return reponse;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static bool SupprimerLivre(Livre l)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from livre where " +
                "num = @paramNum";
            maRequete.Parameters.Clear();//annule tous les anciens paramètres
            // ajoute les paramètres de la requete de modification
            maRequete.Parameters.AddWithValue("@paramNum", l.Num);
            const string message =
                "Etes vous sur de vouloir supprimer le livre";
            const string caption = "Suppression du livre";
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
                    MessageBox.Show("Le livre à bien été supprimé !");
                }
                //else
                //{
                //throw new Exception("Une erreur s'est produite, le livre n'a pas été mis a jour");
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
