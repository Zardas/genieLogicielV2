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
            this.menuTitre = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuConnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInscripion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRechercherUnFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.connexionValidation = new System.Windows.Forms.Button();
            this.inscriptionPasswordLabel = new System.Windows.Forms.Label();
            this.inscriptionPassword = new System.Windows.Forms.TextBox();
            this.inscriptionAdressLabel = new System.Windows.Forms.Label();
            this.inscriptionAdress = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitre
            // 
            this.menuTitre.AutoSize = true;
            this.menuTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.menuTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.menuTitre.Location = new System.Drawing.Point(7, 6);
            this.menuTitre.Name = "menuTitre";
            this.menuTitre.Size = new System.Drawing.Size(42, 17);
            this.menuTitre.TabIndex = 8;
            this.menuTitre.Text = "Titre";
            this.menuTitre.Click += new System.EventHandler(this.menuTitre_Click);
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
            this.menuConnexion.Click += new System.EventHandler(this.menuConnexion_Click);
            // 
            // menuInscripion
            // 
            this.menuInscripion.Name = "menuInscripion";
            this.menuInscripion.Size = new System.Drawing.Size(85, 23);
            this.menuInscripion.Text = "Inscription";
            this.menuInscripion.Click += new System.EventHandler(this.menuInscripion_Click);
            // 
            // menuRechercherUnFilm
            // 
            this.menuRechercherUnFilm.Name = "menuRechercherUnFilm";
            this.menuRechercherUnFilm.Size = new System.Drawing.Size(134, 23);
            this.menuRechercherUnFilm.Text = "Rechercher un film";
            this.menuRechercherUnFilm.Click += new System.EventHandler(this.menuRechercherUnFilm_Click);
            // 
            // menuAccueil
            // 
            this.menuAccueil.Name = "menuAccueil";
            this.menuAccueil.Size = new System.Drawing.Size(63, 23);
            this.menuAccueil.Text = "Accueil";
            this.menuAccueil.Click += new System.EventHandler(this.menuAccueil_Click);
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
            // inscriptionPasswordLabel
            // 
            this.inscriptionPasswordLabel.AutoSize = true;
            this.inscriptionPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.inscriptionPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.inscriptionPasswordLabel.Location = new System.Drawing.Point(309, 161);
            this.inscriptionPasswordLabel.Name = "inscriptionPasswordLabel";
            this.inscriptionPasswordLabel.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionPasswordLabel.Size = new System.Drawing.Size(83, 19);
            this.inscriptionPasswordLabel.TabIndex = 25;
            this.inscriptionPasswordLabel.Text = "Mot de passe :";
            // 
            // inscriptionPassword
            // 
            this.inscriptionPassword.BackColor = System.Drawing.Color.White;
            this.inscriptionPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscriptionPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inscriptionPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscriptionPassword.Location = new System.Drawing.Point(398, 161);
            this.inscriptionPassword.Name = "inscriptionPassword";
            this.inscriptionPassword.Size = new System.Drawing.Size(100, 20);
            this.inscriptionPassword.TabIndex = 24;
            this.inscriptionPassword.Text = "azs654qsJsd";
            this.inscriptionPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inscriptionPassword.UseSystemPasswordChar = true;
            // 
            // inscriptionAdressLabel
            // 
            this.inscriptionAdressLabel.AutoSize = true;
            this.inscriptionAdressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.inscriptionAdressLabel.ForeColor = System.Drawing.Color.Black;
            this.inscriptionAdressLabel.Location = new System.Drawing.Point(202, 108);
            this.inscriptionAdressLabel.Name = "inscriptionAdressLabel";
            this.inscriptionAdressLabel.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionAdressLabel.Size = new System.Drawing.Size(190, 19);
            this.inscriptionAdressLabel.TabIndex = 21;
            this.inscriptionAdressLabel.Text = "Adresse courriel ou nom d\'utilisateur : ";
            this.inscriptionAdressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inscriptionAdressLabel.Click += new System.EventHandler(this.inscriptionAdress_Click);
            // 
            // inscriptionAdress
            // 
            this.inscriptionAdress.BackColor = System.Drawing.Color.White;
            this.inscriptionAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscriptionAdress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inscriptionAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscriptionAdress.Location = new System.Drawing.Point(398, 107);
            this.inscriptionAdress.Name = "inscriptionAdress";
            this.inscriptionAdress.Size = new System.Drawing.Size(113, 20);
            this.inscriptionAdress.TabIndex = 20;
            this.inscriptionAdress.Text = "example@domain.ca";
            this.inscriptionAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(389, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Inscription";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.connexionValidation);
            this.Controls.Add(this.inscriptionPasswordLabel);
            this.Controls.Add(this.inscriptionPassword);
            this.Controls.Add(this.inscriptionAdressLabel);
            this.Controls.Add(this.inscriptionAdress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuTitre);
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

        private System.Windows.Forms.Label menuTitre;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuConnexion;
        private System.Windows.Forms.ToolStripMenuItem menuInscripion;
        private System.Windows.Forms.ToolStripMenuItem menuRechercherUnFilm;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button connexionValidation;
        private System.Windows.Forms.Label inscriptionPasswordLabel;
        private System.Windows.Forms.TextBox inscriptionPassword;
        private System.Windows.Forms.Label inscriptionAdressLabel;
        private System.Windows.Forms.TextBox inscriptionAdress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}