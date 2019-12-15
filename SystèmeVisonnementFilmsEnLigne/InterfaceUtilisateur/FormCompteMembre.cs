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
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }


        //Ajout film
        private void button2_Click(object sender, EventArgs e)
        {
            FormAjouterFilm formAjouterFilm = new FormAjouterFilm();
            formAjouterFilm.ShowDialog();
        }
    }
}
