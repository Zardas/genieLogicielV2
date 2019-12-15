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
    public partial class FormAjouterFilm : Form
    {
        public FormAjouterFilm()
        {
            InitializeComponent();
        }

        private void ajoutValidation_Click(object sender, EventArgs e)
        {
            //Ajout du film
            string titre = ajoutTitre.Text.ToString();
            int duree = (int)ajoutDuree.Value;
            float coutAchat = (float)ajoutCoutAchat.Value;
            float coutVisionnement = (float)ajoutCoutVisionnement.Value;
            string motsCles = ajoutMotCles.Text.ToString();
            string realisateur = ajoutRealisateur.Text.ToString();
            string prodcteurs = ajoutProducteur.Text.ToString();
            string maisonDeProduction = ajoutMaisonDeProduction.Text.ToString();
            string acteurs = ajoutActeur.Text.ToString();
            string synopsis = ajoutSynopsis.Text.ToString();

            //Vérifie la validité des paramètres rentrés, et ajoute le film dans la BDD
            if(Film.ajoutFilm(titre, duree, coutAchat, coutVisionnement, motsCles, realisateur, prodcteurs, maisonDeProduction, acteurs, synopsis) != -1)
            {
                ajoutValide.Text = "Le film a été ajouté";
            } else
            {
                Color errorColor = Color.FromArgb(240, 10, 10);
                ajoutTitre.ForeColor = errorColor;
                ajoutDuree.ForeColor = errorColor;
                ajoutCoutAchat.ForeColor = errorColor;
                ajoutCoutVisionnement.ForeColor = errorColor;
                ajoutMotCles.ForeColor = errorColor;
                ajoutRealisateur.ForeColor = errorColor;
                ajoutProducteur.ForeColor = errorColor;
                ajoutMaisonDeProduction.ForeColor = errorColor;
                ajoutActeur.ForeColor = errorColor;
                ajoutSynopsis.ForeColor = errorColor;
            }
     
        }
    }
}
