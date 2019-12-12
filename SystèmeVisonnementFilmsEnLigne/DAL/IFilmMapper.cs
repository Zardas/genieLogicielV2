
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IFilmMapper
 {
	Film Find(Guid ID);
  DataTable FindAll();
   
	int Insert(Film pFilm);
  int Update(Film pFilm);
  int Delete(Film pFilm);
  
    DataTable FindAllPourUnR�alisateur(Guid pR�alisateurId);
      
	
 }
}	
  