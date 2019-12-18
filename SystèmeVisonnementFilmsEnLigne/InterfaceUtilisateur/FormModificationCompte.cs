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
    public partial class FormModificationCompte : Form
    {

        Membre membre;

        public FormModificationCompte(Membre membre)
        {
            this.membre = membre;
            
            InitializeComponent();

            modificationAdress.Text = membre.AdresseCourriel;
            modificationUsername.Text = membre.NomUsager;
            modificationPassword.Text = membre.MotDePasse;
            accepteRecevoirNouvautes.Checked = membre.AAcceptéRecevoirNuveautés;
        }

        //Retour au compte membre
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Modification validation
        private void modificationValidation_Click(object sender, EventArgs e)
        {
            List<string[]> updateParameters = new List<string[]>();

            string[] toAdd = { "adressecourriel", modificationAdress.Text };
            updateParameters.Add(toAdd); //Pour une raison obscur, l'IDE refuse que je mette directement l'array avec les {} dans le Add
            toAdd = new string[] { "nomusager", modificationUsername.Text };
            updateParameters.Add(toAdd);
            toAdd = new string[] { "motdepasse", modificationPassword.Text };
            updateParameters.Add(toAdd);

            this.membre.updateMembre(updateParameters);
            messageValidation.Text = "Le compte a été modifié";
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

        private void menuCompteClient_Click(object sender, EventArgs e)
        {
            this.Close(); //Si on est là, c'est qu'il y a un FormCompteClient derrière
        }

        private void menuDeconnexion_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }
    }
}
