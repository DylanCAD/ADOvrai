namespace ADOvrai
{
    partial class Form_ListeGenres
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
            this.dgv_ListeGenres = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListeGenres
            // 
            this.dgv_ListeGenres.AllowUserToAddRows = false;
            this.dgv_ListeGenres.AllowUserToDeleteRows = false;
            this.dgv_ListeGenres.AutoGenerateColumns = false;
            this.dgv_ListeGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Libelle});
            this.dgv_ListeGenres.DataSource = this.bs;
            this.dgv_ListeGenres.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListeGenres.Name = "dgv_ListeGenres";
            this.dgv_ListeGenres.ReadOnly = true;
            this.dgv_ListeGenres.RowHeadersWidth = 51;
            this.dgv_ListeGenres.RowTemplate.Height = 24;
            this.dgv_ListeGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeGenres.Size = new System.Drawing.Size(608, 426);
            this.dgv_ListeGenres.TabIndex = 0;
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
            // Libelle
            // 
            this.Libelle.DataPropertyName = "libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.MinimumWidth = 6;
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            this.Libelle.Width = 125;
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(672, 12);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(99, 33);
            this.btn_Afficher.TabIndex = 1;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(672, 69);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(99, 33);
            this.btn_Modifier.TabIndex = 2;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click_1);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(672, 137);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(99, 32);
            this.btn_Supprimer.TabIndex = 3;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click_1);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.AutoSize = true;
            this.btn_Nouveau.Location = new System.Drawing.Point(672, 196);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(99, 34);
            this.btn_Nouveau.TabIndex = 4;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click_1);
            // 
            // Form_ListeGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeGenres);
            this.Name = "Form_ListeGenres";
            this.Text = "Form_ListeGenres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListeGenres;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
    }
}