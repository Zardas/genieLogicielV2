
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class Distributeur : DomainObject
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
		private string mAdresseSiteWeb;
		public string AdresseSiteWeb {
    			get {
      				return  mAdresseSiteWeb;
    			}
    			set {
      				mAdresseSiteWeb=value;
    			}
		    }
	
 
 }
}	
       