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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();

            Film film = new Film();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Connexion
        private void inscriptionValidation_Click(object sender, EventArgs e)
        {
            // Test de la connexion
            string identifiant = inscriptionAdress.Text.ToString();
            string mdp = inscriptionPassword.Text.ToString();

            Membre membre = Membre.validerInfoConnexion(ref identifiant, ref mdp);

            if(membre != null)
            {
                FormCompteMembre formCompteClient = new FormCompteMembre(membre);
                formCompteClient.ShowDialog();
                this.Close();
            } else
            {
                Color errorColor = Color.FromArgb(240, 10, 10);
                Color normalColor = Color.FromArgb(255, 255, 255);
                //On change le texte des labels en rouge
                if (!(inscriptionAdress.Text.Contains("@") && inscriptionAdress.Text.Contains(".")))
                {
                    inscriptionAdress.BackColor = errorColor;
                } else
                {
                    inscriptionAdress.BackColor = normalColor;
                }
                if (inscriptionPassword.Text == "")
                {
                    inscriptionPassword.BackColor = errorColor;
                } else
                {
                    inscriptionPassword.BackColor = normalColor;
                }
            }
            
        }

        private void inscriptionAdress_Click(object sender, EventArgs e)
        {

        }

        //Passer à l'inscription
        private void button1_Click(object sender, EventArgs e)
        {
            FormInscription formInscription = new FormInscription();
            formInscription.ShowDialog();
            this.Close();

        }

        private void menuTitre_Click(object sender, EventArgs e)
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

        private void menuConnexion_Click(object sender, EventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.ShowDialog();
            this.Close();
        }
    }
}
