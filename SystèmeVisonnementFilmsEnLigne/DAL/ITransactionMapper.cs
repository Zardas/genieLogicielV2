
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface ITransactionMapper
 {
	Transaction Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Transaction pTransaction);
  int Update(Transaction pTransaction);
  int Delete(Transaction pTransaction);
  
    DataTable FindAllPourUnSession(Guid pSessionId);
      
	
 }
}	
  