
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface ISessionMapper
 {
	Session Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Session pSession);
  int Update(Session pSession);
  int Delete(Session pSession);
  
    DataTable FindAllPourUnVisiteur(Guid pVisiteurId);
      
	
 }
}	
  