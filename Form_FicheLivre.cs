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
    public partial class Form_FicheLivre : Form
    {
        private int numLivre;

        Livre LivreCourant = new Livre();

        public Form_FicheLivre(bool modification, Livre monLivre = null)
        {
            InitializeComponent();
            try
            {
                if (monLivre != null)
                {
                    LivreCourant = monLivre;
                }
                bs.DataSource = LivreCourant;


                if (modification == false)
                {
                    txt_Isbn.Enabled = false;
                    txt_Titre.Enabled = false;
                    txt_Prix.Enabled = false;
                    txt_Editeur.Enabled = false;
                    txt_Annee.Enabled = false;
                    txt_Langue.Enabled = false;
                    txt_NumAuteur.Enabled = false;
                    txt_NumGenre.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btn_annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ControleSaisies() == true)
                {
                    if (LivreCourant.Num == 0) // cas d'un ajout
                    {
                        LivreCourant = bs.Current as Livre;
                        bool reponse = ManagerLivre.AjouterLivre(LivreCourant);
                    }
                    else // cas d'une modification
                    {
                        LivreCourant = bs.Current as Livre;
                        bool reponse = ManagerLivre.ModifierLivre(LivreCourant);
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
            if (txt_Isbn.Text == "")
            {
                MessageBox.Show("Vous devez saisir un ISBN");
                controle = false;
            }
            if (txt_Titre.Text == "")
            {
                MessageBox.Show("Vous devez saisir un titre");
                controle = false;
            }
            if (txt_Prix.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prix");
                controle = false;
            }
            if (txt_Editeur.Text == "")
            {
                MessageBox.Show("Vous devez saisir un libelle");
                controle = false;
            }
            if (txt_Annee.Text == "")
            {
                MessageBox.Show("Vous devez saisir une annee");
                controle = false;
            }
            if (txt_Langue.Text == "")
            {
                MessageBox.Show("Vous devez saisir une langue");
                controle = false;
            }
            if (txt_NumAuteur.Text == "")
            {
                MessageBox.Show("Vous devez saisir un num auteur");
                controle = false;
            }
            if (txt_NumGenre.Text == "")
            {
                MessageBox.Show("Vous devez saisir un num genre");
                controle = false;
            }
            return controle;
        }

    }
}
