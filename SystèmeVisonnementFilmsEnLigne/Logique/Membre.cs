
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
	public Membre validerInfoConnexion(ref string identifiant, ref string motDePasse)
    
    {
    // to add your business logic code of the operation

    return null;
    }
  
 
 }
}	
       