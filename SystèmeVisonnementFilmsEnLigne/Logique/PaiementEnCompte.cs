
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.Logique
{
public class PaiementEnCompte : Paiement
 {
	
		private Guid? mIDCompte;
		public Guid? IDCompte
        	{
            		get { return mIDCompte; }
            		set { mIDCompte = value; }
        	}
	
 
 }
}	
       