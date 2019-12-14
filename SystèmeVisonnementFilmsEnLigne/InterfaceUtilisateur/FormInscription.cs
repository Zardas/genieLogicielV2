using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Test de l'inscription
            FormCompteMembre formCompteClient = new FormCompteMembre(new Logique.Client());
            formCompteClient.ShowDialog();
            this.Close();
        }
    }
}
