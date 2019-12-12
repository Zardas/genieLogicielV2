
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class Compte : DomainObject
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
		private float mSolde;
		public float Solde {
    			get {
      				return  mSolde;
    			}
    			set {
      				mSolde=value;
    			}
		    }
		private string mNum�roCarteCr�dit;
		public string Num�roCarteCr�dit {
    			get {
      				return  mNum�roCarteCr�dit;
    			}
    			set {
      				mNum�roCarteCr�dit=value;
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
       