using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SystèmeVisonnementFilmsEnLigne
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var fileContent = File.ReadAllText("../../ScriptSQL.sql");
            var sqlqueries = fileContent.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

            SqlConnection connexion = new SqlConnection("Data Source=(local);Initial Catalog=SystèmeVisonnementFilmsEnLigneDB;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("query", connexion);

            connexion.Open();
            foreach (var query in sqlqueries)
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            connexion.Close();
    

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InterfaceUtilisateur.FormIndex());
        }
    }
}
