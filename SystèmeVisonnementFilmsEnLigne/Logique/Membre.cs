
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
      				return  mNuméro;
    			}
    			set {
      				mNuméro=value;
    			}
		    }
		private string mNom;
		public string Nom {
    			get {
      				return  mNom;
    			}
    			set {
      				mNom=value;
    			}
		    }
		private string mPrénom;
		public string Prénom {
    			get {
      				return  mPrénom;
    			}
    			set {
      				mPrénom=value;
    			}
		    }
		private string mAdresse;
		public string Adresse {
    			get {
      				return  mAdresse;
    			}
    			set {
      				mAdresse=value;
    			}
		    }
		private string mTéléphone;
		public string Téléphone {
    			get {
      				return  mTéléphone;
    			}
    			set {
      				mTéléphone=value;
    			}
		    }
		private string mAdresseCourriel;
		public string AdresseCourriel {
    			get {
      				return  mAdresseCourriel;
    			}
    			set {
      				mAdresseCourriel=value;
    			}
		    }
		private bool mAAcceptéRecevoirNuveautés;
		public bool AAcceptéRecevoirNuveautés {
    			get {
      				return  mAAcceptéRecevoirNuveautés;
    			}
    			set {
      				mAAcceptéRecevoirNuveautés=value;
    			}
		    }
		private string mNomUsager;
		public string NomUsager {
    			get {
      				return  mNomUsager;
    			}
    			set {
      				mNomUsager=value;
    			}
		    }
		private string mMotDePasse;
		public string MotDePasse {
    			get {
      				return  mMotDePasse;
    			}
    			set {
      				mMotDePasse=value;
    			}
		    }
	
    private Dictionary<Guid, Catégorie> lsCatégorie = new Dictionary<Guid, Catégorie>();
		public Dictionary<Guid, Catégorie> ListCatégorie
        	{
            		get { return lsCatégorie; }
            		set { lsCatégorie = value; }
        	}
	public static Membre validerInfoConnexion(ref string identifiant, ref string motDePasse) {
        
            
        DataMapperFactory dataMapper = DataMapperFactory.GetDataMapperFactory();
        ICompteMapper compteMapper = dataMapper.GetCompteMapper();

        DataTable tableMembre = compteMapper.FindAll();
            
        foreach(DataRow row in tableMembre.Rows)
        {
            //Dans mon système, l'identifiant peut-être l'username ou l'adresse mail
            if ((row["nomUsager"].ToString() == identifiant || row["adresse"].ToString() == identifiant) && row["motDePasse"].ToString() == motDePasse)
            {
                    Membre member = new Membre();
                    member.Numéro = row["numéro"].ToString();
                    member.Nom = row["nom"].ToString();
                    member.Prénom = row["prénom"].ToString();
                    member.Adresse = row["adresse"].ToString();
                    member.Téléphone = row["téléphone"].ToString();
                    member.AdresseCourriel = row["adresseCourriel"].ToString();
                    if(row["aAcceptéRecevoirNuveautés"].ToString() == "1")
                    {
                        member.AAcceptéRecevoirNuveautés = false;
                    } else
                    {
                        member.AAcceptéRecevoirNuveautés = true;
                    }
                    member.NomUsager = row["nomUsager"].ToString();
                    member.MotDePasse = row["motDePasse"].ToString();
                    return member;    
            }
        }
        return null;
    }
  
 
 }
}	
       