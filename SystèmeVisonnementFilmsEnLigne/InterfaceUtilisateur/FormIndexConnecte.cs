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
    public partial class FormIndexConnecte : Form
    {
        Membre membre;
        public FormIndexConnecte(Membre membre)
        {
            this.membre = membre;
            InitializeComponent();
        }

        private void buttonAccessCatalogue_Click(object sender, EventArgs e)
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

        private void menuAccueil_Click(object sender, EventArgs e)
        {
            FormIndexConnecte formIndexConnecte = new FormIndexConnecte(this.membre);
            formIndexConnecte.ShowDialog();
            this.Close();
        }

        private void menuRechercherUnFilm_Click(object sender, EventArgs e)
        {
            FormCatalogueConnecte formCatalogueConnecte = new FormCatalogueConnecte(this.membre);
            formCatalogueConnecte.ShowDialog();
            this.Close();
        }

        private void menuMonCompte_Click(object sender, EventArgs e)
        {
            FormCompteMembre formCompteMembre = new FormCompteMembre(this.membre);
            formCompteMembre.ShowDialog();
            this.Close();
        }

        private void menuDéconnexion_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }
    }
}
