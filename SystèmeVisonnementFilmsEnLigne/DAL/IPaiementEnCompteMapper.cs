
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface IPaiementEnCompteMapper
 {
	PaiementEnCompte Find(Guid ID);
  DataTable FindAll();
   
	int Insert(PaiementEnCompte pPaiementEnCompte);
  int Update(PaiementEnCompte pPaiementEnCompte);
  int Delete(PaiementEnCompte pPaiementEnCompte);
  
    DataTable FindAllPourUnCompte(Guid pCompteId);
      
	
 }
}	
  