
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IDistributeurMapper
 {
	Distributeur Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Distributeur pDistributeur);
  int Update(Distributeur pDistributeur);
  int Delete(Distributeur pDistributeur);
  
	
 }
}	
  