
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class Session : DomainObject
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
		private DateTime mDateConnexion;
		public DateTime DateConnexion {
    			get {
      				return  mDateConnexion;
    			}
    			set {
      				mDateConnexion=value;
    			}
		    }
		private DateTime mDateD�connexion;
		public DateTime DateD�connexion {
    			get {
      				return  mDateD�connexion;
    			}
    			set {
      				mDateD�connexion=value;
    			}
		    }
	
		private Guid mIDVisiteur;
		public Guid IDVisiteur
        	{
            		get { return mIDVisiteur; }
            		set { mIDVisiteur = value; }
        	}
	
    private Dictionary<Guid, Film> lsFilm = new Dictionary<Guid, Film>();
		public Dictionary<Guid, Film> ListFilm
        	{
            		get { return lsFilm; }
            		set { lsFilm = value; }
        	}
	public int visualiserDataStreaming(ref string dataStream)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public int visionnerFilm(Film film)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public int validerInfoConnexion(string identifiant, string motDePasse)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public Film s�lectionnerFilm()
    
    {
    // to add your business logic code of the operation

    return null;
    }
  public Film[] rechercherFilms(ref string crit�res)
    
    {
    // to add your business logic code of the operation

    return null;
    }
  public void demanderFormulaireRechercheFilms()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void demanderFormOuvertureSession()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void demanderFormInscriptionR�alisareur()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void demanderFormInscriptioneClient()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void demanderFormInscriptionAdmin()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public int consulterHistoriqueVisonnements(R�alisateur r�alisateur)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public int consulterHistoriqueTransactions(Client client)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public int confirmerInscriptionR�alisateur(R�alisateur r�alisateur)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public int confirmerInscriptionClient(Client client)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public int confirmerInscriptionAdmin(Administrateur admin)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public int afficherVisionnements(Visionnement[] visionnements)
    
    {
    // to add your business logic code of the operation

    return 0;
    }
  public void afficherTransactions(Transaction transactions)
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherMessage�checConnexion()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherMessageConnexionR�ussie()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherFormulaireRechercheFilms()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherFormOuvertureSession()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherFormInscriptionR�alisateur()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherFormInscriptionAdmin()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherFormInscriptioeClient()
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherFilms(Film[] films)
    
    {
    // to add your business logic code of the operation

    return ;
    }
  public void afficherDescriptionFilm(ref Film film)
    
    {
    // to add your business logic code of the operation

    return ;
    }
  
 
 }
}	
       