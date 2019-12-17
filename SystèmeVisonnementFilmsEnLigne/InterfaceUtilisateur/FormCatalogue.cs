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


    public partial class FormCatalogue : Form
    {
        private int LocationX = 360;

        public FormCatalogue()
        {
            InitializeComponent();
            rechercheResultat.Text = "Nom";
        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void menuRechercherUnFilm_Click(object sender, EventArgs e)
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

        private void menuAccueil_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
            this.Close();
        }

        private void menuInscripion_Click(object sender, EventArgs e)
        {
            FormInscription formInscription = new FormInscription();
            formInscription.ShowDialog();
            this.Close();
        }

        //Recherche
        private void search_Click(object sender, EventArgs e)
        {
            List<string[]> param = new List<string[]>();

            if (rechercheFilmTitre.Text != "")
            {
                string[] toAdd = { "titre", rechercheFilmTitre.Text };
                param.Add(toAdd);
            }
            if (rechercheFilmDuree.Value != 0)
            {
                string[] toAdd = { "durée", rechercheFilmDuree.Value.ToString() };
                param.Add(toAdd);
            }
            if (rechercheFilmMotsCles.Text != "")
            {
                string[] toAdd = { "motsClès", rechercheFilmMotsCles.Text };
                param.Add(toAdd);
            }
            if (rechercheFilmRealisateurs.Text != "")
            {
                string[] toAdd = { "réalisateurs", rechercheFilmRealisateurs.Text };
                param.Add(toAdd);
            }
            if (rechercheFilmActeurs.Text != "")
            {
                string[] toAdd = { "acteurs", rechercheFilmActeurs.Text };
                param.Add(toAdd);
            }
            if (rechercheFilmMaisonDeProduction.Text != "")
            {
                string[] toAdd = { "maisonsProduction", rechercheFilmMaisonDeProduction.Text };
                param.Add(toAdd);
            }
            if (rechercheFilmProducteurs.Text != "")
            {
                string[] toAdd = { "producteurs", rechercheFilmProducteurs.Text };
                param.Add(toAdd);
            }


            rechercheResultat.Text = "Nombre de résultats = " + Film.rechercher(param).Count;

            List<Film> resultats = Film.rechercher(param);
            int LocationY = 90;
            //On créer tout les boutons en fonction du résultat de la requête
            foreach(Film film in resultats)
            {
                Button btn = new Button();
                btn.Location = new Point(this.LocationX, LocationY);
                LocationY += 40;
                btn.Text = film.Titre;
                btn.Name = film.ID.ToString(); //En mettant l'id du film comme nom pour le boutton, cela permet de mémoriser cette valeur pour ouvrir la page de détails du film par la suite
                btn.Click += new EventHandler(openMovieDetails);
                this.Controls.Add(btn);

            }
        }

        //Ouvrir la page des détails du film
        private void openMovieDetails(object sender, EventArgs e)
        {

        }
    }
}
