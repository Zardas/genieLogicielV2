
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IPaiementMapper
 {
	Paiement Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Paiement pPaiement);
  int Update(Paiement pPaiement);
  int Delete(Paiement pPaiement);
  
	
 }
}	
  