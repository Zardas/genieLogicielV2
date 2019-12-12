
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;
namespace Syst�meVisonnementFilmsEnLigne.DAL
{
public interface IBandeAnnonceMapper
 {
	BandeAnnonce Find(Guid ID);
  DataTable FindAll();
   
	int Insert(BandeAnnonce pBandeAnnonce);
  int Update(BandeAnnonce pBandeAnnonce);
  int Delete(BandeAnnonce pBandeAnnonce);
  
    DataTable FindAllPourUnFilm(Guid pFilmId);
      
	
 }
}	
  