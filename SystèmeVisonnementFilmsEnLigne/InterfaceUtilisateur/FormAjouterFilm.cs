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
        Membre membre;

        public FormAjouterFilm(Membre membre)
        {
            this.membre = membre;
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
                Color normalColor = Color.FromArgb(255, 255, 255);

                if (ajoutTitre.Text == "")
                {
                    ajoutTitre.BackColor = errorColor;
                } else
                {
                    ajoutTitre.BackColor = normalColor;
                }

                if (ajoutDuree.Value == 0)
                {
                    ajoutDuree.BackColor = errorColor;
                } else
                {
                    ajoutDuree.BackColor = normalColor;
                }

                if (ajoutCoutAchat.Value == 0)
                {
                    ajoutCoutAchat.BackColor = errorColor;
                } else
                {
                    ajoutCoutAchat.BackColor = normalColor;
                }

                if (ajoutCoutVisionnement.Value == 0)
                {
                    ajoutCoutVisionnement.BackColor = errorColor;
                } else
                {
                    ajoutCoutVisionnement.BackColor = normalColor;
                }

                if (ajoutMotCles.Text == "")
                {
                    ajoutMotCles.BackColor = errorColor;
                } else
                {
                    ajoutMotCles.BackColor = normalColor;
                }

                if (ajoutRealisateur.Text == "")
                {
                    ajoutRealisateur.BackColor = errorColor;
                } else
                {
                    ajoutRealisateur.BackColor = normalColor;
                }

                if (ajoutProducteur.Text == "")
                {
                    ajoutProducteur.BackColor = errorColor;
                } else
                {
                    ajoutProducteur.BackColor = normalColor;
                }

                if (ajoutMaisonDeProduction.Text == "")
                {
                    ajoutMaisonDeProduction.BackColor = errorColor;
                } else
                {
                    ajoutMaisonDeProduction.BackColor = normalColor;
                }

                if (ajoutActeur.Text == "")
                {
                    ajoutActeur.BackColor = errorColor;
                } else
                {
                    ajoutActeur.BackColor = normalColor;
                }

                if (ajoutSynopsis.Text == "")
                {
                    ajoutSynopsis.BackColor = errorColor;
                } else
                {
                    ajoutSynopsis.BackColor = normalColor;
                }
            }
     
        }

        //Retour au menu
        private void label1_Click(object sender, EventArgs e)
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
            FormCatalogueConnecte formCatalogue = new FormCatalogueConnecte(this.membre);
            formCatalogue.ShowDialog();
            this.Close();
        }

        private void menuInscripion_Click(object sender, EventArgs e)
        {
            this.Close(); //Si on est à ce niveau, c'est qu'on a le form de CompteMembre derrière
        }

        private void menuDéconnexion_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }
    }
}
