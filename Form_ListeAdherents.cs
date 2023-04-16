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
    public partial class Form_ListeAdherents : Form
    {

        List<Adherent> lesAdherents = new List<Adherent>();


        public Form_ListeAdherents()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {

            try
            {
                lesAdherents = ManagerAdherent.DonneAdherents();
                bs.DataSource = lesAdherents;
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
            Adherent AdherentSelectionne = new Adherent();
            DataGridViewRow ligne = dgv_ListeAdherents.SelectedRows[0];
            AdherentSelectionne = ligne.DataBoundItem as Adherent;
            if (AdherentSelectionne != null)
            {
                Form_FicheAdherent frm = new Form_FicheAdherent(false, AdherentSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Adherent AdherentSelectionne = new Adherent();
            DataGridViewRow ligne = dgv_ListeAdherents.SelectedRows[0];
            AdherentSelectionne = ligne.DataBoundItem as Adherent;
            if (AdherentSelectionne != null)
            {
                Form_FicheAdherent frm = new Form_FicheAdherent(true, AdherentSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Adherent AdherentSelectionne = new Adherent();
            DataGridViewRow ligne = dgv_ListeAdherents.SelectedRows[0];
            AdherentSelectionne = ligne.DataBoundItem as Adherent;

            bool resultat = ManagerAdherent.SupprimerAdherent(AdherentSelectionne);
            RemplirListe();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            Form_FicheAdherent frm = new Form_FicheAdherent(true);
            frm.ShowDialog();
            RemplirListe();
        }
    }
}
