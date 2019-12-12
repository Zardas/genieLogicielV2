
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface IRéalisateurMapper
 {
	Réalisateur Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Réalisateur pRéalisateur);
  int Update(Réalisateur pRéalisateur);
  int Delete(Réalisateur pRéalisateur);
  
	
 }
}	
  