
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class Cat�gorie : DomainObject
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
       