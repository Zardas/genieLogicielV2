
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IPaiementCarteCr�ditMapper
 {
	PaiementCarteCr�dit Find(Guid ID);
  DataTable FindAll();
   
	int Insert(PaiementCarteCr�dit pPaiementCarteCr�dit);
  int Update(PaiementCarteCr�dit pPaiementCarteCr�dit);
  int Delete(PaiementCarteCr�dit pPaiementCarteCr�dit);
  
	
 }
}	
  