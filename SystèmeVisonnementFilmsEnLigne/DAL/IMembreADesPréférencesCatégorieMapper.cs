
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IMembreADesPr�f�rencesCat�gorieMapper
 {
	MembreADesPr�f�rencesCat�gorie Find(Guid ID);
        DataTable FindAll();
	      int Insert(MembreADesPr�f�rencesCat�gorie pMembreADesPr�f�rencesCat�gorie);
        int Update(MembreADesPr�f�rencesCat�gorie pMembreADesPr�f�rencesCat�gorie);
        int Delete(MembreADesPr�f�rencesCat�gorie pMembreADesPr�f�rencesCat�gorie);
 }
}	
       