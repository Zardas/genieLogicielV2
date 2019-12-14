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

        private void inscriptionValidation_Click(object sender, EventArgs e)
        {
            // Test de la connexion
            FormCompteClient formCompteClient = new FormCompteClient(new Logique.Client());
            formCompteClient.ShowDialog();
            this.Close();
        }
    }
}
