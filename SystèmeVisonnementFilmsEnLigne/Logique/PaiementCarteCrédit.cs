
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class PaiementCarteCrédit : Paiement
 {
		private string mNuméroCarteCrédit;
		public string NuméroCarteCrédit {
    			get {
      				return  mNuméroCarteCrédit;
    			}
    			set {
      				mNuméroCarteCrédit=value;
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
       