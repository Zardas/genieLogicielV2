

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
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
            
            
        lFilm.Num�ro = (string)pDataRow["Num�ro"];
      
        lFilm.Titre = (string)pDataRow["Titre"];
      
        lFilm.Dur�e = (int)pDataRow["Dur�e"];
      
        lFilm.Co�tVisionnement = (float)pDataRow["Co�tVisionnement"];
      
        lFilm.Co�tAchat = (float)pDataRow["Co�tAchat"];
      
        lFilm.Synopsis = (string)pDataRow["Synopsis"];
      
        lFilm.MotsCl�s = (string)pDataRow["MotsCl�s"];
      
        lFilm.R�alisateurs = (string)pDataRow["R�alisateurs"];
      
        lFilm.Producteurs = (string)pDataRow["Producteurs"];
      
        lFilm.MaisonsProduction = (string)pDataRow["MaisonsProduction"];
      
        lFilm.Statut = (string)pDataRow["Statut"];
      
        lFilm.Acteurs = (string)pDataRow["Acteurs"];
      
        lFilm.EstApprouv� = (bool)pDataRow["EstApprouv�"];
      
      
            lFilm.ID = new Guid(pDataRow["ID"].ToString());

	          
        if (pDataRow["IDR�alisateur"].GetType() != typeof(System.DBNull))
        lFilm.IDR�alisateur = new Guid(pDataRow["IDR�alisateur"].ToString());
    
      
            return lFilm;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblFilm]", "");

        }


  
        //--------------------------------------------------------------------
        public DataTable FindAllPourUnR�alisateur(Guid pR�alisateurId)
        {
        return DataBase.Select("SELECT * FROM tblFilm WHERE IDR�alisateur='" + pR�alisateurId.ToString() + "'");
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
          
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Num�ro) + "'";
      
    pCols[liCpt] = "Titre";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Titre) + "'";
      
    pCols[liCpt] = "Dur�e";
    
        pValues[liCpt++] = "'" + pFilm.Dur�e.ToString() + "'";
      
    pCols[liCpt] = "Co�tVisionnement";
    
        pValues[liCpt++] = "'" + pFilm.Co�tVisionnement.ToString() + "'";
      
    pCols[liCpt] = "Co�tAchat";
    
        pValues[liCpt++] = "'" + pFilm.Co�tAchat.ToString() + "'";
      
    pCols[liCpt] = "Synopsis";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Synopsis) + "'";
      
    pCols[liCpt] = "MotsCl�s";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.MotsCl�s) + "'";
      
    pCols[liCpt] = "R�alisateurs";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.R�alisateurs) + "'";
      
    pCols[liCpt] = "Producteurs";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Producteurs) + "'";
      
    pCols[liCpt] = "MaisonsProduction";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.MaisonsProduction) + "'";
      
    pCols[liCpt] = "Statut";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Statut) + "'";
      
    pCols[liCpt] = "Acteurs";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pFilm.Acteurs) + "'";
      
    pCols[liCpt] = "EstApprouv�";
    
        pValues[liCpt++] = "'" + pFilm.EstApprouv�.ToString() + "'";
      
      if (!Util.isNULL(pFilm.IDR�alisateur))
      {
        pCols[liCpt] = "IDR�alisateur";
        pValues[liCpt++] = "'" + pFilm.IDR�alisateur.ToString() + "'";
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

