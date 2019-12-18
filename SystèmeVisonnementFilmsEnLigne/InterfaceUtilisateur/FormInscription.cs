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
    public partial class FormInscription : Form
    {
        public FormInscription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }

        private void menuAccueil_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }

        private void menuRechercherUnFilm_Click(object sender, EventArgs e)
        {
            FormCatalogue formCatalogue = new FormCatalogue();
            formCatalogue.ShowDialog();
            this.Close();
        }

        private void menuInscripion_Click(object sender, EventArgs e)
        {
            FormInscription formInscription = new FormInscription();
            formInscription.ShowDialog();
            this.Close();
        }

        private void inscriptionValidation_Click(object sender, EventArgs e)
        {
            //Inscription
            string mail = inscriptionAdress.Text.ToString();
            string username = usernameInscription.Text.ToString();
            string password = inscriptionPassword.Text.ToString();
            string nom = inscriptionName.Text.ToString();
            string prenom = inscriptionPrenom.Text.ToString();
            string telephone = inscriptionTelephone.Text.ToString();
            string adresse = inscriptionAdressIRL.Text.ToString();
            bool aAccepterRecevoirNouvautes = accepteRecevoirNouvautes.Checked;

            //Vérifie la validité des paramètres rentrés, et ajoute le membre dans la BDD
            Membre nouveauMembre = Membre.ajoutMembre(mail, username, password, nom, prenom, telephone, adresse, aAccepterRecevoirNouvautes);

            if(nouveauMembre != null) //L'inscription a été validée coté Logic
            {
                // Test de l'inscription
                FormCompteMembre formCompteClient = new FormCompteMembre(nouveauMembre);
                formCompteClient.ShowDialog();
                this.Close();
            } else
            {
                Color errorColor = Color.FromArgb(240, 10, 10);
                inscriptionAdress.ForeColor = errorColor;
                usernameInscription.ForeColor = errorColor;
                inscriptionPassword.ForeColor = errorColor;
                inscriptionName.ForeColor = errorColor;
                inscriptionPrenom.ForeColor = errorColor;
                inscriptionTelephone.ForeColor = errorColor;
                inscriptionAdressIRL.ForeColor = errorColor;
            }
            
        }

        //Passage à la connexion
        private void button1_Click(object sender, EventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.ShowDialog();
            this.Close();
        }

        private void menuConnexion_Click(object sender, EventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.ShowDialog();
            this.Close();
        }
    }
}
