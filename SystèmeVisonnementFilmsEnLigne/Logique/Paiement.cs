
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class Paiement : DomainObject
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
		private DateTime mDate;
		public DateTime Date {
    			get {
      				return  mDate;
    			}
    			set {
      				mDate=value;
    			}
		    }
		private float mMontant;
		public float Montant {
    			get {
      				return  mMontant;
    			}
    			set {
      				mMontant=value;
    			}
		    }
	
 
 }
}	
       