
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class Compte : DomainObject
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
		private float mSolde;
		public float Solde {
    			get {
      				return  mSolde;
    			}
    			set {
      				mSolde=value;
    			}
		    }
		private string mNuméroCarteCrédit;
		public string NuméroCarteCrédit {
    			get {
      				return  mNuméroCarteCrédit;
    			}
    			set {
      				mNuméroCarteCrédit=value;
    			}
		    }
		private string mTitualire;
		public string Titualire {
    			get {
      				return  mTitualire;
    			}
    			set {
      				mTitualire=value;
    			}
		    }
		private DateTime mDateExpiration;
		public DateTime DateExpiration {
    			get {
      				return  mDateExpiration;
    			}
    			set {
      				mDateExpiration=value;
    			}
		    }
	
		private Guid mIDMembre;
		public Guid IDMembre
        	{
            		get { return mIDMembre; }
            		set { mIDMembre = value; }
        	}
	
 
 }
}	
       