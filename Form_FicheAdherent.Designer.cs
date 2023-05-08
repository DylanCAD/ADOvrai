namespace ADOvrai
{
    partial class Form_FicheAdherent
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
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_AdrCP = new System.Windows.Forms.TextBox();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.txt_AdrVille = new System.Windows.Forms.TextBox();
            this.txt_Mel = new System.Windows.Forms.TextBox();
            this.txt_AdrRue = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.lb_Num = new System.Windows.Forms.Label();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.lb_Prénom = new System.Windows.Forms.Label();
            this.lb_AdrRue = new System.Windows.Forms.Label();
            this.lb_AdrCP = new System.Windows.Forms.Label();
            this.lb_AdrVille = new System.Windows.Forms.Label();
            this.lb_Tel = new System.Windows.Forms.Label();
            this.lb_Mel = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nom
            // 
            this.txt_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nom", true));
            this.txt_Nom.Location = new System.Drawing.Point(551, 55);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(100, 22);
            this.txt_Nom.TabIndex = 0;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.txt_Prenom.Location = new System.Drawing.Point(551, 97);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(100, 22);
            this.txt_Prenom.TabIndex = 1;
            // 
            // txt_AdrCP
            // 
            this.txt_AdrCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrCP", true));
            this.txt_AdrCP.Location = new System.Drawing.Point(551, 185);
            this.txt_AdrCP.Name = "txt_AdrCP";
            this.txt_AdrCP.Size = new System.Drawing.Size(100, 22);
            this.txt_AdrCP.TabIndex = 2;
            // 
            // txt_Num
            // 
            this.txt_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.txt_Num.Enabled = false;
            this.txt_Num.Location = new System.Drawing.Point(551, 12);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 22);
            this.txt_Num.TabIndex = 3;
            // 
            // txt_AdrVille
            // 
            this.txt_AdrVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrVille", true));
            this.txt_AdrVille.Location = new System.Drawing.Point(551, 232);
            this.txt_AdrVille.Name = "txt_AdrVille";
            this.txt_AdrVille.Size = new System.Drawing.Size(100, 22);
            this.txt_AdrVille.TabIndex = 4;
            // 
            // txt_Mel
            // 
            this.txt_Mel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Mel", true));
            this.txt_Mel.Location = new System.Drawing.Point(551, 326);
            this.txt_Mel.Name = "txt_Mel";
            this.txt_Mel.Size = new System.Drawing.Size(100, 22);
            this.txt_Mel.TabIndex = 6;
            // 
            // txt_AdrRue
            // 
            this.txt_AdrRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrRue", true));
            this.txt_AdrRue.Location = new System.Drawing.Point(551, 141);
            this.txt_AdrRue.Name = "txt_AdrRue";
            this.txt_AdrRue.Size = new System.Drawing.Size(100, 22);
            this.txt_AdrRue.TabIndex = 7;
            // 
            // txt_Tel
            // 
            this.txt_Tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Tel", true));
            this.txt_Tel.Location = new System.Drawing.Point(551, 279);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 22);
            this.txt_Tel.TabIndex = 8;
            // 
            // lb_Num
            // 
            this.lb_Num.AutoSize = true;
            this.lb_Num.Location = new System.Drawing.Point(75, 18);
            this.lb_Num.Name = "lb_Num";
            this.lb_Num.Size = new System.Drawing.Size(55, 16);
            this.lb_Num.TabIndex = 9;
            this.lb_Num.Text = "Numéro";
            // 
            // lb_Nom
            // 
            this.lb_Nom.AutoSize = true;
            this.lb_Nom.Location = new System.Drawing.Point(75, 61);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(36, 16);
            this.lb_Nom.TabIndex = 10;
            this.lb_Nom.Text = "Nom";
            // 
            // lb_Prénom
            // 
            this.lb_Prénom.AutoSize = true;
            this.lb_Prénom.Location = new System.Drawing.Point(75, 103);
            this.lb_Prénom.Name = "lb_Prénom";
            this.lb_Prénom.Size = new System.Drawing.Size(54, 16);
            this.lb_Prénom.TabIndex = 11;
            this.lb_Prénom.Text = "Prénom";
            // 
            // lb_AdrRue
            // 
            this.lb_AdrRue.AutoSize = true;
            this.lb_AdrRue.Location = new System.Drawing.Point(75, 147);
            this.lb_AdrRue.Name = "lb_AdrRue";
            this.lb_AdrRue.Size = new System.Drawing.Size(53, 16);
            this.lb_AdrRue.TabIndex = 12;
            this.lb_AdrRue.Text = "AdrRue";
            // 
            // lb_AdrCP
            // 
            this.lb_AdrCP.AutoSize = true;
            this.lb_AdrCP.Location = new System.Drawing.Point(75, 191);
            this.lb_AdrCP.Name = "lb_AdrCP";
            this.lb_AdrCP.Size = new System.Drawing.Size(46, 16);
            this.lb_AdrCP.TabIndex = 13;
            this.lb_AdrCP.Text = "AdrCP";
            // 
            // lb_AdrVille
            // 
            this.lb_AdrVille.AutoSize = true;
            this.lb_AdrVille.Location = new System.Drawing.Point(75, 238);
            this.lb_AdrVille.Name = "lb_AdrVille";
            this.lb_AdrVille.Size = new System.Drawing.Size(54, 16);
            this.lb_AdrVille.TabIndex = 14;
            this.lb_AdrVille.Text = "AdrVille";
            // 
            // lb_Tel
            // 
            this.lb_Tel.AutoSize = true;
            this.lb_Tel.Location = new System.Drawing.Point(75, 285);
            this.lb_Tel.Name = "lb_Tel";
            this.lb_Tel.Size = new System.Drawing.Size(27, 16);
            this.lb_Tel.TabIndex = 15;
            this.lb_Tel.Text = "Tel";
            // 
            // lb_Mel
            // 
            this.lb_Mel.AutoSize = true;
            this.lb_Mel.Location = new System.Drawing.Point(75, 332);
            this.lb_Mel.Name = "lb_Mel";
            this.lb_Mel.Size = new System.Drawing.Size(29, 16);
            this.lb_Mel.TabIndex = 16;
            this.lb_Mel.Text = "Mel";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(78, 384);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 17;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(575, 383);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 18;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ADOvrai.Adherent);
            // 
            // Form_FicheAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.lb_Mel);
            this.Controls.Add(this.lb_Tel);
            this.Controls.Add(this.lb_AdrVille);
            this.Controls.Add(this.lb_AdrCP);
            this.Controls.Add(this.lb_AdrRue);
            this.Controls.Add(this.lb_Prénom);
            this.Controls.Add(this.lb_Nom);
            this.Controls.Add(this.lb_Num);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_AdrRue);
            this.Controls.Add(this.txt_Mel);
            this.Controls.Add(this.txt_AdrVille);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.txt_AdrCP);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Name = "Form_FicheAdherent";
            this.Text = "Form_FicheAdherent";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_AdrCP;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_AdrVille;
        private System.Windows.Forms.TextBox txt_Mel;
        private System.Windows.Forms.TextBox txt_AdrRue;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label lb_Num;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.Label lb_Prénom;
        private System.Windows.Forms.Label lb_AdrRue;
        private System.Windows.Forms.Label lb_AdrCP;
        private System.Windows.Forms.Label lb_AdrVille;
        private System.Windows.Forms.Label lb_Tel;
        private System.Windows.Forms.Label lb_Mel;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.BindingSource bs;
    }
}