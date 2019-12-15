namespace SystèmeVisonnementFilmsEnLigne.InterfaceUtilisateur
{
    partial class FormAjouterFilm
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
            this.inscriptionAdressLabel = new System.Windows.Forms.Label();
            this.ajoutTitre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ajoutRealisateur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ajoutMotCles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ajoutProducteur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ajoutActeur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ajoutMaisonDeProduction = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ajoutSynopsis = new System.Windows.Forms.TextBox();
            this.ajoutValidation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuConnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInscripion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRechercherUnFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutValide = new System.Windows.Forms.Label();
            this.ajoutDuree = new System.Windows.Forms.NumericUpDown();
            this.ajoutCoutAchat = new System.Windows.Forms.NumericUpDown();
            this.ajoutCoutVisionnement = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutDuree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutCoutAchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutCoutVisionnement)).BeginInit();
            this.SuspendLayout();
            // 
            // inscriptionAdressLabel
            // 
            this.inscriptionAdressLabel.AutoSize = true;
            this.inscriptionAdressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.inscriptionAdressLabel.ForeColor = System.Drawing.Color.Black;
            this.inscriptionAdressLabel.Location = new System.Drawing.Point(272, 55);
            this.inscriptionAdressLabel.Name = "inscriptionAdressLabel";
            this.inscriptionAdressLabel.Padding = new System.Windows.Forms.Padding(3);
            this.inscriptionAdressLabel.Size = new System.Drawing.Size(40, 19);
            this.inscriptionAdressLabel.TabIndex = 23;
            this.inscriptionAdressLabel.Text = "Titre :";
            this.inscriptionAdressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ajoutTitre
            // 
            this.ajoutTitre.BackColor = System.Drawing.Color.White;
            this.ajoutTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ajoutTitre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ajoutTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ajoutTitre.Location = new System.Drawing.Point(318, 56);
            this.ajoutTitre.Name = "ajoutTitre";
            this.ajoutTitre.Size = new System.Drawing.Size(120, 20);
            this.ajoutTitre.TabIndex = 22;
            this.ajoutTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(204, 83);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Durée (en minutes) :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(357, 121);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Coût visionnement ($) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(139, 121);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Coût achat ($) :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 210);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Réalisateurs :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ajoutRealisateur
            // 
            this.ajoutRealisateur.BackColor = System.Drawing.Color.White;
            this.ajoutRealisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ajoutRealisateur.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ajoutRealisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ajoutRealisateur.Location = new System.Drawing.Point(126, 211);
            this.ajoutRealisateur.Name = "ajoutRealisateur";
            this.ajoutRealisateur.Size = new System.Drawing.Size(113, 20);
            this.ajoutRealisateur.TabIndex = 32;
            this.ajoutRealisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(55, 186);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Mots-Clés :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ajoutMotCles
            // 
            this.ajoutMotCles.BackColor = System.Drawing.Color.White;
            this.ajoutMotCles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ajoutMotCles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ajoutMotCles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ajoutMotCles.Location = new System.Drawing.Point(126, 185);
            this.ajoutMotCles.Name = "ajoutMotCles";
            this.ajoutMotCles.Size = new System.Drawing.Size(113, 20);
            this.ajoutMotCles.TabIndex = 30;
            this.ajoutMotCles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(43, 236);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Producteurs :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ajoutProducteur
            // 
            this.ajoutProducteur.BackColor = System.Drawing.Color.White;
            this.ajoutProducteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ajoutProducteur.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ajoutProducteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ajoutProducteur.Location = new System.Drawing.Point(126, 237);
            this.ajoutProducteur.Name = "ajoutProducteur";
            this.ajoutProducteur.Size = new System.Drawing.Size(113, 20);
            this.ajoutProducteur.TabIndex = 34;
            this.ajoutProducteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(64, 291);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Acteurs :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ajoutActeur
            // 
            this.ajoutActeur.BackColor = System.Drawing.Color.White;
            this.ajoutActeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ajoutActeur.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ajoutActeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ajoutActeur.Location = new System.Drawing.Point(126, 290);
            this.ajoutActeur.Name = "ajoutActeur";
            this.ajoutActeur.Size = new System.Drawing.Size(113, 20);
            this.ajoutActeur.TabIndex = 38;
            this.ajoutActeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(-1, 265);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(121, 19);
            this.label10.TabIndex = 37;
            this.label10.Text = "Maison de production :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ajoutMaisonDeProduction
            // 
            this.ajoutMaisonDeProduction.BackColor = System.Drawing.Color.White;
            this.ajoutMaisonDeProduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ajoutMaisonDeProduction.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ajoutMaisonDeProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ajoutMaisonDeProduction.Location = new System.Drawing.Point(126, 264);
            this.ajoutMaisonDeProduction.Name = "ajoutMaisonDeProduction";
            this.ajoutMaisonDeProduction.Size = new System.Drawing.Size(113, 20);
            this.ajoutMaisonDeProduction.TabIndex = 36;
            this.ajoutMaisonDeProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(298, 184);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Synopsis :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ajoutSynopsis
            // 
            this.ajoutSynopsis.BackColor = System.Drawing.Color.White;
            this.ajoutSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ajoutSynopsis.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ajoutSynopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ajoutSynopsis.Location = new System.Drawing.Point(365, 187);
            this.ajoutSynopsis.Multiline = true;
            this.ajoutSynopsis.Name = "ajoutSynopsis";
            this.ajoutSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ajoutSynopsis.Size = new System.Drawing.Size(232, 123);
            this.ajoutSynopsis.TabIndex = 40;
            this.ajoutSynopsis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ajoutValidation
            // 
            this.ajoutValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajoutValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutValidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.ajoutValidation.Location = new System.Drawing.Point(613, 265);
            this.ajoutValidation.Name = "ajoutValidation";
            this.ajoutValidation.Size = new System.Drawing.Size(106, 45);
            this.ajoutValidation.TabIndex = 42;
            this.ajoutValidation.Text = "Ajouter le film";
            this.ajoutValidation.UseVisualStyleBackColor = true;
            this.ajoutValidation.Click += new System.EventHandler(this.ajoutValidation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 44;
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
            this.menuStrip2.TabIndex = 43;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuConnexion
            // 
            this.menuConnexion.Name = "menuConnexion";
            this.menuConnexion.Size = new System.Drawing.Size(100, 23);
            this.menuConnexion.Text = "Deconnexion";
            // 
            // menuInscripion
            // 
            this.menuInscripion.Name = "menuInscripion";
            this.menuInscripion.Size = new System.Drawing.Size(100, 23);
            this.menuInscripion.Text = "Mon compte";
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
            // ajoutValide
            // 
            this.ajoutValide.AutoSize = true;
            this.ajoutValide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ajoutValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutValide.ForeColor = System.Drawing.Color.Black;
            this.ajoutValide.Location = new System.Drawing.Point(340, 333);
            this.ajoutValide.Name = "ajoutValide";
            this.ajoutValide.Padding = new System.Windows.Forms.Padding(3);
            this.ajoutValide.Size = new System.Drawing.Size(6, 19);
            this.ajoutValide.TabIndex = 45;
            this.ajoutValide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ajoutDuree
            // 
            this.ajoutDuree.Location = new System.Drawing.Point(318, 84);
            this.ajoutDuree.Name = "ajoutDuree";
            this.ajoutDuree.Size = new System.Drawing.Size(120, 20);
            this.ajoutDuree.TabIndex = 46;
            // 
            // ajoutCoutAchat
            // 
            this.ajoutCoutAchat.Location = new System.Drawing.Point(231, 122);
            this.ajoutCoutAchat.Name = "ajoutCoutAchat";
            this.ajoutCoutAchat.Size = new System.Drawing.Size(120, 20);
            this.ajoutCoutAchat.TabIndex = 47;
            // 
            // ajoutCoutVisionnement
            // 
            this.ajoutCoutVisionnement.Location = new System.Drawing.Point(484, 122);
            this.ajoutCoutVisionnement.Name = "ajoutCoutVisionnement";
            this.ajoutCoutVisionnement.Size = new System.Drawing.Size(120, 20);
            this.ajoutCoutVisionnement.TabIndex = 48;
            // 
            // FormAjouterFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.ajoutCoutVisionnement);
            this.Controls.Add(this.ajoutCoutAchat);
            this.Controls.Add(this.ajoutDuree);
            this.Controls.Add(this.ajoutValide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.ajoutValidation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ajoutSynopsis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ajoutActeur);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ajoutMaisonDeProduction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ajoutProducteur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ajoutRealisateur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ajoutMotCles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inscriptionAdressLabel);
            this.Controls.Add(this.ajoutTitre);
            this.Name = "FormAjouterFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un film";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutDuree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutCoutAchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutCoutVisionnement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inscriptionAdressLabel;
        private System.Windows.Forms.TextBox ajoutTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ajoutRealisateur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ajoutMotCles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ajoutProducteur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ajoutActeur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ajoutMaisonDeProduction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ajoutSynopsis;
        private System.Windows.Forms.Button ajoutValidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuConnexion;
        private System.Windows.Forms.ToolStripMenuItem menuInscripion;
        private System.Windows.Forms.ToolStripMenuItem menuRechercherUnFilm;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.Label ajoutValide;
        private System.Windows.Forms.NumericUpDown ajoutDuree;
        private System.Windows.Forms.NumericUpDown ajoutCoutAchat;
        private System.Windows.Forms.NumericUpDown ajoutCoutVisionnement;
    }
}