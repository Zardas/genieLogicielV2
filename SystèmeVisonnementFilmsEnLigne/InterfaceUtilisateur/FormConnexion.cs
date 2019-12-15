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
                //On change le texte des labels en rouge
                inscriptionAdress.ForeColor = Color.FromArgb(240, 10, 10);
                inscriptionPassword.ForeColor = Color.FromArgb(240, 10, 10);
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
    }
}
