namespace ADOvrai
{
    partial class Form_ListeAdherents
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
            this.dgv_ListeAdherents = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdrRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdrCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdrVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeAdherents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListeAdherents
            // 
            this.dgv_ListeAdherents.AllowUserToAddRows = false;
            this.dgv_ListeAdherents.AllowUserToDeleteRows = false;
            this.dgv_ListeAdherents.AutoGenerateColumns = false;
            this.dgv_ListeAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeAdherents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom,
            this.Prenom,
            this.AdrRue,
            this.AdrCP,
            this.AdrVille,
            this.Tel,
            this.Mel});
            this.dgv_ListeAdherents.DataSource = this.bs;
            this.dgv_ListeAdherents.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListeAdherents.Name = "dgv_ListeAdherents";
            this.dgv_ListeAdherents.ReadOnly = true;
            this.dgv_ListeAdherents.RowHeadersWidth = 51;
            this.dgv_ListeAdherents.RowTemplate.Height = 24;
            this.dgv_ListeAdherents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeAdherents.Size = new System.Drawing.Size(1067, 426);
            this.dgv_ListeAdherents.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "num";
            this.Num.HeaderText = "Num";
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
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Width = 125;
            // 
            // AdrRue
            // 
            this.AdrRue.DataPropertyName = "adrRue";
            this.AdrRue.HeaderText = "AdrRue";
            this.AdrRue.MinimumWidth = 6;
            this.AdrRue.Name = "AdrRue";
            this.AdrRue.ReadOnly = true;
            this.AdrRue.Width = 125;
            // 
            // AdrCP
            // 
            this.AdrCP.DataPropertyName = "adrCP";
            this.AdrCP.HeaderText = "AdrCP";
            this.AdrCP.MinimumWidth = 6;
            this.AdrCP.Name = "AdrCP";
            this.AdrCP.ReadOnly = true;
            this.AdrCP.Width = 125;
            // 
            // AdrVille
            // 
            this.AdrVille.DataPropertyName = "adrVille";
            this.AdrVille.HeaderText = "AdrVille";
            this.AdrVille.MinimumWidth = 6;
            this.AdrVille.Name = "AdrVille";
            this.AdrVille.ReadOnly = true;
            this.AdrVille.Width = 125;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "tel";
            this.Tel.HeaderText = "Tel";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 125;
            // 
            // Mel
            // 
            this.Mel.DataPropertyName = "mel";
            this.Mel.HeaderText = "Mel";
            this.Mel.MinimumWidth = 6;
            this.Mel.Name = "Mel";
            this.Mel.ReadOnly = true;
            this.Mel.Width = 125;
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(1134, 12);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(95, 33);
            this.btn_Afficher.TabIndex = 1;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(1134, 75);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(95, 35);
            this.btn_Modifier.TabIndex = 2;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(1134, 141);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(95, 34);
            this.btn_Supprimer.TabIndex = 3;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(1134, 217);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(95, 35);
            this.btn_Nouveau.TabIndex = 4;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Form_ListeAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 450);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeAdherents);
            this.Name = "Form_ListeAdherents";
            this.Text = "Form_ListeAdherents";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeAdherents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListeAdherents;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdrRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdrCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdrVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mel;
    }
}