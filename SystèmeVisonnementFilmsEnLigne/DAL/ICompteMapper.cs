
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface ICompteMapper
 {
	Compte Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Compte pCompte);
  int Update(Compte pCompte);
  int Delete(Compte pCompte);
  
	
 }
}	
  