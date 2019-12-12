

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class R�alisateurMapper : AbstractMapper, IR�alisateurMapper
    {

        public R�alisateurMapper()
        {
        }

        //--------------------------------------------------------------------
        public R�alisateur Find(Guid ID)
        {
            R�alisateur lR�alisateur = (R�alisateur)AbstractFind(ID);

            if (Util.isNULL(lR�alisateur))
            {
                DataRow row = DataBase.SelectID(ID, "[tblR�alisateur]");
                if (Util.isNULL(row))
                    return null;
                lR�alisateur = this.FillFields(row);
                LoadedMap.Add(lR�alisateur.ID, lR�alisateur); 
            }
            return lR�alisateur;
        }


        //--------------------------------------------------------------------
        private R�alisateur FillFields(DataRow pDataRow)
        {
            R�alisateur lR�alisateur = new R�alisateur();
            
            
        lR�alisateur.Num�ro = (string)pDataRow["Num�ro"];
      
        lR�alisateur.Nom = (string)pDataRow["Nom"];
      
        lR�alisateur.Pr�nom = (string)pDataRow["Pr�nom"];
      
        lR�alisateur.Adresse = (string)pDataRow["Adresse"];
      
        lR�alisateur.T�l�phone = (string)pDataRow["T�l�phone"];
      
        lR�alisateur.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lR�alisateur.AAccept�RecevoirNuveaut�s = (bool)pDataRow["AAccept�RecevoirNuveaut�s"];
      
        lR�alisateur.NomUsager = (string)pDataRow["NomUsager"];
      
        lR�alisateur.MotDePasse = (string)pDataRow["MotDePasse"];
      
      
            lR�alisateur.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lR�alisateur;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblR�alisateur]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, R�alisateur pR�alisateur, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 9 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pR�alisateur.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pR�alisateur.Num�ro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pR�alisateur.Nom) + "'";
      
    pCols[liCpt] = "Pr�nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pR�alisateur.Pr�nom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pR�alisateur.Adresse) + "'";
      
    pCols[liCpt] = "T�l�phone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pR�alisateur.T�l�phone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pR�alisateur.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AAccept�RecevoirNuveaut�s";
    
        pValues[liCpt++] = "'" + pR�alisateur.AAccept�RecevoirNuveaut�s.ToString() + "'";
      
    pCols[liCpt] = "NomUsager";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pR�alisateur.NomUsager) + "'";
      
    pCols[liCpt] = "MotDePasse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pR�alisateur.MotDePasse) + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(R�alisateur pR�alisateur)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pR�alisateur.ID, "[tblR�alisateur]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
      liTemp = DataBase.Delete("DELETE FROM tblFilm WHERE IDR�alisateur ='" + pR�alisateur.ID + "'");
      if (liTemp == liErreur)
      liI = liErreur;
      if (liI != liErreur)
      liI += liTemp;
    
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(R�alisateur pR�alisateur)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pR�alisateur, true);
            return DataBase.Insert("[tblR�alisateur]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(R�alisateur pR�alisateur)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pR�alisateur, false);
            return DataBase.UpdateID("tblR�alisateur", lsCols, lsValues, pR�alisateur.ID);
        }

    }
}

