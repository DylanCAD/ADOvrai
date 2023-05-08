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
    public partial class Form_ListeLivres : Form
    {

        List<Livre> lesLivres = new List<Livre>();


        public Form_ListeLivres()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {

            try
            {
                lesLivres = ManagerLivre.DonneLivres();
                bs.DataSource = lesLivres;
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur :" + ex.Message);
            }
            finally
            {

            }

        }

        private void btn_Afficher_Click_1(object sender, EventArgs e)
        {
            Livre Livreselectionne = new Livre();
            DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
            Livreselectionne = ligne.DataBoundItem as Livre;
            if (Livreselectionne != null)
            {
                Form_FicheLivre frm = new Form_FicheLivre(false, Livreselectionne);
                frm.ShowDialog();
            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Livre Livreselectionne = new Livre();
            DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
            Livreselectionne = ligne.DataBoundItem as Livre;
            if (Livreselectionne != null)
            {
                Form_FicheLivre frm = new Form_FicheLivre(true, Livreselectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Livre Livreselectionne = new Livre();
            DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
            Livreselectionne = ligne.DataBoundItem as Livre;

            bool resultat = ManagerLivre.SupprimerLivre(Livreselectionne);
            RemplirListe();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            Form_FicheLivre frm = new Form_FicheLivre(true);
            frm.ShowDialog();
            RemplirListe();
        }

    }
}
