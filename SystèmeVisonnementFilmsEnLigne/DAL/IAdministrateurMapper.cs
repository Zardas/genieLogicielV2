
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface IAdministrateurMapper
 {
	Administrateur Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Administrateur pAdministrateur);
  int Update(Administrateur pAdministrateur);
  int Delete(Administrateur pAdministrateur);
  
	
 }
}	
  