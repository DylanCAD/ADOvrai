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
    public partial class Form_FicheGenre : Form
    {
        private int numGenre;

        Genre GenreCourant = new Genre();

        public Form_FicheGenre(bool modification, Genre monGenre = null)
        {
            InitializeComponent();
            try
            {
                if (monGenre != null)
                {
                    GenreCourant = monGenre;
                }
                bs.DataSource = GenreCourant;

                if (modification == false)
                {
                    txt_Libelle.Enabled = false;
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
                    if (GenreCourant.Num == 0) // cas d'un ajout
                    {
                        GenreCourant = bs.Current as Genre;
                        bool reponse = ManagerGenre.AjouterGenre(GenreCourant);
                    }
                    else // cas d'une modification
                    {
                        GenreCourant = bs.Current as Genre;
                        bool reponse = ManagerGenre.ModifierGenre(GenreCourant);
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
            if (txt_Libelle.Text == "")
            {
                MessageBox.Show("Vous devez saisir un libelle");
                controle = false;
            }
            return controle;
        }
    }
}
