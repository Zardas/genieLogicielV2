
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystèmeVisonnementFilmsEnLigne.DAL;

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

        public Film()
        {

        }

        //Override
        public Film(string titre, int duree, float coutAchat, float coutVisionnement, string motsCles, string realisateur, string producteurs, string maisonDeProduction, string acteurs, string synopsis)
        {
            this.Titre = titre;
            this.Durée = duree;
            this.CoûtAchat = coutAchat;
            this.CoûtVisionnement = coutVisionnement;
            this.MotsClès = motsCles;
            this.mRéalisateurs = realisateur;
            this.Producteurs = producteurs;
            this.MaisonsProduction = maisonDeProduction;
            this.Synopsis = synopsis;
            this.Acteurs = acteurs;
 
        }

        //Ajout d'un membre dans la base (retourne le succès ou non de l'ajout)
        public static int ajoutFilm(string titre, int duree, float coutAchat, float coutVisionnement, string motsCles, string realisateur, string producteurs, string maisonDeProduction, string acteurs, string synopsis)
        {
            //Verification de la validité des informations rentrées (je considère que les coûts peuvent être de 0)
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
       