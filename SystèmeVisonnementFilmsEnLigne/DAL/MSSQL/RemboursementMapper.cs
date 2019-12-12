

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class RemboursementMapper : AbstractMapper, IRemboursementMapper
    {

        public RemboursementMapper()
        {
        }

        //--------------------------------------------------------------------
        public Remboursement Find(Guid ID)
        {
            Remboursement lRemboursement = (Remboursement)AbstractFind(ID);

            if (Util.isNULL(lRemboursement))
            {
                DataRow row = DataBase.SelectID(ID, "[tblRemboursement]");
                if (Util.isNULL(row))
                    return null;
                lRemboursement = this.FillFields(row);
                LoadedMap.Add(lRemboursement.ID, lRemboursement); 
            }
            return lRemboursement;
        }


        //--------------------------------------------------------------------
        private Remboursement FillFields(DataRow pDataRow)
        {
            Remboursement lRemboursement = new Remboursement();
            
            
        lRemboursement.Numéro = (string)pDataRow["Numéro"];
      
        lRemboursement.DateTransaction = (DateTime)pDataRow["DateTransaction"];
      
        lRemboursement.TypeTransaction = (string)pDataRow["TypeTransaction"];
      
        lRemboursement.Prix = (float)pDataRow["Prix"];
      
        lRemboursement.MontantTaxe = (float)pDataRow["MontantTaxe"];
      
      
            lRemboursement.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lRemboursement;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblRemboursement]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Remboursement pRemboursement, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 5 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pRemboursement.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRemboursement.Numéro) + "'";
      
    pCols[liCpt] = "DateTransaction";
    
        pValues[liCpt++] = "'" + pRemboursement.DateTransaction.ToString() + "'";
      
    pCols[liCpt] = "TypeTransaction";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRemboursement.TypeTransaction) + "'";
      
    pCols[liCpt] = "Prix";
    
        pValues[liCpt++] = "'" + pRemboursement.Prix.ToString() + "'";
      
    pCols[liCpt] = "MontantTaxe";
    
        pValues[liCpt++] = "'" + pRemboursement.MontantTaxe.ToString() + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Remboursement pRemboursement)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pRemboursement.ID, "[tblRemboursement]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Remboursement pRemboursement)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pRemboursement, true);
            return DataBase.Insert("[tblRemboursement]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Remboursement pRemboursement)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pRemboursement, false);
            return DataBase.UpdateID("tblRemboursement", lsCols, lsValues, pRemboursement.ID);
        }

    }
}

