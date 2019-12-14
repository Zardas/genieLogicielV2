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
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCatalogue formCatalogue = new FormCatalogue();
            formCatalogue.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }

        private void accueilToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void menuInscription_Click(object sender, EventArgs e)
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
