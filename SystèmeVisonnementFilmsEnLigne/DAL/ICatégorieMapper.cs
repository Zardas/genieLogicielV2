
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface ICat�gorieMapper
 {
	Cat�gorie Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Cat�gorie pCat�gorie);
  int Update(Cat�gorie pCat�gorie);
  int Delete(Cat�gorie pCat�gorie);
  
	
 }
}	
  