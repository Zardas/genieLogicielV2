
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IRemboursementMapper
 {
	Remboursement Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Remboursement pRemboursement);
  int Update(Remboursement pRemboursement);
  int Delete(Remboursement pRemboursement);
  
	
 }
}	
  