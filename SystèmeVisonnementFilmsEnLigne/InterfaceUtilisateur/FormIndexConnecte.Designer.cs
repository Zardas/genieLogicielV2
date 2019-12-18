namespace SystèmeVisonnementFilmsEnLigne.InterfaceUtilisateur
{
    partial class FormIndexConnecte
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
            this.buttonAccessCatalogue = new System.Windows.Forms.Button();
            this.menuDéconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRechercherUnFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitre = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAccessCatalogue
            // 
            this.buttonAccessCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.buttonAccessCatalogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccessCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccessCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAccessCatalogue.Location = new System.Drawing.Point(275, 152);
            this.buttonAccessCatalogue.Name = "buttonAccessCatalogue";
            this.buttonAccessCatalogue.Size = new System.Drawing.Size(202, 64);
            this.buttonAccessCatalogue.TabIndex = 7;
            this.buttonAccessCatalogue.Text = "Accéder au catalogue";
            this.buttonAccessCatalogue.UseVisualStyleBackColor = false;
            this.buttonAccessCatalogue.Click += new System.EventHandler(this.buttonAccessCatalogue_Click);
            // 
            // menuDéconnexion
            // 
            this.menuDéconnexion.Name = "menuDéconnexion";
            this.menuDéconnexion.Size = new System.Drawing.Size(100, 23);
            this.menuDéconnexion.Text = "Déconnexion";
            this.menuDéconnexion.Click += new System.EventHandler(this.menuDéconnexion_Click);
            // 
            // menuMonCompte
            // 
            this.menuMonCompte.Name = "menuMonCompte";
            this.menuMonCompte.Size = new System.Drawing.Size(103, 23);
            this.menuMonCompte.Text = "Mon Compte";
            this.menuMonCompte.Click += new System.EventHandler(this.menuMonCompte_Click);
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
            this.menuTitre.TabIndex = 8;
            this.menuTitre.Text = "Titre";
            this.menuTitre.Click += new System.EventHandler(this.menuTitre_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDéconnexion,
            this.menuMonCompte,
            this.menuRechercherUnFilm,
            this.menuAccueil});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(784, 27);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip2";
            // 
            // FormIndexConnecte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.buttonAccessCatalogue);
            this.Controls.Add(this.menuTitre);
            this.Controls.Add(this.menu);
            this.Name = "FormIndexConnecte";
            this.Text = "Index";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccessCatalogue;
        private System.Windows.Forms.ToolStripMenuItem menuDéconnexion;
        private System.Windows.Forms.ToolStripMenuItem menuMonCompte;
        private System.Windows.Forms.ToolStripMenuItem menuRechercherUnFilm;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.Label menuTitre;
        private System.Windows.Forms.MenuStrip menu;
    }
}