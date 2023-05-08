using MySql.Data.MySqlClient;
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
    public partial class Form_FicheAdherent : Form
    {
        private int numAdherent;

        Adherent AdherentCourant = new Adherent();

        public Form_FicheAdherent(bool modification, Adherent monAdherent = null)
        {
            InitializeComponent();
            try
            {
                if (monAdherent != null)
                {
                    AdherentCourant = monAdherent;
                }
                bs.DataSource = AdherentCourant;

                if (modification == false)
                {
                    txt_Nom.Enabled = false;
                    txt_Prenom.Enabled = false;
                    txt_AdrRue.Enabled = false;
                    txt_AdrCP.Enabled = false;
                    txt_AdrVille.Enabled = false;
                    txt_Tel.Enabled = false;
                    txt_Mel.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControleSaisies() == true)
                {
                    if (AdherentCourant.Num == 0) // cas d'un ajout
                    {
                        AdherentCourant = bs.Current as Adherent;
                        bool reponse = ManagerAdherent.AjouterAdherent(AdherentCourant);
                    }
                    else // cas d'une modification
                    {
                        AdherentCourant = bs.Current as Adherent;
                        bool reponse = ManagerAdherent.ModifierAdherent(AdherentCourant);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ControleSaisies()
        {
            bool controle = true;
            if (txt_Nom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if (txt_Prenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prénom");
                controle = false;
            }
            if (txt_AdrRue.Text == "")
            {
                MessageBox.Show("Vous devez saisir une rue");
                controle = false;
            }
            if (txt_AdrCP.Text == "")
            {
                MessageBox.Show("Vous devez saisir un CP");
                controle = false;
            }
            if (txt_AdrVille.Text == "")
            {
                MessageBox.Show("Vous devez saisir une ville");
                controle = false;
            }
            if (txt_Tel.Text == "")
            {
                MessageBox.Show("Vous devez saisir un tel");
                controle = false;
            }

            return controle;
        }

    }
}
