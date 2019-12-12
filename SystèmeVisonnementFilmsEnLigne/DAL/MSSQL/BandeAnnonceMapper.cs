

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class BandeAnnonceMapper : AbstractMapper, IBandeAnnonceMapper
    {

        public BandeAnnonceMapper()
        {
        }

        //--------------------------------------------------------------------
        public BandeAnnonce Find(Guid ID)
        {
            BandeAnnonce lBandeAnnonce = (BandeAnnonce)AbstractFind(ID);

            if (Util.isNULL(lBandeAnnonce))
            {
                DataRow row = DataBase.SelectID(ID, "[tblBandeAnnonce]");
                if (Util.isNULL(row))
                    return null;
                lBandeAnnonce = this.FillFields(row);
                LoadedMap.Add(lBandeAnnonce.ID, lBandeAnnonce); 
            }
            return lBandeAnnonce;
        }


        //--------------------------------------------------------------------
        private BandeAnnonce FillFields(DataRow pDataRow)
        {
            BandeAnnonce lBandeAnnonce = new BandeAnnonce();
            
            
        lBandeAnnonce.Durée = (int)pDataRow["Durée"];
      
        lBandeAnnonce.Bande = (string)pDataRow["Bande"];
      
      
            lBandeAnnonce.ID = new Guid(pDataRow["ID"].ToString());

	          
        if (pDataRow["IDFilm"].GetType() != typeof(System.DBNull))
        lBandeAnnonce.IDFilm = new Guid(pDataRow["IDFilm"].ToString());
    
      
            return lBandeAnnonce;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblBandeAnnonce]", "");
        }


  
        //--------------------------------------------------------------------
        public DataTable FindAllPourUnFilm(Guid pFilmId)
        {
        return DataBase.Select("SELECT * FROM tblBandeAnnonce WHERE IDFilm='" + pFilmId.ToString() + "'");
        }
      
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, BandeAnnonce pBandeAnnonce, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 2 + 1;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pBandeAnnonce.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Durée";
    
        pValues[liCpt++] = "'" + pBandeAnnonce.Durée.ToString() + "'";
      
    pCols[liCpt] = "Bande";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pBandeAnnonce.Bande) + "'";
      
      if (!Util.isNULL(pBandeAnnonce.IDFilm))
      {
        pCols[liCpt] = "IDFilm";
        pValues[liCpt++] = "'" + pBandeAnnonce.IDFilm.ToString() + "'";
      }
    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(BandeAnnonce pBandeAnnonce)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pBandeAnnonce.ID, "[tblBandeAnnonce]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(BandeAnnonce pBandeAnnonce)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pBandeAnnonce, true);
            return DataBase.Insert("[tblBandeAnnonce]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(BandeAnnonce pBandeAnnonce)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pBandeAnnonce, false);
            return DataBase.UpdateID("tblBandeAnnonce", lsCols, lsValues, pBandeAnnonce.ID);
        }

    }
}

