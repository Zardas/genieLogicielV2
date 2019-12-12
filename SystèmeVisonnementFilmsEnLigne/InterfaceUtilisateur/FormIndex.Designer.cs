namespace SystèmeVisonnementFilmsEnLigne.InterfaceUtilisateur
{
    partial class FormIndex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAccessCatalogue = new System.Windows.Forms.Button();
            this.menuConnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInscription = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRechercherUnFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonAccessCatalogue.TabIndex = 3;
            this.buttonAccessCatalogue.Text = "Accéder au catalogue";
            this.buttonAccessCatalogue.UseVisualStyleBackColor = false;
            this.buttonAccessCatalogue.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuConnexion
            // 
            this.menuConnexion.Name = "menuConnexion";
            this.menuConnexion.Size = new System.Drawing.Size(86, 23);
            this.menuConnexion.Text = "Connexion";
            // 
            // menuInscription
            // 
            this.menuInscription.Name = "menuInscription";
            this.menuInscription.Size = new System.Drawing.Size(85, 23);
            this.menuInscription.Text = "Inscription";
            this.menuInscription.Click += new System.EventHandler(this.menuInscription_Click);
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
            this.menuAccueil.Click += new System.EventHandler(this.accueilToolStripMenuItem1_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnexion,
            this.menuInscription,
            this.menuRechercherUnFilm,
            this.menuAccueil});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(784, 27);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAccessCatalogue);
            this.Controls.Add(this.menu);
            this.Name = "FormIndex";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAccessCatalogue;
        private System.Windows.Forms.ToolStripMenuItem menuConnexion;
        private System.Windows.Forms.ToolStripMenuItem menuInscription;
        private System.Windows.Forms.ToolStripMenuItem menuRechercherUnFilm;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label label1;
    }
}

