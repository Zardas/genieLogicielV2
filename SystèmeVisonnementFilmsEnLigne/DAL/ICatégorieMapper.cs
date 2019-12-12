
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface ICatégorieMapper
 {
	Catégorie Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Catégorie pCatégorie);
  int Update(Catégorie pCatégorie);
  int Delete(Catégorie pCatégorie);
  
	
 }
}	
  