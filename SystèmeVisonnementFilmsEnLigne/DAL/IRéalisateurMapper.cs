
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IR�alisateurMapper
 {
	R�alisateur Find(Guid ID);
  DataTable FindAll();
   
	int Insert(R�alisateur pR�alisateur);
  int Update(R�alisateur pR�alisateur);
  int Delete(R�alisateur pR�alisateur);
  
	
 }
}	
  