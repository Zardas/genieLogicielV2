
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class Film : DomainObject
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
		private string mTitre;
		public string Titre {
    			get {
      				return  mTitre;
    			}
    			set {
      				mTitre=value;
    			}
		    }
		private int mDur�e;
		public int Dur�e {
    			get {
      				return  mDur�e;
    			}
    			set {
      				mDur�e=value;
    			}
		    }
		private float mCo�tVisionnement;
		public float Co�tVisionnement {
    			get {
      				return  mCo�tVisionnement;
    			}
    			set {
      				mCo�tVisionnement=value;
    			}
		    }
		private float mCo�tAchat;
		public float Co�tAchat {
    			get {
      				return  mCo�tAchat;
    			}
    			set {
      				mCo�tAchat=value;
    			}
		    }
		private string mSynopsis;
		public string Synopsis {
    			get {
      				return  mSynopsis;
    			}
    			set {
      				mSynopsis=value;
    			}
		    }
		private string mMotsCl�s;
		public string MotsCl�s {
    			get {
      				return  mMotsCl�s;
    			}
    			set {
      				mMotsCl�s=value;
    			}
		    }
		private string mR�alisateurs;
		public string R�alisateurs {
    			get {
      				return  mR�alisateurs;
    			}
    			set {
      				mR�alisateurs=value;
    			}
		    }
		private string mProducteurs;
		public string Producteurs {
    			get {
      				return  mProducteurs;
    			}
    			set {
      				mProducteurs=value;
    			}
		    }
		private string mMaisonsProduction;
		public string MaisonsProduction {
    			get {
      				return  mMaisonsProduction;
    			}
    			set {
      				mMaisonsProduction=value;
    			}
		    }
		private string mStatut;
		public string Statut {
    			get {
      				return  mStatut;
    			}
    			set {
      				mStatut=value;
    			}
		    }
		private string mActeurs;
		public string Acteurs {
    			get {
      				return  mActeurs;
    			}
    			set {
      				mActeurs=value;
    			}
		    }
		private bool mEstApprouv�;
		public bool EstApprouv� {
    			get {
      				return  mEstApprouv�;
    			}
    			set {
      				mEstApprouv�=value;
    			}
		    }
	
		private Guid? mIDR�alisateur;
		public Guid? IDR�alisateur
        	{
            		get { return mIDR�alisateur; }
            		set { mIDR�alisateur = value; }
        	}
	public Film[] rechercher(string crit�res)
    
    {
    // to add your business logic code of the operation

    return null;
    }
  public int visionner()
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  
 
 }
}	
       