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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FicheAdherent));
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_AdrRue = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_Mel = new System.Windows.Forms.TextBox();
            this.txt_AdrVille = new System.Windows.Forms.TextBox();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_AdrCP = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.lb_Num = new System.Windows.Forms.Label();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.lb_Prénom = new System.Windows.Forms.Label();
            this.lb_AdrRue = new System.Windows.Forms.Label();
            this.lb_AdrCP = new System.Windows.Forms.Label();
            this.lb_Tel = new System.Windows.Forms.Label();
            this.lb_Mel = new System.Windows.Forms.Label();
            this.lb_AdrVille = new System.Windows.Forms.Label();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nom
            // 
            resources.ApplyResources(this.txt_Nom, "txt_Nom");
            this.txt_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nom", true));
            this.txt_Nom.Name = "txt_Nom";
            // 
            // txt_AdrRue
            // 
            resources.ApplyResources(this.txt_AdrRue, "txt_AdrRue");
            this.txt_AdrRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrRue", true));
            this.txt_AdrRue.Name = "txt_AdrRue";
            // 
            // txt_Tel
            // 
            resources.ApplyResources(this.txt_Tel, "txt_Tel");
            this.txt_Tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Tel", true));
            this.txt_Tel.Name = "txt_Tel";
            // 
            // txt_Mel
            // 
            resources.ApplyResources(this.txt_Mel, "txt_Mel");
            this.txt_Mel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Mel", true));
            this.txt_Mel.Name = "txt_Mel";
            // 
            // txt_AdrVille
            // 
            resources.ApplyResources(this.txt_AdrVille, "txt_AdrVille");
            this.txt_AdrVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrVille", true));
            this.txt_AdrVille.Name = "txt_AdrVille";
            // 
            // txt_Num
            // 
            resources.ApplyResources(this.txt_Num, "txt_Num");
            this.txt_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.txt_Num.Name = "txt_Num";
            // 
            // txt_Prenom
            // 
            resources.ApplyResources(this.txt_Prenom, "txt_Prenom");
            this.txt_Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.txt_Prenom.Name = "txt_Prenom";
            // 
            // txt_AdrCP
            // 
            resources.ApplyResources(this.txt_AdrCP, "txt_AdrCP");
            this.txt_AdrCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrCP", true));
            this.txt_AdrCP.Name = "txt_AdrCP";
            // 
            // btn_valider
            // 
            resources.ApplyResources(this.btn_valider, "btn_valider");
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            resources.ApplyResources(this.btn_annuler, "btn_annuler");
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // lb_Num
            // 
            resources.ApplyResources(this.lb_Num, "lb_Num");
            this.lb_Num.Name = "lb_Num";
            // 
            // lb_Nom
            // 
            resources.ApplyResources(this.lb_Nom, "lb_Nom");
            this.lb_Nom.Name = "lb_Nom";
            // 
            // lb_Prénom
            // 
            resources.ApplyResources(this.lb_Prénom, "lb_Prénom");
            this.lb_Prénom.Name = "lb_Prénom";
            // 
            // lb_AdrRue
            // 
            resources.ApplyResources(this.lb_AdrRue, "lb_AdrRue");
            this.lb_AdrRue.Name = "lb_AdrRue";
            // 
            // lb_AdrCP
            // 
            resources.ApplyResources(this.lb_AdrCP, "lb_AdrCP");
            this.lb_AdrCP.Name = "lb_AdrCP";
            // 
            // lb_Tel
            // 
            resources.ApplyResources(this.lb_Tel, "lb_Tel");
            this.lb_Tel.Name = "lb_Tel";
            // 
            // lb_Mel
            // 
            resources.ApplyResources(this.lb_Mel, "lb_Mel");
            this.lb_Mel.Name = "lb_Mel";
            // 
            // lb_AdrVille
            // 
            resources.ApplyResources(this.lb_AdrVille, "lb_AdrVille");
            this.lb_AdrVille.Name = "lb_AdrVille";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ADOvrai.Adherent);
            // 
            // Form_FicheAdherent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_AdrVille);
            this.Controls.Add(this.lb_Mel);
            this.Controls.Add(this.lb_Tel);
            this.Controls.Add(this.lb_AdrCP);
            this.Controls.Add(this.lb_AdrRue);
            this.Controls.Add(this.lb_Prénom);
            this.Controls.Add(this.lb_Nom);
            this.Controls.Add(this.lb_Num);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_AdrCP);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.txt_AdrVille);
            this.Controls.Add(this.txt_Mel);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_AdrRue);
            this.Controls.Add(this.txt_Nom);
            this.Name = "Form_FicheAdherent";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_AdrRue;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_Mel;
        private System.Windows.Forms.TextBox txt_AdrVille;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_AdrCP;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Label lb_Num;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.Label lb_Prénom;
        private System.Windows.Forms.Label lb_AdrRue;
        private System.Windows.Forms.Label lb_AdrCP;
        private System.Windows.Forms.Label lb_Tel;
        private System.Windows.Forms.Label lb_Mel;
        private System.Windows.Forms.Label lb_AdrVille;
        private System.Windows.Forms.BindingSource bs;
    }
}