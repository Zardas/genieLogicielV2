
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface IPaiementCarteCréditMapper
 {
	PaiementCarteCrédit Find(Guid ID);
  DataTable FindAll();
   
	int Insert(PaiementCarteCrédit pPaiementCarteCrédit);
  int Update(PaiementCarteCrédit pPaiementCarteCrédit);
  int Delete(PaiementCarteCrédit pPaiementCarteCrédit);
  
	
 }
}	
  