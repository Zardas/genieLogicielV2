
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class Catégorie : DomainObject
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
		private string mDescription;
		public string Description {
    			get {
      				return  mDescription;
    			}
    			set {
      				mDescription=value;
    			}
		    }
	
 
 }
}	
       