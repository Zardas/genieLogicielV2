

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class PaiementCarteCr�ditMapper : AbstractMapper, IPaiementCarteCr�ditMapper
    {

        public PaiementCarteCr�ditMapper()
        {
        }

        //--------------------------------------------------------------------
        public PaiementCarteCr�dit Find(Guid ID)
        {
            PaiementCarteCr�dit lPaiementCarteCr�dit = (PaiementCarteCr�dit)AbstractFind(ID);

            if (Util.isNULL(lPaiementCarteCr�dit))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPaiementCarteCr�dit]");
                if (Util.isNULL(row))
                    return null;
                lPaiementCarteCr�dit = this.FillFields(row);
                LoadedMap.Add(lPaiementCarteCr�dit.ID, lPaiementCarteCr�dit); 
            }
            return lPaiementCarteCr�dit;
        }


        //--------------------------------------------------------------------
        private PaiementCarteCr�dit FillFields(DataRow pDataRow)
        {
            PaiementCarteCr�dit lPaiementCarteCr�dit = new PaiementCarteCr�dit();
            
            
        lPaiementCarteCr�dit.Num�roCarteCr�dit = (string)pDataRow["Num�roCarteCr�dit"];
      
        lPaiementCarteCr�dit.Titulaire = (string)pDataRow["Titulaire"];
      
        lPaiementCarteCr�dit.DateExpiration = (string)pDataRow["DateExpiration"];
      
        lPaiementCarteCr�dit.Num�ro = (string)pDataRow["Num�ro"];
      
        lPaiementCarteCr�dit.Date = (DateTime)pDataRow["Date"];
      
        lPaiementCarteCr�dit.Montant = (float)pDataRow["Montant"];
      
      
            lPaiementCarteCr�dit.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lPaiementCarteCr�dit;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPaiementCarteCr�dit]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, PaiementCarteCr�dit pPaiementCarteCr�dit, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 6 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pPaiementCarteCr�dit.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Num�roCarteCr�dit";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementCarteCr�dit.Num�roCarteCr�dit) + "'";
      
    pCols[liCpt] = "Titulaire";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementCarteCr�dit.Titulaire) + "'";
      
    pCols[liCpt] = "DateExpiration";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementCarteCr�dit.DateExpiration) + "'";
      
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementCarteCr�dit.Num�ro) + "'";
      
    pCols[liCpt] = "Date";
    
        pValues[liCpt++] = "'" + pPaiementCarteCr�dit.Date.ToString() + "'";
      
    pCols[liCpt] = "Montant";
    
        pValues[liCpt++] = "'" + pPaiementCarteCr�dit.Montant.ToString() + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(PaiementCarteCr�dit pPaiementCarteCr�dit)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPaiementCarteCr�dit.ID, "[tblPaiementCarteCr�dit]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(PaiementCarteCr�dit pPaiementCarteCr�dit)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPaiementCarteCr�dit, true);
            return DataBase.Insert("[tblPaiementCarteCr�dit]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(PaiementCarteCr�dit pPaiementCarteCr�dit)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPaiementCarteCr�dit, false);
            return DataBase.UpdateID("tblPaiementCarteCr�dit", lsCols, lsValues, pPaiementCarteCr�dit.ID);
        }

    }
}

