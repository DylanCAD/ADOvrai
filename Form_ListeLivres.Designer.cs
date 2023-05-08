namespace ADOvrai
{
    partial class Form_ListeLivres
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
            this.dgv_ListeLivres = new System.Windows.Forms.DataGridView();
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Langue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeLivres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListeLivres
            // 
            this.dgv_ListeLivres.AllowUserToAddRows = false;
            this.dgv_ListeLivres.AllowUserToDeleteRows = false;
            this.dgv_ListeLivres.AutoGenerateColumns = false;
            this.dgv_ListeLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.ISBN,
            this.Titre,
            this.Prix,
            this.Editeur,
            this.Annee,
            this.Langue,
            this.NumAuteur,
            this.NumGenre});
            this.dgv_ListeLivres.DataSource = this.bs;
            this.dgv_ListeLivres.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListeLivres.MultiSelect = false;
            this.dgv_ListeLivres.Name = "dgv_ListeLivres";
            this.dgv_ListeLivres.ReadOnly = true;
            this.dgv_ListeLivres.RowHeadersWidth = 51;
            this.dgv_ListeLivres.RowTemplate.Height = 24;
            this.dgv_ListeLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeLivres.Size = new System.Drawing.Size(1199, 426);
            this.dgv_ListeLivres.TabIndex = 0;
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(1245, 12);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(97, 32);
            this.btn_Afficher.TabIndex = 1;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click_1);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(1245, 65);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(97, 33);
            this.btn_Modifier.TabIndex = 2;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(1245, 120);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(97, 34);
            this.btn_Supprimer.TabIndex = 3;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(1245, 174);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(97, 33);
            this.btn_Nouveau.TabIndex = 4;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Num
            // 
            this.Num.DataPropertyName = "num";
            this.Num.HeaderText = "Numéro";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 125;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN1";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 125;
            // 
            // Titre
            // 
            this.Titre.DataPropertyName = "titre";
            this.Titre.HeaderText = "Titre";
            this.Titre.MinimumWidth = 6;
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            this.Titre.Width = 125;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Width = 125;
            // 
            // Editeur
            // 
            this.Editeur.DataPropertyName = "editeur";
            this.Editeur.HeaderText = "Editeur";
            this.Editeur.MinimumWidth = 6;
            this.Editeur.Name = "Editeur";
            this.Editeur.ReadOnly = true;
            this.Editeur.Width = 125;
            // 
            // Annee
            // 
            this.Annee.DataPropertyName = "annee";
            this.Annee.HeaderText = "Annee";
            this.Annee.MinimumWidth = 6;
            this.Annee.Name = "Annee";
            this.Annee.ReadOnly = true;
            this.Annee.Width = 125;
            // 
            // Langue
            // 
            this.Langue.DataPropertyName = "langue";
            this.Langue.HeaderText = "Langue";
            this.Langue.MinimumWidth = 6;
            this.Langue.Name = "Langue";
            this.Langue.ReadOnly = true;
            this.Langue.Width = 125;
            // 
            // NumAuteur
            // 
            this.NumAuteur.DataPropertyName = "numAuteur";
            this.NumAuteur.HeaderText = "NumAuteur";
            this.NumAuteur.MinimumWidth = 6;
            this.NumAuteur.Name = "NumAuteur";
            this.NumAuteur.ReadOnly = true;
            this.NumAuteur.Width = 125;
            // 
            // NumGenre
            // 
            this.NumGenre.DataPropertyName = "numGenre";
            this.NumGenre.HeaderText = "NumGenre";
            this.NumGenre.MinimumWidth = 6;
            this.NumGenre.Name = "NumGenre";
            this.NumGenre.ReadOnly = true;
            this.NumGenre.Width = 125;
            // 
            // Form_ListeLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 450);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeLivres);
            this.Name = "Form_ListeLivres";
            this.Text = "Form_ListeLivres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeLivres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListeLivres;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Langue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumGenre;
    }
}