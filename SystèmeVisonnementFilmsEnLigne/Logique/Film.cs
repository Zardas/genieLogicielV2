
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syst�meVisonnementFilmsEnLigne.DAL;

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

        public Film()
        {

        }

        //Override
        public Film(string titre, int duree, float coutAchat, float coutVisionnement, string motsCles, string realisateur, string producteurs, string maisonDeProduction, string acteurs, string synopsis)
        {
            this.Titre = titre;
            this.Dur�e = duree;
            this.Co�tAchat = coutAchat;
            this.Co�tVisionnement = coutVisionnement;
            this.MotsCl�s = motsCles;
            this.mR�alisateurs = realisateur;
            this.Producteurs = producteurs;
            this.MaisonsProduction = maisonDeProduction;
            this.Synopsis = synopsis;
            this.Acteurs = acteurs;
 
        }

        //Ajout d'un membre dans la base (retourne le succ�s ou non de l'ajout)
        public static int ajoutFilm(string titre, int duree, float coutAchat, float coutVisionnement, string motsCles, string realisateur, string producteurs, string maisonDeProduction, string acteurs, string synopsis)
        {
            //Verification de la validit� des informations rentr�es (je consid�re que les co�ts peuvent �tre de 0)
            if (titre != ""
                && duree != 0
                && motsCles != ""
                && realisateur != ""
                && producteurs != ""
                && maisonDeProduction != ""
                && acteurs != ""
                && synopsis != "")
            {
                DataMapperFactory dataMapper = DataMapperFactory.GetDataMapperFactory();
                IFilmMapper filmMapper = dataMapper.GetFilmMapper();

                Film nouveauFilm = new Film(titre, duree, coutAchat, coutVisionnement, motsCles, realisateur, producteurs, maisonDeProduction, acteurs, synopsis);

                int res = filmMapper.Insert(nouveauFilm);

                return res;
            }

            return -1;
        }
    }
}	
       