
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class PaiementCarteCr�dit : Paiement
 {
		private string mNum�roCarteCr�dit;
		public string Num�roCarteCr�dit {
    			get {
      				return  mNum�roCarteCr�dit;
    			}
    			set {
      				mNum�roCarteCr�dit=value;
    			}
		    }
		private string mTitulaire;
		public string Titulaire {
    			get {
      				return  mTitulaire;
    			}
    			set {
      				mTitulaire=value;
    			}
		    }
		private string mDateExpiration;
		public string DateExpiration {
    			get {
      				return  mDateExpiration;
    			}
    			set {
      				mDateExpiration=value;
    			}
		    }
	
 
 }
}	
       