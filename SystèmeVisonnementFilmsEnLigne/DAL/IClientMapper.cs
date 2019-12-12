
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface IClientMapper
 {
	Client Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Client pClient);
  int Update(Client pClient);
  int Delete(Client pClient);
  
	
 }
}	
  