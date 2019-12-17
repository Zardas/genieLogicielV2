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
    public partial class FormDetailFilm : Form
    {
        private Film film;

        public FormDetailFilm(Film film)
        {
            this.film = film;

            detailsTitre.Text = film.Titre;
            detailsSynopsis.Text = film.Synopsis;
            detailsRealisateurs.Text = film.Réalisateurs;
            detailsActeurs.Text = film.Acteurs;
            detailsProducteurs.Text = film.Producteurs;
            detailsMaisonDeProduction.Text = film.MaisonsProduction;
            //Calcul de la duree
            detailsDuree.Text = Math.Floor((decimal)(film.Durée / 60)).ToString() + "h" + (film.Durée%60).ToString();

            InitializeComponent();
        }
    }
}
