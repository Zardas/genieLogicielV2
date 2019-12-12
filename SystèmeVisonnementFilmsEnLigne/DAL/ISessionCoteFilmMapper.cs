
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
public interface ISessionCoteFilmMapper
 {
	SessionCoteFilm Find(Guid ID);
        DataTable FindAll();
	      int Insert(SessionCoteFilm pSessionCoteFilm);
        int Update(SessionCoteFilm pSessionCoteFilm);
        int Delete(SessionCoteFilm pSessionCoteFilm);
 }
}	
       