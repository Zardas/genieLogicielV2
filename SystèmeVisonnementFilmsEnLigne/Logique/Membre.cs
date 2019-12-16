
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SystèmeVisonnementFilmsEnLigne.DAL;

namespace SystèmeVisonnementFilmsEnLigne.Logique
{
    public class Membre : Visiteur
    {
        private string mNuméro;
        public string Numéro {
            get {
                return mNuméro;
            }
            set {
                mNuméro = value;
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
        private string mPrénom;
        public string Prénom {
            get {
                return mPrénom;
            }
            set {
                mPrénom = value;
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
        private string mTéléphone;
        public string Téléphone {
            get {
                return mTéléphone;
            }
            set {
                mTéléphone = value;
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
        private bool mAAcceptéRecevoirNuveautés;
        public bool AAcceptéRecevoirNuveautés {
            get {
                return mAAcceptéRecevoirNuveautés;
            }
            set {
                mAAcceptéRecevoirNuveautés = value;
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

        private Dictionary<Guid, Catégorie> lsCatégorie = new Dictionary<Guid, Catégorie>();
        public Dictionary<Guid, Catégorie> ListCatégorie
        {
            get { return lsCatégorie; }
            set { lsCatégorie = value; }
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
            this.Prénom = prenom;
            this.Téléphone = telephone;
            this.AdresseCourriel = mail;
            this.AAcceptéRecevoirNuveautés = aAccepterRecevoirNouvautes;
            this.NomUsager = username;
            this.MotDePasse = password;
        }

        //Override dans la cas où on a aAccepterRecevoirNouvautes sous la forme d'une string
        public Membre(string numero, string nom, string prenom, string adresse, string telephone, string mail, string aAccepterRecevoirNouvautes, string username, string password)
        {
            this.Numéro = numero;
            this.Nom = nom;
            this.Prénom = prenom;
            this.Téléphone = telephone;
            this.AdresseCourriel = mail;
            if (aAccepterRecevoirNouvautes == "1")
            {
                this.AAcceptéRecevoirNuveautés = true;
            } else
            {
                this.AAcceptéRecevoirNuveautés = false;
            }
            this.NomUsager = username;
            this.MotDePasse = password;
        }


        //Validation des infos de connexion
        public static Membre validerInfoConnexion(ref string identifiant, ref string motDePasse) {

            IMembreMapper membreMapper = getMapper();

            //Le find mis à disposition par le DAL demande le GUID du membre, que nous n'avons pas à ce stade
            DataTable tableMembre = membreMapper.FindAll();

            foreach (DataRow row in tableMembre.Rows)
            {
                //Dans mon système, l'identifiant peut-être l'username ou l'adresse mail
                if ((row["nomUsager"].ToString() == identifiant || row["adresse"].ToString() == identifiant) && row["motDePasse"].ToString() == motDePasse)
                {

                    return new Membre(
                        row["numéro"].ToString(),
                        row["nom"].ToString(),
                        row["prénom"].ToString(),
                        row["adresse"].ToString(),
                        row["téléphone"].ToString(),
                        row["adresseCourriel"].ToString(),
                        row["aAcceptéRecevoirNuveautés"].ToString(),
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
            //Verification de la validité des informations rentrées
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




        //On passe en paramètre une liste de tableau. Chaque élément de la liste est un tableau à deux éléments : le champ à update et sa valeur
        public void updateMembre(List<string[]> toUpdate)
        {
            IMembreMapper membreMapper = getMapper();

            //On test pour chaque champ s'il doit être modifié et on le modifie dans ce cas
            foreach (string[] row in toUpdate)
            {
                if (row[0].ToLower() == "numéro") { this.Numéro = row[1]; }
                if (row[0].ToLower() == "nom") { this.Nom = row[1]; }
                if (row[0].ToLower() == "prénom") { this.Prénom = row[1]; }
                if (row[0].ToLower() == "téléphone") { this.Téléphone = row[1]; }
                if (row[0].ToLower() == "adressecourriel") { this.AdresseCourriel = row[1]; }
                if (row[0].ToLower() == "nomusager") { this.NomUsager = row[1]; }
                if (row[0].ToLower() == "motdepasse") { this.MotDePasse = row[1]; }
                if (row[0].ToLower() == "aaccepterrecevoirnouvautes")
                {
                    if (row[1] == "true")
                    {
                        this.AAcceptéRecevoirNuveautés = true;
                    }
                    else
                    {
                        this.AAcceptéRecevoirNuveautés = false;
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
       