
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IVisionnementMapper
 {
	Visionnement Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Visionnement pVisionnement);
  int Update(Visionnement pVisionnement);
  int Delete(Visionnement pVisionnement);
  
	
 }
}	
  