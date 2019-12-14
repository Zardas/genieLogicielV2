namespace SystèmeVisonnementFilmsEnLigne.InterfaceUtilisateur
{
    partial class FormConnexion
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuConnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInscripion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRechercherUnFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.dejaInscrit = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.connexionValidation = new System.Windows.Forms.Button();
            this.inscriptionPassword = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.inscriptionAdress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titre";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnexion,
            this.menuInscripion,
            this.menuRechercherUnFilm,
            this.menuAccueil});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(784, 27);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuConnexion
            // 
            this.menuConnexion.Name = "menuConnexion";
            this.menuConnexion.Size = new System.Drawing.Size(86, 23);
            this.menuConnexion.Text = "Connexion";
            // 
            // menuInscripion
            // 
            this.menuInscripion.Name = "menuInscripion";
            this.menuInscripion.Size = new System.Drawing.Size(85, 23);
            this.menuInscripion.Text = "Inscription";
            // 
            // menuRechercherUnFilm
            // 
            this.menuRechercherUnFilm.Name = "menuRechercherUnFilm";
            this.menuRechercherUnFilm.Size = new System.Drawing.Size(134, 23);
            this.menuRechercherUnFilm.Text = "Rechercher un film";
            // 
            // menuAccueil
            // 
            this.menuAccueil.Name = "menuAccueil";
            this.menuAccueil.Size = new System.Drawing.Size(63, 23);
            this.menuAccueil.Text = "Accueil";
            // 
            // dejaInscrit
            // 
            this.dejaInscrit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.dejaInscrit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dejaInscrit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dejaInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dejaInscrit.Location = new System.Drawing.Point(389, 272);
            this.dejaInscrit.Name = "dejaInscrit";
            this.dejaInscrit.Size = new System.Drawing.Size(100, 13);
            this.dejaInscrit.TabIndex = 28;
            this.dejaInscrit.Text = "Inscription";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(283, 272);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Pas encore inscrit ? ";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // connexionValidation
            // 
            this.connexionValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexionValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexionValidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.connexionValidation.Location = new System.Drawing.Point(333, 203);
            this.connexionValidation.Name = "connexionValidation";
            this.connexionValidation.Size = new System.Drawing.Size(97, 35);
            this.connexionValidation.TabIndex = 26;
            this.connexionValidation.Text = "Connexion";
            this.connexionValidation.UseVisualStyleBackColor = true;
            this.connexionValidation.Click += new System.EventHandler(this.inscriptionValidation_Click);
            // 
            // inscriptionPassword
            // 
            this.inscriptionPassword.AutoSize = true;
            this.inscriptionPassword.BackColor = System.Drawing.Color.White;
            this.inscriptionPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inscriptionPassword.Location = new System.Drawing.Point(385, 145);
            this.inscriptionPassword.Name = "inscriptionPassword";
            this.inscriptionPassword.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionPassword.Size = new System.Drawing.Size(74, 19);
            this.inscriptionPassword.TabIndex = 25;
            this.inscriptionPassword.Text = "azs654qsJsd";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Location = new System.Drawing.Point(279, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 24;
            this.textBox4.Text = "Mot de passe :";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inscriptionAdress
            // 
            this.inscriptionAdress.AutoSize = true;
            this.inscriptionAdress.BackColor = System.Drawing.Color.White;
            this.inscriptionAdress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.inscriptionAdress.Location = new System.Drawing.Point(429, 101);
            this.inscriptionAdress.Name = "inscriptionAdress";
            this.inscriptionAdress.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionAdress.Size = new System.Drawing.Size(112, 19);
            this.inscriptionAdress.TabIndex = 21;
            this.inscriptionAdress.Text = "example@domain.ca";
            this.inscriptionAdress.Click += new System.EventHandler(this.inscriptionAdress_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Location = new System.Drawing.Point(241, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 13);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Adresse courriel ou nom d\'utilisateur :";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.textBox1.Location = new System.Drawing.Point(0, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(784, 19);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "CONNEXION";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dejaInscrit);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.connexionValidation);
            this.Controls.Add(this.inscriptionPassword);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.inscriptionAdress);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuConnexion;
        private System.Windows.Forms.ToolStripMenuItem menuInscripion;
        private System.Windows.Forms.ToolStripMenuItem menuRechercherUnFilm;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.TextBox dejaInscrit;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button connexionValidation;
        private System.Windows.Forms.Label inscriptionPassword;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label inscriptionAdress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}