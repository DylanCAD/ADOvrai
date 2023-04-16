using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ADOvrai
{
    public class ManagerGenre
    {
        public static Genre DonneGenreDuReader(MySqlDataReader monReader)
        {
            Genre unGenre = new Genre();
            unGenre.Num = Convert.ToInt16(monReader["num"]);
            unGenre.Libelle = monReader["libelle"] == DBNull.Value ? "" : monReader["libelle"] as string;
            return unGenre;
        }
        public static List<Genre> DonneGenres()
        {
            List<Genre> lesGenres = new List<Genre>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from genre order by libelle";
            monReader = maRequete.ExecuteReader();
            while (monReader.Read())
            {
                Genre unGenre = ManagerGenre.DonneGenreDuReader(monReader);
                lesGenres.Add(unGenre);
            }
            monReader.Close();
            Connection.MaConnection.Close();
            return lesGenres;


        }
        public static Genre DonneGenreParId(int id)
        {
            Genre unGenre = new Genre();
            return unGenre;
        }
        public static bool ModifierGenre(Genre g)
        {
            bool resultat = true;
            return resultat;
        }

        public static bool AjouterGenre(Genre g)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into genre set " +
                "libelle=@paramLibelle";
            maRequete.Parameters.Clear();//annule tous les anciens paramètres
            // ajoute les paramètres de la requete de modification
            maRequete.Parameters.AddWithValue("@paramLibelle", g.Libelle);
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
                    throw new Exception("Une erreur s'est produite, le genre n'a pas été mis a jour");
                }
                return reponse;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static bool SupprimerGenre(Genre g)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from genre where " +
                "num = @paramNum";
            maRequete.Parameters.Clear();//annule tous les anciens paramètres
            // ajoute les paramètres de la requete de modification
            maRequete.Parameters.AddWithValue("@paramNum", g.Num);
            const string message =
                "Etes vous sur de vouloir supprimer le genre";
            const string caption = "Suppression de le genre";
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
                    MessageBox.Show("Le genre à bien été supprimé !");
                }
                //else
                //{
                //throw new Exception("Une erreur s'est produite, le genre n'a pas été mis a jour");
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
