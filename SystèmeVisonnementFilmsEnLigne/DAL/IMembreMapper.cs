
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IMembreMapper
 {
	Membre Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Membre pMembre);
  int Update(Membre pMembre);
  int Delete(Membre pMembre);
  
	
 }
}	
  