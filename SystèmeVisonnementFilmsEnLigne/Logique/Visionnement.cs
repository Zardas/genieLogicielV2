
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meVisonnementFilmsEnLigne.Logique
{
public class Visionnement : Transaction
 {
	
		private Guid mIDPaiement;
		public Guid IDPaiement
        	{
            		get { return mIDPaiement; }
            		set { mIDPaiement = value; }
        	}
	public Visionnement[] consulterHistoriquePourUnR�alisateur(ref R�alisateur r�alisateur)
    
    {
    // to add your business logic code of the operation

    return null;
    }
  
 
 }
}	
       