namespace SystèmeVisonnementFilmsEnLigne.InterfaceUtilisateur
{
    partial class FormModificationCompte
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
            this.modificationPassword2 = new System.Windows.Forms.Label();
            this.modificationPassword = new System.Windows.Forms.TextBox();
            this.modificationUsername2 = new System.Windows.Forms.Label();
            this.modificationUsername = new System.Windows.Forms.TextBox();
            this.modificationAdress2 = new System.Windows.Forms.Label();
            this.modificationAdress = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.modificationValidation = new System.Windows.Forms.Button();
            this.accepteRecevoirNouvautes = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.messageValidation = new System.Windows.Forms.TextBox();
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
            this.label1.TabIndex = 10;
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
            this.menuStrip2.TabIndex = 9;
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
            // modificationPassword2
            // 
            this.modificationPassword2.AutoSize = true;
            this.modificationPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.modificationPassword2.ForeColor = System.Drawing.Color.Black;
            this.modificationPassword2.Location = new System.Drawing.Point(294, 181);
            this.modificationPassword2.Name = "modificationPassword2";
            this.modificationPassword2.Padding = new System.Windows.Forms.Padding(3);
            this.modificationPassword2.Size = new System.Drawing.Size(83, 19);
            this.modificationPassword2.TabIndex = 21;
            this.modificationPassword2.Text = "Mot de passe :";
            // 
            // modificationPassword
            // 
            this.modificationPassword.BackColor = System.Drawing.Color.White;
            this.modificationPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modificationPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modificationPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modificationPassword.Location = new System.Drawing.Point(383, 181);
            this.modificationPassword.Name = "modificationPassword";
            this.modificationPassword.Size = new System.Drawing.Size(100, 13);
            this.modificationPassword.TabIndex = 20;
            this.modificationPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.modificationPassword.UseSystemPasswordChar = true;
            // 
            // modificationUsername2
            // 
            this.modificationUsername2.AutoSize = true;
            this.modificationUsername2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.modificationUsername2.ForeColor = System.Drawing.Color.Black;
            this.modificationUsername2.Location = new System.Drawing.Point(281, 145);
            this.modificationUsername2.Name = "modificationUsername2";
            this.modificationUsername2.Padding = new System.Windows.Forms.Padding(3);
            this.modificationUsername2.Size = new System.Drawing.Size(96, 19);
            this.modificationUsername2.TabIndex = 19;
            this.modificationUsername2.Text = "Nom d\'utilisateur :";
            // 
            // modificationUsername
            // 
            this.modificationUsername.BackColor = System.Drawing.Color.White;
            this.modificationUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modificationUsername.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modificationUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modificationUsername.Location = new System.Drawing.Point(383, 145);
            this.modificationUsername.Name = "modificationUsername";
            this.modificationUsername.Size = new System.Drawing.Size(100, 13);
            this.modificationUsername.TabIndex = 18;
            this.modificationUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // modificationAdress2
            // 
            this.modificationAdress2.AutoSize = true;
            this.modificationAdress2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.modificationAdress2.ForeColor = System.Drawing.Color.Black;
            this.modificationAdress2.Location = new System.Drawing.Point(275, 108);
            this.modificationAdress2.Name = "modificationAdress2";
            this.modificationAdress2.Padding = new System.Windows.Forms.Padding(3);
            this.modificationAdress2.Size = new System.Drawing.Size(102, 19);
            this.modificationAdress2.TabIndex = 17;
            this.modificationAdress2.Text = "Adresse courrielle :";
            // 
            // modificationAdress
            // 
            this.modificationAdress.BackColor = System.Drawing.Color.White;
            this.modificationAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modificationAdress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modificationAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modificationAdress.Location = new System.Drawing.Point(383, 108);
            this.modificationAdress.Name = "modificationAdress";
            this.modificationAdress.Size = new System.Drawing.Size(100, 13);
            this.modificationAdress.TabIndex = 16;
            this.modificationAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.textBox1.Location = new System.Drawing.Point(0, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(784, 19);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Modification compte client";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modificationValidation
            // 
            this.modificationValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificationValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationValidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(146)))), ((int)(((byte)(46)))));
            this.modificationValidation.Location = new System.Drawing.Point(342, 260);
            this.modificationValidation.Name = "modificationValidation";
            this.modificationValidation.Size = new System.Drawing.Size(86, 29);
            this.modificationValidation.TabIndex = 23;
            this.modificationValidation.Text = "Modifier";
            this.modificationValidation.UseVisualStyleBackColor = true;
            this.modificationValidation.Click += new System.EventHandler(this.modificationValidation_Click);
            // 
            // accepteRecevoirNouvautes
            // 
            this.accepteRecevoirNouvautes.AutoSize = true;
            this.accepteRecevoirNouvautes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accepteRecevoirNouvautes.Location = new System.Drawing.Point(278, 224);
            this.accepteRecevoirNouvautes.Name = "accepteRecevoirNouvautes";
            this.accepteRecevoirNouvautes.Size = new System.Drawing.Size(201, 17);
            this.accepteRecevoirNouvautes.TabIndex = 40;
            this.accepteRecevoirNouvautes.Text = "J\'accepte de recevoir des nouvautés";
            this.accepteRecevoirNouvautes.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "< Retour à mon compte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // messageValidation
            // 
            this.messageValidation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.messageValidation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageValidation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.messageValidation.Location = new System.Drawing.Point(10, 311);
            this.messageValidation.Name = "messageValidation";
            this.messageValidation.Size = new System.Drawing.Size(760, 13);
            this.messageValidation.TabIndex = 42;
            this.messageValidation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormModificationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.messageValidation);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.accepteRecevoirNouvautes);
            this.Controls.Add(this.modificationValidation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.modificationPassword2);
            this.Controls.Add(this.modificationPassword);
            this.Controls.Add(this.modificationUsername2);
            this.Controls.Add(this.modificationUsername);
            this.Controls.Add(this.modificationAdress2);
            this.Controls.Add(this.modificationAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormModificationCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification du compte utilisateur";
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
        private System.Windows.Forms.Label modificationPassword2;
        private System.Windows.Forms.TextBox modificationPassword;
        private System.Windows.Forms.Label modificationUsername2;
        private System.Windows.Forms.TextBox modificationUsername;
        private System.Windows.Forms.Label modificationAdress2;
        private System.Windows.Forms.TextBox modificationAdress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button modificationValidation;
        private System.Windows.Forms.CheckBox accepteRecevoirNouvautes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox messageValidation;
    }
}