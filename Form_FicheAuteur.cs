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
    public partial class Form_FicheAuteur : Form
    {
        private int numAuteur;

        Auteur AuteurCourant = new Auteur();

        public Form_FicheAuteur(bool modification, Auteur monAuteur = null)
        {
            InitializeComponent();
            try
            {
                if (monAuteur != null)
                {
                    AuteurCourant = monAuteur;
                }
                bs.DataSource = AuteurCourant;

                if (modification == false)
                {
                    txt_Nom.Enabled = false;
                    txt_Prenom.Enabled = false;
                    txt_Nationalite.Enabled = false;
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
                        if (AuteurCourant.Num == 0) // cas d'un ajout
                        {
                            AuteurCourant = bs.Current as Auteur;
                            bool reponse = ManagerAuteur.AjouterAuteur(AuteurCourant);
                        }
                        else // cas d'une modification
                        {
                            AuteurCourant = bs.Current as Auteur;
                            bool reponse = ManagerAuteur.ModifierAuteur(AuteurCourant);
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
            if (txt_Nom.Text == "") {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if (txt_Prenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prénom");
                controle = false;
            }
            if (txt_Nationalite.Text == "")
            {
                MessageBox.Show("Vous devez saisir une nationalité");
                controle = false;
            }
            return controle;
        }
    }
}
