
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class MembreADesPr�f�rencesCat�gorie : DomainObject
 {		private Guid mIDMembre;
		public Guid   IDMembre {
    			get {
      				return mIDMembre;
    			}
    			set {
      				mIDMembre=value;
    			}
		}
        	private Guid mIDCat�gorie;
		public Guid   IDCat�gorie {
    			get {
      				return mIDCat�gorie;
    			}
    			set {
      				mIDCat�gorie=value;
    			}
		}

 }
}	
       