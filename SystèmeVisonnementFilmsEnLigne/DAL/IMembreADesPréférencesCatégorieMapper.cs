
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface IMembreADesPréférencesCatégorieMapper
 {
	MembreADesPréférencesCatégorie Find(Guid ID);
        DataTable FindAll();
	      int Insert(MembreADesPréférencesCatégorie pMembreADesPréférencesCatégorie);
        int Update(MembreADesPréférencesCatégorie pMembreADesPréférencesCatégorie);
        int Delete(MembreADesPréférencesCatégorie pMembreADesPréférencesCatégorie);
 }
}	
       