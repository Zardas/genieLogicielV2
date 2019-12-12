
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class BandeAnnonce : DomainObject
 {
		private int mDurée;
		public int Durée {
    			get {
      				return  mDurée;
    			}
    			set {
      				mDurée=value;
    			}
		    }
		private string mBande;
		public string Bande {
    			get {
      				return  mBande;
    			}
    			set {
      				mBande=value;
    			}
		    }
	
		private Guid mIDFilm;
		public Guid IDFilm
        	{
            		get { return mIDFilm; }
            		set { mIDFilm = value; }
        	}
	
 
 }
}	
       