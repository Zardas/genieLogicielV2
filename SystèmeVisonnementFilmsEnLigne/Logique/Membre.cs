
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class Membre : Visiteur
 {
		private string mNum�ro;
		public string Num�ro {
    			get {
      				return  mNum�ro;
    			}
    			set {
      				mNum�ro=value;
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
		private string mPr�nom;
		public string Pr�nom {
    			get {
      				return  mPr�nom;
    			}
    			set {
      				mPr�nom=value;
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
		private string mT�l�phone;
		public string T�l�phone {
    			get {
      				return  mT�l�phone;
    			}
    			set {
      				mT�l�phone=value;
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
		private bool mAAccept�RecevoirNuveaut�s;
		public bool AAccept�RecevoirNuveaut�s {
    			get {
      				return  mAAccept�RecevoirNuveaut�s;
    			}
    			set {
      				mAAccept�RecevoirNuveaut�s=value;
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
	
    private Dictionary<Guid, Cat�gorie> lsCat�gorie = new Dictionary<Guid, Cat�gorie>();
		public Dictionary<Guid, Cat�gorie> ListCat�gorie
        	{
            		get { return lsCat�gorie; }
            		set { lsCat�gorie = value; }
        	}
	public Membre validerInfoConnexion(ref string identifiant, ref string motDePasse)
    
    {
    // to add your business logic code of the operation

    return null;
    }
  
 
 }
}	
       