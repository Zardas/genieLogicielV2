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
    public partial class FormCatalogueConnecte : Form
    {
        private int LocationX = 360;

        public FormCatalogueConnecte()
        {
            InitializeComponent();
            rechercheResultat.Text = "Aucune recherche";
        }

        private void search_Click(object sender, EventArgs e)
        {
            List<string[]> param = new List<string[]>();

            if (rechercheFilmTitre.Text != "")
            {
                string[] toAdd = { "titre", rechercheFilmTitre.Text };
                param.Add(toAdd);
            }
            //...

            rechercheResultat.Text = "Nombre de résultats = " + Film.rechercher(param).Count;

            List<Film> resultats = Film.rechercher(param);
            int LocationY = 90;
            //On créer tout les boutons en fonction du résultat de la requête
            foreach (Film film in resultats)
            {
                Button btn = new Button();
                btn.Location = new Point(this.LocationX, LocationY);
                LocationY += 40;
                btn.Text = film.Titre;
                btn.Size = new Size(300, 30);

                //On passe direct le film au bouton afin d'éviter d'avoir à refaire un appel à la bdd
                btn.Click += (sender2, e2) => openMovieDetails(sender2, e2, film);
                this.Controls.Add(btn);

            }
        }

        //Ouvrir la page des détails du film
        private void openMovieDetails(object sender, EventArgs e, Film film)
        {
            FormDetailFilm formDetailFilm = new FormDetailFilm(film);
            formDetailFilm.ShowDialog();
        }
    }
}
