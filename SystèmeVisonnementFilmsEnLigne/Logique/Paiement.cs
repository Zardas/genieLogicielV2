
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class Paiement : DomainObject
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
       