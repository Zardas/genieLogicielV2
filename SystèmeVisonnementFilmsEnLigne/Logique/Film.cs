
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class Film : DomainObject
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
		private string mTitre;
		public string Titre {
    			get {
      				return  mTitre;
    			}
    			set {
      				mTitre=value;
    			}
		    }
		private int mDurée;
		public int Durée {
    			get {
      				return  mDurée;
    			}
    			set {
      				mDurée=value;
    			}
		    }
		private float mCoûtVisionnement;
		public float CoûtVisionnement {
    			get {
      				return  mCoûtVisionnement;
    			}
    			set {
      				mCoûtVisionnement=value;
    			}
		    }
		private float mCoûtAchat;
		public float CoûtAchat {
    			get {
      				return  mCoûtAchat;
    			}
    			set {
      				mCoûtAchat=value;
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
		private string mMotsClès;
		public string MotsClès {
    			get {
      				return  mMotsClès;
    			}
    			set {
      				mMotsClès=value;
    			}
		    }
		private string mRéalisateurs;
		public string Réalisateurs {
    			get {
      				return  mRéalisateurs;
    			}
    			set {
      				mRéalisateurs=value;
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
		private bool mEstApprouvé;
		public bool EstApprouvé {
    			get {
      				return  mEstApprouvé;
    			}
    			set {
      				mEstApprouvé=value;
    			}
		    }
	
		private Guid? mIDRéalisateur;
		public Guid? IDRéalisateur
        	{
            		get { return mIDRéalisateur; }
            		set { mIDRéalisateur = value; }
        	}
	public Film[] rechercher(string critères)
    
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
       