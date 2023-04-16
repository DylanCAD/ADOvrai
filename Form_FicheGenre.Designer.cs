namespace ADOvrai
{
    partial class Form_FicheGenre
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
            this.txt_Libelle = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lb_Num = new System.Windows.Forms.Label();
            this.lb_Libelle = new System.Windows.Forms.Label();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Num
            // 
            this.txt_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.txt_Num.Enabled = false;
            this.txt_Num.Location = new System.Drawing.Point(444, 47);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 22);
            this.txt_Num.TabIndex = 0;
            // 
            // txt_Libelle
            // 
            this.txt_Libelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Libelle", true));
            this.txt_Libelle.Location = new System.Drawing.Point(444, 112);
            this.txt_Libelle.Name = "txt_Libelle";
            this.txt_Libelle.Size = new System.Drawing.Size(100, 22);
            this.txt_Libelle.TabIndex = 1;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(161, 364);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(444, 364);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 5;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lb_Num
            // 
            this.lb_Num.AutoSize = true;
            this.lb_Num.Location = new System.Drawing.Point(73, 47);
            this.lb_Num.Name = "lb_Num";
            this.lb_Num.Size = new System.Drawing.Size(55, 16);
            this.lb_Num.TabIndex = 6;
            this.lb_Num.Text = "Numéro";
            // 
            // lb_Libelle
            // 
            this.lb_Libelle.AutoSize = true;
            this.lb_Libelle.Location = new System.Drawing.Point(76, 112);
            this.lb_Libelle.Name = "lb_Libelle";
            this.lb_Libelle.Size = new System.Drawing.Size(47, 16);
            this.lb_Libelle.TabIndex = 7;
            this.lb_Libelle.Text = "Libelle";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ADOvrai.Genre);
            // 
            // Form_FicheGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Libelle);
            this.Controls.Add(this.lb_Num);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.txt_Libelle);
            this.Controls.Add(this.txt_Num);
            this.Name = "Form_FicheGenre";
            this.Text = "Form_FicheGenre";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_Libelle;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lb_Num;
        private System.Windows.Forms.Label lb_Libelle;
        private System.Windows.Forms.BindingSource bs;
    }
}