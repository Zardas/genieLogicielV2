

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class FilmMapper : AbstractMapper, IFilmMapper
    {

        public FilmMapper()
        {
        }

        //--------------------------------------------------------------------
        public Film Find(Guid ID)
        {
            Film lFilm = (Film)AbstractFind(ID);

            if (Util.isNULL(lFilm))
            {
                DataRow row = DataBase.SelectID(ID, "[tblFilm]");
                if (Util.isNULL(row))
                    return null;
                lFilm = this.FillFields(row);
                LoadedMap.Add(lFilm.ID, lFilm); 
            }
            return lFilm;
        }


        public DataTable FindWithConditions(string[] fields, string[] values)
        {
            string where = "WHERE";
            if(fields.Length == values.Length)
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    where = where + " " + fields[i] + " = " + values[i];
                }
            }

            return DataBase.Select("SELECT * FROM tblFilm WHERE " + where);
        }

        //--------------------------------------------------------------------
        private Film FillFields(DataRow pDataRow)
        {
            Film lFilm = new Film();
            
            
        lFilm.Numéro = (string)pDataRow["Numéro"];
      
        lFilm.Titre = (string)pDataRow["Titre"];
      
        lFilm.Durée = (int)pDataRow["Durée"];
      
        lFilm.CoûtVisionnement = (float)pDataRow["CoûtVisionnement"];
      
        lFilm.CoûtAchat = (float)pDataRow["CoûtAchat"];
      
        lFilm.Synopsis = (string)pDataRow["Synopsis"];
      
        lFilm.MotsClès = (string)pDataRow["MotsClès"];
      
        lFilm.Réalisateurs = (string)pDataRow["Réalisateurs"];
      
        lFilm.Producteurs = (string)pDataRow["Producteurs"];
      
        lFilm.MaisonsProduction = (string)pDataRow["MaisonsProduction"];
      
        lFilm.Statut = (string)pDataRow["Statut"];
      
        lFilm.Acteurs = (string)pDataRow["Acteurs"];
      
        lFilm.EstApprouvé = (bool)pDataRow["EstApprouvé"];
      
      
            lFilm.ID = new Guid(pDataRow["ID"].ToString());

	          
        if (pDataRow["IDRéalisateur"].GetType() != typeof(System.DBNull))
        lFilm.IDRéalisateur = new Guid(pDataRow["IDRéalisateur"].ToString());
    
      
            return lFilm;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblFilm]", "");

        }


  
        //--------------------------------------------------------------------
        public DataTable FindAllPourUnRéalisateur(Guid pRéalisateurId)
        {
        return DataBase.Select("SELECT * FROM tblFilm WHERE IDRéalisateur='" + pRéalisateurId.ToString() + "'");
        }
      
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Film pFilm, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 13 + 1;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pFilm.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Numéro) + "'";
      
    pCols[liCpt] = "Titre";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Titre) + "'";
      
    pCols[liCpt] = "Durée";
    
        pValues[liCpt++] = "'" + pFilm.Durée.ToString() + "'";
      
    pCols[liCpt] = "CoûtVisionnement";
    
        pValues[liCpt++] = "'" + pFilm.CoûtVisionnement.ToString() + "'";
      
    pCols[liCpt] = "CoûtAchat";
    
        pValues[liCpt++] = "'" + pFilm.CoûtAchat.ToString() + "'";
      
    pCols[liCpt] = "Synopsis";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Synopsis) + "'";
      
    pCols[liCpt] = "MotsClès";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.MotsClès) + "'";
      
    pCols[liCpt] = "Réalisateurs";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Réalisateurs) + "'";
      
    pCols[liCpt] = "Producteurs";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Producteurs) + "'";
      
    pCols[liCpt] = "MaisonsProduction";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.MaisonsProduction) + "'";
      
    pCols[liCpt] = "Statut";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Statut) + "'";
      
    pCols[liCpt] = "Acteurs";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Acteurs) + "'";
      
    pCols[liCpt] = "EstApprouvé";
    
        pValues[liCpt++] = "'" + pFilm.EstApprouvé.ToString() + "'";
      
      if (!Util.isNULL(pFilm.IDRéalisateur))
      {
        pCols[liCpt] = "IDRéalisateur";
        pValues[liCpt++] = "'" + pFilm.IDRéalisateur.ToString() + "'";
      }
    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Film pFilm)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pFilm.ID, "[tblFilm]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Film pFilm)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pFilm, true);
            return DataBase.Insert("[tblFilm]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Film pFilm)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pFilm, false);
            return DataBase.UpdateID("tblFilm", lsCols, lsValues, pFilm.ID);
        }

    }
}

