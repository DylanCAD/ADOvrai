namespace ADOvrai
{
    partial class Form_ListeAuteurs
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_ListeAuteurs = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationalite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeAuteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListeAuteurs
            // 
            this.dgv_ListeAuteurs.AllowUserToAddRows = false;
            this.dgv_ListeAuteurs.AllowUserToDeleteRows = false;
            this.dgv_ListeAuteurs.AutoGenerateColumns = false;
            this.dgv_ListeAuteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeAuteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom,
            this.Prenom,
            this.Nationalite});
            this.dgv_ListeAuteurs.DataSource = this.bs;
            this.dgv_ListeAuteurs.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListeAuteurs.MultiSelect = false;
            this.dgv_ListeAuteurs.Name = "dgv_ListeAuteurs";
            this.dgv_ListeAuteurs.ReadOnly = true;
            this.dgv_ListeAuteurs.RowHeadersWidth = 51;
            this.dgv_ListeAuteurs.RowTemplate.Height = 24;
            this.dgv_ListeAuteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeAuteurs.Size = new System.Drawing.Size(554, 426);
            this.dgv_ListeAuteurs.TabIndex = 0;
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
            // Nom
            // 
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 125;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "prenom";
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Width = 125;
            // 
            // Nationalite
            // 
            this.Nationalite.DataPropertyName = "nationalite";
            this.Nationalite.HeaderText = "Nationalité";
            this.Nationalite.MinimumWidth = 6;
            this.Nationalite.Name = "Nationalite";
            this.Nationalite.ReadOnly = true;
            this.Nationalite.Width = 125;
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(639, 12);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(118, 29);
            this.btn_Afficher.TabIndex = 1;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(639, 66);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(118, 30);
            this.btn_Modifier.TabIndex = 3;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(639, 127);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(118, 32);
            this.btn_Supprimer.TabIndex = 4;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(639, 186);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(118, 28);
            this.btn_Nouveau.TabIndex = 5;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Form_ListeAuteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeAuteurs);
            this.Name = "Form_ListeAuteurs";
            this.Text = "Liste des auteurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeAuteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListeAuteurs;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationalite;
    }
}

