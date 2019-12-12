
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class Visionnement : Transaction
 {
	
		private Guid mIDPaiement;
		public Guid IDPaiement
        	{
            		get { return mIDPaiement; }
            		set { mIDPaiement = value; }
        	}
	public Visionnement[] consulterHistoriquePourUnRéalisateur(ref Réalisateur réalisateur)
    
    {
    // to add your business logic code of the operation

    return null;
    }
  
 
 }
}	
       