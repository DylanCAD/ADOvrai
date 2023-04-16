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
    public partial class Form_ListeAuteurs : Form
    {

        List<Auteur> lesAuteurs = new List<Auteur>();


        public Form_ListeAuteurs()
        {
            InitializeComponent();
            RemplirListe();
        }
            
        private void RemplirListe()
        {

            try
            {
                lesAuteurs = ManagerAuteur.DonneAuteurs();
                bs.DataSource = lesAuteurs;
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
            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne= dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne = ligne.DataBoundItem as Auteur;
            if(AuteurSelectionne!=null)
            {
                Form_FicheAuteur frm = new Form_FicheAuteur(false, AuteurSelectionne);
                frm.ShowDialog();
            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne = ligne.DataBoundItem as Auteur;
            if (AuteurSelectionne != null)
            {
                Form_FicheAuteur frm = new Form_FicheAuteur(true, AuteurSelectionne);
                frm.ShowDialog();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne = ligne.DataBoundItem as Auteur;

            bool resultat = ManagerAuteur.SupprimerAuteur(AuteurSelectionne);
            RemplirListe();
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            Form_FicheAuteur frm = new Form_FicheAuteur(true);
            frm.ShowDialog();
            RemplirListe();
        }
    }
}
