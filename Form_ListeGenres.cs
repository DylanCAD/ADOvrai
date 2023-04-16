using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADOvrai
{
    public partial class Form_ListeGenres : Form
    {

        List<Genre> lesGenres = new List<Genre>();


        public Form_ListeGenres()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {

            try
            {
                lesGenres = ManagerGenre.DonneGenres();
                bs.DataSource = lesGenres;
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur :" + ex.Message);
            }
            finally
            {

            }

        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            Genre Genreselectionne = new Genre();
            DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
            Genreselectionne = ligne.DataBoundItem as Genre;
            if (Genreselectionne != null)
            {
                Form_FicheGenre frm = new Form_FicheGenre(false, Genreselectionne);
                frm.ShowDialog();
            }

        }

        private void btn_Modifier_Click_1(object sender, EventArgs e)
        {
            Genre Genreselectionne = new Genre();
            DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
            Genreselectionne = ligne.DataBoundItem as Genre;
            if (Genreselectionne != null)
            {
                Form_FicheGenre frm = new Form_FicheGenre(true, Genreselectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Supprimer_Click_1(object sender, EventArgs e)
        {
            Genre Genreselectionne = new Genre();
            DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
            Genreselectionne = ligne.DataBoundItem as Genre;

            bool resultat = ManagerGenre.SupprimerGenre(Genreselectionne);
            RemplirListe();
        }

        private void btn_Nouveau_Click_1(object sender, EventArgs e)
        {
            Form_FicheGenre frm = new Form_FicheGenre(true);
            frm.ShowDialog();
            RemplirListe();
        }
    }
}
