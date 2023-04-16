namespace ADOvrai
{
    partial class Form_FicheAuteur
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
            this.lb_Num = new System.Windows.Forms.Label();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.lb_Prenom = new System.Windows.Forms.Label();
            this.lb_Nationalite = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Nationalite = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Num
            // 
            this.lb_Num.AutoSize = true;
            this.lb_Num.Location = new System.Drawing.Point(39, 35);
            this.lb_Num.Name = "lb_Num";
            this.lb_Num.Size = new System.Drawing.Size(55, 16);
            this.lb_Num.TabIndex = 0;
            this.lb_Num.Text = "Numéro";
            // 
            // lb_Nom
            // 
            this.lb_Nom.Location = new System.Drawing.Point(39, 81);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(54, 16);
            this.lb_Nom.TabIndex = 1;
            this.lb_Nom.Text = "Nom";
            // 
            // lb_Prenom
            // 
            this.lb_Prenom.AutoSize = true;
            this.lb_Prenom.Location = new System.Drawing.Point(39, 135);
            this.lb_Prenom.Name = "lb_Prenom";
            this.lb_Prenom.Size = new System.Drawing.Size(54, 16);
            this.lb_Prenom.TabIndex = 2;
            this.lb_Prenom.Text = "Prénom";
            // 
            // lb_Nationalite
            // 
            this.lb_Nationalite.AutoSize = true;
            this.lb_Nationalite.Location = new System.Drawing.Point(39, 186);
            this.lb_Nationalite.Name = "lb_Nationalite";
            this.lb_Nationalite.Size = new System.Drawing.Size(71, 16);
            this.lb_Nationalite.TabIndex = 3;
            this.lb_Nationalite.Text = "Nationalité";
            // 
            // txt_Num
            // 
            this.txt_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.txt_Num.Enabled = false;
            this.txt_Num.Location = new System.Drawing.Point(368, 29);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 22);
            this.txt_Num.TabIndex = 4;
            // 
            // txt_Nom
            // 
            this.txt_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nom", true));
            this.txt_Nom.Location = new System.Drawing.Point(368, 75);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(100, 22);
            this.txt_Nom.TabIndex = 5;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.txt_Prenom.Location = new System.Drawing.Point(368, 129);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(100, 22);
            this.txt_Prenom.TabIndex = 6;
            // 
            // txt_Nationalite
            // 
            this.txt_Nationalite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nationalite", true));
            this.txt_Nationalite.Location = new System.Drawing.Point(368, 180);
            this.txt_Nationalite.Name = "txt_Nationalite";
            this.txt_Nationalite.Size = new System.Drawing.Size(100, 22);
            this.txt_Nationalite.TabIndex = 7;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(42, 264);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 8;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(368, 264);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 9;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // Form_FicheAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.txt_Nationalite);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.lb_Nationalite);
            this.Controls.Add(this.lb_Prenom);
            this.Controls.Add(this.lb_Nom);
            this.Controls.Add(this.lb_Num);
            this.Name = "Form_FicheAuteur";
            this.Text = "Fiche de l\'auteur";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Num;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.Label lb_Prenom;
        private System.Windows.Forms.Label lb_Nationalite;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Nationalite;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.BindingSource bs;
    }
}