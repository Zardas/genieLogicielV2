using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.InterfaceUtilisateur
{
    public partial class FormCompteMembre : Form
    {
        public Membre membre;

        public FormCompteMembre(Membre membre)
        {
            this.membre = membre;

            InitializeComponent();

            this.username.Text = membre.NomUsager;

        }

        private void menuAccueil_Click(object sender, EventArgs e)
        {
            FormIndexConnecte formIndexConnecte = new FormIndexConnecte(this.membre);
            formIndexConnecte.ShowDialog();
            this.Close();
        }


        //Ajout film
        private void button2_Click(object sender, EventArgs e)
        {
            FormAjouterFilm formAjouterFilm = new FormAjouterFilm(this.membre);
            formAjouterFilm.ShowDialog();
        }

        //Modification compte
        private void button3_Click(object sender, EventArgs e)
        {
            FormModificationCompte formModificationCompte = new FormModificationCompte(this.membre);
            formModificationCompte.ShowDialog();
        }

        private void menuRechercherUnFilm_Click(object sender, EventArgs e)
        {
            FormCatalogueConnecte formCatalogueConnecte = new FormCatalogueConnecte(this.membre);
            formCatalogueConnecte.ShowDialog();
            this.Close();
        }

        private void menuTitre_Click(object sender, EventArgs e)
        {
            FormIndexConnecte formIndexConnecte = new FormIndexConnecte(this.membre);
            formIndexConnecte.ShowDialog();
            this.Close();
        }

        //Compte client
        private void menuInscripion_Click(object sender, EventArgs e)
        {
            FormCompteMembre formCompteMembre = new FormCompteMembre(this.membre);
            formCompteMembre.ShowDialog();
            this.Close();
        }

        //Deconnexion
        private void menuConnexion_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }
    }
}
