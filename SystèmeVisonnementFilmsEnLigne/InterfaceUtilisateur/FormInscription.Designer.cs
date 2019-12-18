namespace SystèmeVisonnementFilmsEnLigne.InterfaceUtilisateur
{
    partial class FormInscription
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inscriptionAdress = new System.Windows.Forms.TextBox();
            this.inscriptionAdressLabel = new System.Windows.Forms.Label();
            this.inscriptionValidation = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.inscriptionPasswordLabel = new System.Windows.Forms.Label();
            this.inscriptionPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInscription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inscriptionPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inscriptionName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inscriptionAdressIRL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inscriptionTelephone = new System.Windows.Forms.TextBox();
            this.accepteRecevoirNouvautes = new System.Windows.Forms.CheckBox();
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
            this.menuTitre.Click += new System.EventHandler(this.label1_Click);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.textBox1.Location = new System.Drawing.Point(0, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(784, 19);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "INSCRIPTION";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inscriptionAdress
            // 
            this.inscriptionAdress.BackColor = System.Drawing.Color.White;
            this.inscriptionAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscriptionAdress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inscriptionAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscriptionAdress.Location = new System.Drawing.Point(367, 101);
            this.inscriptionAdress.Name = "inscriptionAdress";
            this.inscriptionAdress.Size = new System.Drawing.Size(113, 20);
            this.inscriptionAdress.TabIndex = 10;
            this.inscriptionAdress.Text = "example@domain.ca";
            this.inscriptionAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inscriptionAdressLabel
            // 
            this.inscriptionAdressLabel.AutoSize = true;
            this.inscriptionAdressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.inscriptionAdressLabel.ForeColor = System.Drawing.Color.Black;
            this.inscriptionAdressLabel.Location = new System.Drawing.Point(267, 102);
            this.inscriptionAdressLabel.Name = "inscriptionAdressLabel";
            this.inscriptionAdressLabel.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionAdressLabel.Size = new System.Drawing.Size(94, 19);
            this.inscriptionAdressLabel.TabIndex = 11;
            this.inscriptionAdressLabel.Text = "Adresse courriel :";
            // 
            // inscriptionValidation
            // 
            this.inscriptionValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inscriptionValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscriptionValidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.inscriptionValidation.Location = new System.Drawing.Point(333, 278);
            this.inscriptionValidation.Name = "inscriptionValidation";
            this.inscriptionValidation.Size = new System.Drawing.Size(97, 35);
            this.inscriptionValidation.TabIndex = 16;
            this.inscriptionValidation.Text = "Inscription";
            this.inscriptionValidation.UseVisualStyleBackColor = true;
            this.inscriptionValidation.Click += new System.EventHandler(this.inscriptionValidation_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(283, 329);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "Déjà inscrit ? ";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inscriptionPasswordLabel
            // 
            this.inscriptionPasswordLabel.AutoSize = true;
            this.inscriptionPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.inscriptionPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.inscriptionPasswordLabel.Location = new System.Drawing.Point(397, 141);
            this.inscriptionPasswordLabel.Name = "inscriptionPasswordLabel";
            this.inscriptionPasswordLabel.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionPasswordLabel.Size = new System.Drawing.Size(83, 19);
            this.inscriptionPasswordLabel.TabIndex = 29;
            this.inscriptionPasswordLabel.Text = "Mot de passe :";
            // 
            // inscriptionPassword
            // 
            this.inscriptionPassword.BackColor = System.Drawing.Color.White;
            this.inscriptionPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscriptionPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inscriptionPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscriptionPassword.Location = new System.Drawing.Point(486, 141);
            this.inscriptionPassword.Name = "inscriptionPassword";
            this.inscriptionPassword.Size = new System.Drawing.Size(100, 20);
            this.inscriptionPassword.TabIndex = 28;
            this.inscriptionPassword.Text = "azs654qsJsd";
            this.inscriptionPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inscriptionPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(165, 138);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nom d\'utilisateur : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameInscription
            // 
            this.usernameInscription.BackColor = System.Drawing.Color.White;
            this.usernameInscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInscription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameInscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameInscription.Location = new System.Drawing.Point(270, 139);
            this.usernameInscription.Name = "usernameInscription";
            this.usernameInscription.Size = new System.Drawing.Size(113, 20);
            this.usernameInscription.TabIndex = 26;
            this.usernameInscription.Text = "Jean-Luc Picard";
            this.usernameInscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(156, 213);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Prénom :";
            // 
            // inscriptionPrenom
            // 
            this.inscriptionPrenom.BackColor = System.Drawing.Color.White;
            this.inscriptionPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscriptionPrenom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inscriptionPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscriptionPrenom.Location = new System.Drawing.Point(217, 213);
            this.inscriptionPrenom.Name = "inscriptionPrenom";
            this.inscriptionPrenom.Size = new System.Drawing.Size(100, 20);
            this.inscriptionPrenom.TabIndex = 32;
            this.inscriptionPrenom.Text = "Picard";
            this.inscriptionPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(167, 188);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nom : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inscriptionName
            // 
            this.inscriptionName.BackColor = System.Drawing.Color.White;
            this.inscriptionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscriptionName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inscriptionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscriptionName.Location = new System.Drawing.Point(217, 187);
            this.inscriptionName.Name = "inscriptionName";
            this.inscriptionName.Size = new System.Drawing.Size(113, 20);
            this.inscriptionName.TabIndex = 30;
            this.inscriptionName.Text = "Jean-Luc";
            this.inscriptionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(423, 213);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adresse :";
            // 
            // inscriptionAdressIRL
            // 
            this.inscriptionAdressIRL.BackColor = System.Drawing.Color.White;
            this.inscriptionAdressIRL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscriptionAdressIRL.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inscriptionAdressIRL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscriptionAdressIRL.Location = new System.Drawing.Point(486, 213);
            this.inscriptionAdressIRL.Name = "inscriptionAdressIRL";
            this.inscriptionAdressIRL.Size = new System.Drawing.Size(100, 20);
            this.inscriptionAdressIRL.TabIndex = 36;
            this.inscriptionAdressIRL.Text = "Far away";
            this.inscriptionAdressIRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(356, 188);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Numéro de téléphone : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inscriptionTelephone
            // 
            this.inscriptionTelephone.BackColor = System.Drawing.Color.White;
            this.inscriptionTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscriptionTelephone.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inscriptionTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscriptionTelephone.Location = new System.Drawing.Point(486, 187);
            this.inscriptionTelephone.Name = "inscriptionTelephone";
            this.inscriptionTelephone.Size = new System.Drawing.Size(113, 20);
            this.inscriptionTelephone.TabIndex = 34;
            this.inscriptionTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // accepteRecevoirNouvautes
            // 
            this.accepteRecevoirNouvautes.AutoSize = true;
            this.accepteRecevoirNouvautes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accepteRecevoirNouvautes.Location = new System.Drawing.Point(400, 239);
            this.accepteRecevoirNouvautes.Name = "accepteRecevoirNouvautes";
            this.accepteRecevoirNouvautes.Size = new System.Drawing.Size(201, 17);
            this.accepteRecevoirNouvautes.TabIndex = 39;
            this.accepteRecevoirNouvautes.Text = "J\'accepte de recevoir des nouvautés";
            this.accepteRecevoirNouvautes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(389, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Connexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accepteRecevoirNouvautes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inscriptionAdressIRL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inscriptionTelephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inscriptionPrenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inscriptionName);
            this.Controls.Add(this.inscriptionPasswordLabel);
            this.Controls.Add(this.inscriptionPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameInscription);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.inscriptionValidation);
            this.Controls.Add(this.inscriptionAdressLabel);
            this.Controls.Add(this.inscriptionAdress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuTitre);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox inscriptionAdress;
        private System.Windows.Forms.Label inscriptionAdressLabel;
        private System.Windows.Forms.Button inscriptionValidation;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label inscriptionPasswordLabel;
        private System.Windows.Forms.TextBox inscriptionPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameInscription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inscriptionPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inscriptionName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inscriptionAdressIRL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inscriptionTelephone;
        private System.Windows.Forms.CheckBox accepteRecevoirNouvautes;
        private System.Windows.Forms.Button button1;
    }
}