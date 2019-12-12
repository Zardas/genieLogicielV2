
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface IApprovisionnementMapper
 {
	Approvisionnement Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Approvisionnement pApprovisionnement);
  int Update(Approvisionnement pApprovisionnement);
  int Delete(Approvisionnement pApprovisionnement);
  
	
 }
}	
  