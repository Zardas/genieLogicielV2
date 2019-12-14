using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Server;

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
            //FileInfo file = new FileInfo("../../ScriptSQL.sql");
            //string script = file.OpenText().ReadToEnd();

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

            /*SqlConnection connexion = new SqlConnection("Data Source=(local);Initial Catalog=master;Integrated Security=SSPI");

            FileInfo file = new FileInfo("../../ScriptSQL.sql");
            string script = file.OpenText().ReadToEnd();
            string sqlBatch = string.Empty;
            SqlCommand cmd = new SqlCommand(string.Empty, connexion);
            connexion.Open();
            script += "\nGO";   // make sure last batch is executed.
            try
            {
                foreach (string line in script.Split(new string[2] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.ToUpperInvariant().Trim() == "GO")
                    {
                        cmd.CommandText = sqlBatch;
                        cmd.ExecuteNonQuery();
                        sqlBatch = string.Empty;
                    }
                    else
                    {
                        sqlBatch += line + "\n";
                    }
                }
            }
            finally
            {
                connexion.Close();
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InterfaceUtilisateur.FormIndex());

           
        }
    }
}
