
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface IVisiteurMapper
 {
	Visiteur Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Visiteur pVisiteur);
  int Update(Visiteur pVisiteur);
  int Delete(Visiteur pVisiteur);
  
	
 }
}	
  