namespace ADOvrai
{
    partial class Form_FicheLivre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Titre = new System.Windows.Forms.TextBox();
            this.txt_Prix = new System.Windows.Forms.TextBox();
            this.txt_Isbn = new System.Windows.Forms.TextBox();
            this.txt_Annee = new System.Windows.Forms.TextBox();
            this.txt_Langue = new System.Windows.Forms.TextBox();
            this.txt_NumAuteur = new System.Windows.Forms.TextBox();
            this.txt_NumGenre = new System.Windows.Forms.TextBox();
            this.txt_Editeur = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.lb_Num = new System.Windows.Forms.Label();
            this.lb_Isbn = new System.Windows.Forms.Label();
            this.lb_Titre = new System.Windows.Forms.Label();
            this.lb_Prix = new System.Windows.Forms.Label();
            this.lb_Editeur = new System.Windows.Forms.Label();
            this.lb_Annee = new System.Windows.Forms.Label();
            this.lb_Langue = new System.Windows.Forms.Label();
            this.lb_NumAuteur = new System.Windows.Forms.Label();
            this.lb_NumGenre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Num
            // 
            this.txt_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.txt_Num.Enabled = false;
            this.txt_Num.Location = new System.Drawing.Point(560, 12);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 22);
            this.txt_Num.TabIndex = 0;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ADOvrai.Livre);
            // 
            // txt_Titre
            // 
            this.txt_Titre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Titre", true));
            this.txt_Titre.Location = new System.Drawing.Point(560, 99);
            this.txt_Titre.Name = "txt_Titre";
            this.txt_Titre.Size = new System.Drawing.Size(100, 22);
            this.txt_Titre.TabIndex = 1;
            // 
            // txt_Prix
            // 
            this.txt_Prix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prix", true));
            this.txt_Prix.Location = new System.Drawing.Point(560, 145);
            this.txt_Prix.Name = "txt_Prix";
            this.txt_Prix.Size = new System.Drawing.Size(100, 22);
            this.txt_Prix.TabIndex = 2;
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "ISBN1", true));
            this.txt_Isbn.Location = new System.Drawing.Point(560, 52);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(100, 22);
            this.txt_Isbn.TabIndex = 3;
            // 
            // txt_Annee
            // 
            this.txt_Annee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Annee", true));
            this.txt_Annee.Location = new System.Drawing.Point(560, 241);
            this.txt_Annee.Name = "txt_Annee";
            this.txt_Annee.Size = new System.Drawing.Size(100, 22);
            this.txt_Annee.TabIndex = 4;
            // 
            // txt_Langue
            // 
            this.txt_Langue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Langue", true));
            this.txt_Langue.Location = new System.Drawing.Point(560, 289);
            this.txt_Langue.Name = "txt_Langue";
            this.txt_Langue.Size = new System.Drawing.Size(100, 22);
            this.txt_Langue.TabIndex = 5;
            // 
            // txt_NumAuteur
            // 
            this.txt_NumAuteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "NumAuteur", true));
            this.txt_NumAuteur.Location = new System.Drawing.Point(560, 334);
            this.txt_NumAuteur.Name = "txt_NumAuteur";
            this.txt_NumAuteur.Size = new System.Drawing.Size(100, 22);
            this.txt_NumAuteur.TabIndex = 6;
            // 
            // txt_NumGenre
            // 
            this.txt_NumGenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "NumGenre", true));
            this.txt_NumGenre.Location = new System.Drawing.Point(560, 377);
            this.txt_NumGenre.Name = "txt_NumGenre";
            this.txt_NumGenre.Size = new System.Drawing.Size(100, 22);
            this.txt_NumGenre.TabIndex = 7;
            // 
            // txt_Editeur
            // 
            this.txt_Editeur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Editeur", true));
            this.txt_Editeur.Location = new System.Drawing.Point(560, 192);
            this.txt_Editeur.Name = "txt_Editeur";
            this.txt_Editeur.Size = new System.Drawing.Size(100, 22);
            this.txt_Editeur.TabIndex = 8;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(489, 415);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 9;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click_1);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(179, 415);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 10;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click_1);
            // 
            // lb_Num
            // 
            this.lb_Num.AutoSize = true;
            this.lb_Num.Location = new System.Drawing.Point(73, 12);
            this.lb_Num.Name = "lb_Num";
            this.lb_Num.Size = new System.Drawing.Size(55, 16);
            this.lb_Num.TabIndex = 11;
            this.lb_Num.Text = "Numéro";
            // 
            // lb_Isbn
            // 
            this.lb_Isbn.AutoSize = true;
            this.lb_Isbn.Location = new System.Drawing.Point(73, 58);
            this.lb_Isbn.Name = "lb_Isbn";
            this.lb_Isbn.Size = new System.Drawing.Size(38, 16);
            this.lb_Isbn.TabIndex = 12;
            this.lb_Isbn.Text = "ISBN";
            // 
            // lb_Titre
            // 
            this.lb_Titre.AutoSize = true;
            this.lb_Titre.Location = new System.Drawing.Point(73, 105);
            this.lb_Titre.Name = "lb_Titre";
            this.lb_Titre.Size = new System.Drawing.Size(34, 16);
            this.lb_Titre.TabIndex = 13;
            this.lb_Titre.Text = "Titre";
            // 
            // lb_Prix
            // 
            this.lb_Prix.AutoSize = true;
            this.lb_Prix.Location = new System.Drawing.Point(73, 151);
            this.lb_Prix.Name = "lb_Prix";
            this.lb_Prix.Size = new System.Drawing.Size(29, 16);
            this.lb_Prix.TabIndex = 14;
            this.lb_Prix.Text = "Prix";
            // 
            // lb_Editeur
            // 
            this.lb_Editeur.AutoSize = true;
            this.lb_Editeur.Location = new System.Drawing.Point(73, 198);
            this.lb_Editeur.Name = "lb_Editeur";
            this.lb_Editeur.Size = new System.Drawing.Size(49, 16);
            this.lb_Editeur.TabIndex = 15;
            this.lb_Editeur.Text = "Editeur";
            // 
            // lb_Annee
            // 
            this.lb_Annee.AutoSize = true;
            this.lb_Annee.Location = new System.Drawing.Point(73, 247);
            this.lb_Annee.Name = "lb_Annee";
            this.lb_Annee.Size = new System.Drawing.Size(46, 16);
            this.lb_Annee.TabIndex = 16;
            this.lb_Annee.Text = "Annee";
            // 
            // lb_Langue
            // 
            this.lb_Langue.AutoSize = true;
            this.lb_Langue.Location = new System.Drawing.Point(73, 295);
            this.lb_Langue.Name = "lb_Langue";
            this.lb_Langue.Size = new System.Drawing.Size(52, 16);
            this.lb_Langue.TabIndex = 17;
            this.lb_Langue.Text = "Langue";
            // 
            // lb_NumAuteur
            // 
            this.lb_NumAuteur.AutoSize = true;
            this.lb_NumAuteur.Location = new System.Drawing.Point(73, 340);
            this.lb_NumAuteur.Name = "lb_NumAuteur";
            this.lb_NumAuteur.Size = new System.Drawing.Size(100, 16);
            this.lb_NumAuteur.TabIndex = 18;
            this.lb_NumAuteur.Text = "Num de l\'auteur";
            // 
            // lb_NumGenre
            // 
            this.lb_NumGenre.AutoSize = true;
            this.lb_NumGenre.Location = new System.Drawing.Point(73, 383);
            this.lb_NumGenre.Name = "lb_NumGenre";
            this.lb_NumGenre.Size = new System.Drawing.Size(91, 16);
            this.lb_NumGenre.TabIndex = 19;
            this.lb_NumGenre.Text = "Num du genre";
            // 
            // Form_FicheLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_NumGenre);
            this.Controls.Add(this.lb_NumAuteur);
            this.Controls.Add(this.lb_Langue);
            this.Controls.Add(this.lb_Annee);
            this.Controls.Add(this.lb_Editeur);
            this.Controls.Add(this.lb_Prix);
            this.Controls.Add(this.lb_Titre);
            this.Controls.Add(this.lb_Isbn);
            this.Controls.Add(this.lb_Num);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_Editeur);
            this.Controls.Add(this.txt_NumGenre);
            this.Controls.Add(this.txt_NumAuteur);
            this.Controls.Add(this.txt_Langue);
            this.Controls.Add(this.txt_Annee);
            this.Controls.Add(this.txt_Isbn);
            this.Controls.Add(this.txt_Prix);
            this.Controls.Add(this.txt_Titre);
            this.Controls.Add(this.txt_Num);
            this.Name = "Form_FicheLivre";
            this.Text = "Form_FicheLivre";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_Titre;
        private System.Windows.Forms.TextBox txt_Prix;
        private System.Windows.Forms.TextBox txt_Isbn;
        private System.Windows.Forms.TextBox txt_Annee;
        private System.Windows.Forms.TextBox txt_Langue;
        private System.Windows.Forms.TextBox txt_NumAuteur;
        private System.Windows.Forms.TextBox txt_NumGenre;
        private System.Windows.Forms.TextBox txt_Editeur;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Label lb_Num;
        private System.Windows.Forms.Label lb_Isbn;
        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.Label lb_Prix;
        private System.Windows.Forms.Label lb_Editeur;
        private System.Windows.Forms.Label lb_Annee;
        private System.Windows.Forms.Label lb_Langue;
        private System.Windows.Forms.Label lb_NumAuteur;
        private System.Windows.Forms.Label lb_NumGenre;
        private System.Windows.Forms.BindingSource bs;
    }
}