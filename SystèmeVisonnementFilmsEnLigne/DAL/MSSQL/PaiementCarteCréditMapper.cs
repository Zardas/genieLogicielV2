

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class PaiementCarteCréditMapper : AbstractMapper, IPaiementCarteCréditMapper
    {

        public PaiementCarteCréditMapper()
        {
        }

        //--------------------------------------------------------------------
        public PaiementCarteCrédit Find(Guid ID)
        {
            PaiementCarteCrédit lPaiementCarteCrédit = (PaiementCarteCrédit)AbstractFind(ID);

            if (Util.isNULL(lPaiementCarteCrédit))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPaiementCarteCrédit]");
                if (Util.isNULL(row))
                    return null;
                lPaiementCarteCrédit = this.FillFields(row);
                LoadedMap.Add(lPaiementCarteCrédit.ID, lPaiementCarteCrédit); 
            }
            return lPaiementCarteCrédit;
        }


        //--------------------------------------------------------------------
        private PaiementCarteCrédit FillFields(DataRow pDataRow)
        {
            PaiementCarteCrédit lPaiementCarteCrédit = new PaiementCarteCrédit();
            
            
        lPaiementCarteCrédit.NuméroCarteCrédit = (string)pDataRow["NuméroCarteCrédit"];
      
        lPaiementCarteCrédit.Titulaire = (string)pDataRow["Titulaire"];
      
        lPaiementCarteCrédit.DateExpiration = (string)pDataRow["DateExpiration"];
      
        lPaiementCarteCrédit.Numéro = (string)pDataRow["Numéro"];
      
        lPaiementCarteCrédit.Date = (DateTime)pDataRow["Date"];
      
        lPaiementCarteCrédit.Montant = (float)pDataRow["Montant"];
      
      
            lPaiementCarteCrédit.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lPaiementCarteCrédit;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPaiementCarteCrédit]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, PaiementCarteCrédit pPaiementCarteCrédit, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 6 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pPaiementCarteCrédit.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "NuméroCarteCrédit";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementCarteCrédit.NuméroCarteCrédit) + "'";
      
    pCols[liCpt] = "Titulaire";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementCarteCrédit.Titulaire) + "'";
      
    pCols[liCpt] = "DateExpiration";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementCarteCrédit.DateExpiration) + "'";
      
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementCarteCrédit.Numéro) + "'";
      
    pCols[liCpt] = "Date";
    
        pValues[liCpt++] = "'" + pPaiementCarteCrédit.Date.ToString() + "'";
      
    pCols[liCpt] = "Montant";
    
        pValues[liCpt++] = "'" + pPaiementCarteCrédit.Montant.ToString() + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(PaiementCarteCrédit pPaiementCarteCrédit)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPaiementCarteCrédit.ID, "[tblPaiementCarteCrédit]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(PaiementCarteCrédit pPaiementCarteCrédit)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPaiementCarteCrédit, true);
            return DataBase.Insert("[tblPaiementCarteCrédit]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(PaiementCarteCrédit pPaiementCarteCrédit)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPaiementCarteCrédit, false);
            return DataBase.UpdateID("tblPaiementCarteCrédit", lsCols, lsValues, pPaiementCarteCrédit.ID);
        }

    }
}

