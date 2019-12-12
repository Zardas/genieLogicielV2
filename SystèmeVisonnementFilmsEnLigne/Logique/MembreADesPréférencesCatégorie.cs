
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class MembreADesPréférencesCatégorie : DomainObject
 {		private Guid mIDMembre;
		public Guid   IDMembre {
    			get {
      				return mIDMembre;
    			}
    			set {
      				mIDMembre=value;
    			}
		}
        	private Guid mIDCatégorie;
		public Guid   IDCatégorie {
    			get {
      				return mIDCatégorie;
    			}
    			set {
      				mIDCatégorie=value;
    			}
		}

 }
}	
       