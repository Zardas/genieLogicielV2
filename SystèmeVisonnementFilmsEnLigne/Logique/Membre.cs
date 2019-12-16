
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Syst�meVisonnementFilmsEnLigne.DAL;

namespace Syst�meVisonnementFilmsEnLigne.Logique
{
    public class Membre : Visiteur
    {
        private string mNum�ro;
        public string Num�ro {
            get {
                return mNum�ro;
            }
            set {
                mNum�ro = value;
            }
        }
        private string mNom;
        public string Nom {
            get {
                return mNom;
            }
            set {
                mNom = value;
            }
        }
        private string mPr�nom;
        public string Pr�nom {
            get {
                return mPr�nom;
            }
            set {
                mPr�nom = value;
            }
        }
        private string mAdresse;
        public string Adresse {
            get {
                return mAdresse;
            }
            set {
                mAdresse = value;
            }
        }
        private string mT�l�phone;
        public string T�l�phone {
            get {
                return mT�l�phone;
            }
            set {
                mT�l�phone = value;
            }
        }
        private string mAdresseCourriel;
        public string AdresseCourriel {
            get {
                return mAdresseCourriel;
            }
            set {
                mAdresseCourriel = value;
            }
        }
        private bool mAAccept�RecevoirNuveaut�s;
        public bool AAccept�RecevoirNuveaut�s {
            get {
                return mAAccept�RecevoirNuveaut�s;
            }
            set {
                mAAccept�RecevoirNuveaut�s = value;
            }
        }
        private string mNomUsager;
        public string NomUsager {
            get {
                return mNomUsager;
            }
            set {
                mNomUsager = value;
            }
        }
        private string mMotDePasse;
        public string MotDePasse {
            get {
                return mMotDePasse;
            }
            set {
                mMotDePasse = value;
            }
        }

        private Dictionary<Guid, Cat�gorie> lsCat�gorie = new Dictionary<Guid, Cat�gorie>();
        public Dictionary<Guid, Cat�gorie> ListCat�gorie
        {
            get { return lsCat�gorie; }
            set { lsCat�gorie = value; }
        }


        public static IMembreMapper getMapper()
        {
            DataMapperFactory dataMapper = DataMapperFactory.GetDataMapperFactory();
            return dataMapper.GetMembreMapper();
        }

        public Membre()
        {


        }
        //Override
        public Membre(string nom, string prenom, string adresse, string telephone, string mail, bool aAccepterRecevoirNouvautes, string username, string password)
        {
            this.Nom = nom;
            this.Pr�nom = prenom;
            this.T�l�phone = telephone;
            this.AdresseCourriel = mail;
            this.AAccept�RecevoirNuveaut�s = aAccepterRecevoirNouvautes;
            this.NomUsager = username;
            this.MotDePasse = password;
        }

        //Override dans la cas o� on a aAccepterRecevoirNouvautes sous la forme d'une string
        public Membre(string numero, string nom, string prenom, string adresse, string telephone, string mail, string aAccepterRecevoirNouvautes, string username, string password)
        {
            this.Num�ro = numero;
            this.Nom = nom;
            this.Pr�nom = prenom;
            this.T�l�phone = telephone;
            this.AdresseCourriel = mail;
            if (aAccepterRecevoirNouvautes == "1")
            {
                this.AAccept�RecevoirNuveaut�s = true;
            } else
            {
                this.AAccept�RecevoirNuveaut�s = false;
            }
            this.NomUsager = username;
            this.MotDePasse = password;
        }


        //Validation des infos de connexion
        public static Membre validerInfoConnexion(ref string identifiant, ref string motDePasse) {

            IMembreMapper membreMapper = getMapper();

            //Le find mis � disposition par le DAL demande le GUID du membre, que nous n'avons pas � ce stade
            DataTable tableMembre = membreMapper.FindAll();

            foreach (DataRow row in tableMembre.Rows)
            {
                //Dans mon syst�me, l'identifiant peut-�tre l'username ou l'adresse mail
                if ((row["nomUsager"].ToString() == identifiant || row["adresse"].ToString() == identifiant) && row["motDePasse"].ToString() == motDePasse)
                {

                    return new Membre(
                        row["num�ro"].ToString(),
                        row["nom"].ToString(),
                        row["pr�nom"].ToString(),
                        row["adresse"].ToString(),
                        row["t�l�phone"].ToString(),
                        row["adresseCourriel"].ToString(),
                        row["aAccept�RecevoirNuveaut�s"].ToString(),
                        row["nomUsager"].ToString(),
                        row["motDePasse"].ToString()
                        );
                }
            }
            return null;
        }


        //Ajout d'un membre dans la base
        public static Membre ajoutMembre(string mail, string username, string password, string nom, string prenom, string telephone, string adresse, bool accepteRecevoirNouvautes)
        {
            //Verification de la validit� des informations rentr�es
            if (mail.Contains("@") && mail.Contains(".")
                && username != ""
                && password != ""
                && nom != ""
                && prenom != ""
                && telephone != ""
                && adresse != "")
            {
                IMembreMapper membreMapper = getMapper();

                Membre nouveauMembre = new Membre(nom, prenom, adresse, telephone, mail, accepteRecevoirNouvautes, username, password);

                membreMapper.Insert(nouveauMembre);

                return nouveauMembre;
            }

            return null;
        }




        //On passe en param�tre une liste de tableau. Chaque �l�ment de la liste est un tableau � deux �l�ments : le champ � update et sa valeur
        public void updateMembre(List<string[]> toUpdate)
        {
            IMembreMapper membreMapper = getMapper();

            //On test pour chaque champ s'il doit �tre modifi� et on le modifie dans ce cas
            foreach (string[] row in toUpdate)
            {
                if (row[0].ToLower() == "num�ro") { this.Num�ro = row[1]; }
                if (row[0].ToLower() == "nom") { this.Nom = row[1]; }
                if (row[0].ToLower() == "pr�nom") { this.Pr�nom = row[1]; }
                if (row[0].ToLower() == "t�l�phone") { this.T�l�phone = row[1]; }
                if (row[0].ToLower() == "adressecourriel") { this.AdresseCourriel = row[1]; }
                if (row[0].ToLower() == "nomusager") { this.NomUsager = row[1]; }
                if (row[0].ToLower() == "motdepasse") { this.MotDePasse = row[1]; }
                if (row[0].ToLower() == "aaccepterrecevoirnouvautes")
                {
                    if (row[1] == "true")
                    {
                        this.AAccept�RecevoirNuveaut�s = true;
                    }
                    else
                    {
                        this.AAccept�RecevoirNuveaut�s = false;
                    }
                }
            }

            membreMapper.Update(this);
        }


        /*public static DataTable testTable()
        {
            DataMapperFactory dataMapper = DataMapperFactory.GetDataMapperFactory();
            IMembreMapper membreMapper = dataMapper.GetMembreMapper();

            DataTable tableMembre = membreMapper.FindAll();

            return tableMembre;
        }*/
 }
}	
       