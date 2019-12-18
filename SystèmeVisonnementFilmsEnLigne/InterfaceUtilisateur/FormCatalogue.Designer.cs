namespace SystèmeVisonnementFilmsEnLigne.InterfaceUtilisateur
{
    partial class FormCatalogue
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuConnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInscripion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRechercherUnFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitre = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rechercheFilmTitre = new System.Windows.Forms.TextBox();
            this.rechercheFilmRealisateurs = new System.Windows.Forms.TextBox();
            this.rechercheFilmMotsCles = new System.Windows.Forms.TextBox();
            this.rechercheFilmActeurs = new System.Windows.Forms.TextBox();
            this.rechercheFilmMaisonDeProduction = new System.Windows.Forms.TextBox();
            this.rechercheFilmProducteurs = new System.Windows.Forms.TextBox();
            this.rechercheFilmDuree = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rechercheResultat = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechercheFilmDuree)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip2.TabIndex = 5;
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
            // menuTitre
            // 
            this.menuTitre.AutoSize = true;
            this.menuTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.menuTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.menuTitre.Location = new System.Drawing.Point(7, 6);
            this.menuTitre.Name = "menuTitre";
            this.menuTitre.Size = new System.Drawing.Size(42, 17);
            this.menuTitre.TabIndex = 6;
            this.menuTitre.Text = "Titre";
            this.menuTitre.Click += new System.EventHandler(this.label1_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(111, 277);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.Size = new System.Drawing.Size(87, 32);
            this.search.TabIndex = 14;
            this.search.Text = "Rechercher";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Titre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Durée (en\r\nminutes) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Réalisateurs :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mots-Clés :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Producteurs :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "Maisons de\r\nproduction :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Acteurs :";
            // 
            // rechercheFilmTitre
            // 
            this.rechercheFilmTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rechercheFilmTitre.Location = new System.Drawing.Point(98, 57);
            this.rechercheFilmTitre.Name = "rechercheFilmTitre";
            this.rechercheFilmTitre.Size = new System.Drawing.Size(100, 20);
            this.rechercheFilmTitre.TabIndex = 22;
            this.rechercheFilmTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rechercheFilmRealisateurs
            // 
            this.rechercheFilmRealisateurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rechercheFilmRealisateurs.Location = new System.Drawing.Point(98, 146);
            this.rechercheFilmRealisateurs.Name = "rechercheFilmRealisateurs";
            this.rechercheFilmRealisateurs.Size = new System.Drawing.Size(100, 20);
            this.rechercheFilmRealisateurs.TabIndex = 25;
            this.rechercheFilmRealisateurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rechercheFilmMotsCles
            // 
            this.rechercheFilmMotsCles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rechercheFilmMotsCles.Location = new System.Drawing.Point(98, 120);
            this.rechercheFilmMotsCles.Name = "rechercheFilmMotsCles";
            this.rechercheFilmMotsCles.Size = new System.Drawing.Size(100, 20);
            this.rechercheFilmMotsCles.TabIndex = 24;
            this.rechercheFilmMotsCles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rechercheFilmActeurs
            // 
            this.rechercheFilmActeurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rechercheFilmActeurs.Location = new System.Drawing.Point(98, 172);
            this.rechercheFilmActeurs.Name = "rechercheFilmActeurs";
            this.rechercheFilmActeurs.Size = new System.Drawing.Size(100, 20);
            this.rechercheFilmActeurs.TabIndex = 26;
            this.rechercheFilmActeurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rechercheFilmMaisonDeProduction
            // 
            this.rechercheFilmMaisonDeProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rechercheFilmMaisonDeProduction.Location = new System.Drawing.Point(98, 206);
            this.rechercheFilmMaisonDeProduction.Name = "rechercheFilmMaisonDeProduction";
            this.rechercheFilmMaisonDeProduction.Size = new System.Drawing.Size(100, 20);
            this.rechercheFilmMaisonDeProduction.TabIndex = 27;
            this.rechercheFilmMaisonDeProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rechercheFilmProducteurs
            // 
            this.rechercheFilmProducteurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rechercheFilmProducteurs.Location = new System.Drawing.Point(98, 236);
            this.rechercheFilmProducteurs.Name = "rechercheFilmProducteurs";
            this.rechercheFilmProducteurs.Size = new System.Drawing.Size(100, 20);
            this.rechercheFilmProducteurs.TabIndex = 28;
            this.rechercheFilmProducteurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rechercheFilmDuree
            // 
            this.rechercheFilmDuree.Location = new System.Drawing.Point(98, 85);
            this.rechercheFilmDuree.Name = "rechercheFilmDuree";
            this.rechercheFilmDuree.Size = new System.Drawing.Size(100, 20);
            this.rechercheFilmDuree.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(459, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Catalogue";
            // 
            // rechercheResultat
            // 
            this.rechercheResultat.AutoSize = true;
            this.rechercheResultat.Location = new System.Drawing.Point(400, 92);
            this.rechercheResultat.Name = "rechercheResultat";
            this.rechercheResultat.Size = new System.Drawing.Size(107, 13);
            this.rechercheResultat.TabIndex = 31;
            this.rechercheResultat.Text = "Nombre de résultats :";
            // 
            // FormCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.rechercheResultat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rechercheFilmDuree);
            this.Controls.Add(this.rechercheFilmProducteurs);
            this.Controls.Add(this.rechercheFilmMaisonDeProduction);
            this.Controls.Add(this.rechercheFilmActeurs);
            this.Controls.Add(this.rechercheFilmRealisateurs);
            this.Controls.Add(this.rechercheFilmMotsCles);
            this.Controls.Add(this.rechercheFilmTitre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.menuTitre);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormCatalogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogue";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechercheFilmDuree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuConnexion;
        private System.Windows.Forms.ToolStripMenuItem menuInscripion;
        private System.Windows.Forms.ToolStripMenuItem menuRechercherUnFilm;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.Label menuTitre;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rechercheFilmTitre;
        private System.Windows.Forms.TextBox rechercheFilmRealisateurs;
        private System.Windows.Forms.TextBox rechercheFilmMotsCles;
        private System.Windows.Forms.TextBox rechercheFilmActeurs;
        private System.Windows.Forms.TextBox rechercheFilmMaisonDeProduction;
        private System.Windows.Forms.TextBox rechercheFilmProducteurs;
        private System.Windows.Forms.NumericUpDown rechercheFilmDuree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rechercheResultat;
    }
}