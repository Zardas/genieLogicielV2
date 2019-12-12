
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class SessionCoteFilm : DomainObject
 {		private Guid mIDSession;
		public Guid   IDSession {
    			get {
      				return mIDSession;
    			}
    			set {
      				mIDSession=value;
    			}
		}
        	private Guid mIDFilm;
		public Guid   IDFilm {
    			get {
      				return mIDFilm;
    			}
    			set {
      				mIDFilm=value;
    			}
		}
		private int mCote;
		public int Cote {
    			get {
      				return  mCote;
    			}
    			set {
      				mCote=value;
    			}
		    }
		private string mCommentaire;
		public string Commentaire {
    			get {
      				return  mCommentaire;
    			}
    			set {
      				mCommentaire=value;
    			}
		    }
	

 }
}	
       