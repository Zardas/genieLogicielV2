
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class BandeAnnonce : DomainObject
 {
		private int mDur�e;
		public int Dur�e {
    			get {
      				return  mDur�e;
    			}
    			set {
      				mDur�e=value;
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
       