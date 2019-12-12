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
            this.label1 = new System.Windows.Forms.Label();
            this.titleSearch = new System.Windows.Forms.Label();
            this.titleSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.dureeSearchCheckbox = new System.Windows.Forms.CheckBox();
            this.dureeSearch = new System.Windows.Forms.Label();
            this.categorieSearchCheckbox = new System.Windows.Forms.CheckBox();
            this.categorieSearch = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleSearch
            // 
            this.titleSearch.AutoSize = true;
            this.titleSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleSearch.Location = new System.Drawing.Point(121, 44);
            this.titleSearch.Name = "titleSearch";
            this.titleSearch.Padding = new System.Windows.Forms.Padding(3);
            this.titleSearch.Size = new System.Drawing.Size(36, 21);
            this.titleSearch.TabIndex = 7;
            this.titleSearch.Text = "Titre";
            // 
            // titleSearchCheckBox
            // 
            this.titleSearchCheckBox.AutoSize = true;
            this.titleSearchCheckBox.Location = new System.Drawing.Point(159, 46);
            this.titleSearchCheckBox.Name = "titleSearchCheckBox";
            this.titleSearchCheckBox.Size = new System.Drawing.Size(47, 17);
            this.titleSearchCheckBox.TabIndex = 9;
            this.titleSearchCheckBox.Text = "Titre";
            this.titleSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // dureeSearchCheckbox
            // 
            this.dureeSearchCheckbox.AutoSize = true;
            this.dureeSearchCheckbox.Location = new System.Drawing.Point(272, 47);
            this.dureeSearchCheckbox.Name = "dureeSearchCheckbox";
            this.dureeSearchCheckbox.Size = new System.Drawing.Size(55, 17);
            this.dureeSearchCheckbox.TabIndex = 11;
            this.dureeSearchCheckbox.Text = "Durée";
            this.dureeSearchCheckbox.UseVisualStyleBackColor = true;
            // 
            // dureeSearch
            // 
            this.dureeSearch.AutoSize = true;
            this.dureeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dureeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dureeSearch.Location = new System.Drawing.Point(236, 44);
            this.dureeSearch.Name = "dureeSearch";
            this.dureeSearch.Padding = new System.Windows.Forms.Padding(3);
            this.dureeSearch.Size = new System.Drawing.Size(33, 21);
            this.dureeSearch.TabIndex = 10;
            this.dureeSearch.Text = "120";
            // 
            // categorieSearchCheckbox
            // 
            this.categorieSearchCheckbox.AutoSize = true;
            this.categorieSearchCheckbox.Location = new System.Drawing.Point(409, 45);
            this.categorieSearchCheckbox.Name = "categorieSearchCheckbox";
            this.categorieSearchCheckbox.Size = new System.Drawing.Size(55, 17);
            this.categorieSearchCheckbox.TabIndex = 13;
            this.categorieSearchCheckbox.Text = "Durée";
            this.categorieSearchCheckbox.UseVisualStyleBackColor = true;
            // 
            // categorieSearch
            // 
            this.categorieSearch.AutoSize = true;
            this.categorieSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categorieSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categorieSearch.Location = new System.Drawing.Point(350, 43);
            this.categorieSearch.Name = "categorieSearch";
            this.categorieSearch.Padding = new System.Windows.Forms.Padding(3);
            this.categorieSearch.Size = new System.Drawing.Size(56, 21);
            this.categorieSearch.TabIndex = 12;
            this.categorieSearch.Text = "Comédie";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(501, 36);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.Size = new System.Drawing.Size(87, 32);
            this.search.TabIndex = 14;
            this.search.Text = "Rechercher";
            this.search.UseVisualStyleBackColor = false;
            // 
            // FormCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.search);
            this.Controls.Add(this.categorieSearchCheckbox);
            this.Controls.Add(this.categorieSearch);
            this.Controls.Add(this.dureeSearchCheckbox);
            this.Controls.Add(this.dureeSearch);
            this.Controls.Add(this.titleSearchCheckBox);
            this.Controls.Add(this.titleSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormCatalogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogue";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuConnexion;
        private System.Windows.Forms.ToolStripMenuItem menuInscripion;
        private System.Windows.Forms.ToolStripMenuItem menuRechercherUnFilm;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleSearch;
        private System.Windows.Forms.CheckBox titleSearchCheckBox;
        private System.Windows.Forms.CheckBox dureeSearchCheckbox;
        private System.Windows.Forms.Label dureeSearch;
        private System.Windows.Forms.CheckBox categorieSearchCheckbox;
        private System.Windows.Forms.Label categorieSearch;
        private System.Windows.Forms.Button search;
    }
}