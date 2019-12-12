

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class ApprovisionnementMapper : AbstractMapper, IApprovisionnementMapper
    {

        public ApprovisionnementMapper()
        {
        }

        //--------------------------------------------------------------------
        public Approvisionnement Find(Guid ID)
        {
            Approvisionnement lApprovisionnement = (Approvisionnement)AbstractFind(ID);

            if (Util.isNULL(lApprovisionnement))
            {
                DataRow row = DataBase.SelectID(ID, "[tblApprovisionnement]");
                if (Util.isNULL(row))
                    return null;
                lApprovisionnement = this.FillFields(row);
                LoadedMap.Add(lApprovisionnement.ID, lApprovisionnement); 
            }
            return lApprovisionnement;
        }


        //--------------------------------------------------------------------
        private Approvisionnement FillFields(DataRow pDataRow)
        {
            Approvisionnement lApprovisionnement = new Approvisionnement();
            
            
        lApprovisionnement.Numéro = (string)pDataRow["Numéro"];
      
        lApprovisionnement.DateTransaction = (DateTime)pDataRow["DateTransaction"];
      
        lApprovisionnement.TypeTransaction = (string)pDataRow["TypeTransaction"];
      
        lApprovisionnement.Prix = (float)pDataRow["Prix"];
      
        lApprovisionnement.MontantTaxe = (float)pDataRow["MontantTaxe"];
      
      
            lApprovisionnement.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lApprovisionnement;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblApprovisionnement]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Approvisionnement pApprovisionnement, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 5 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pApprovisionnement.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pApprovisionnement.Numéro) + "'";
      
    pCols[liCpt] = "DateTransaction";
    
        pValues[liCpt++] = "'" + pApprovisionnement.DateTransaction.ToString() + "'";
      
    pCols[liCpt] = "TypeTransaction";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pApprovisionnement.TypeTransaction) + "'";
      
    pCols[liCpt] = "Prix";
    
        pValues[liCpt++] = "'" + pApprovisionnement.Prix.ToString() + "'";
      
    pCols[liCpt] = "MontantTaxe";
    
        pValues[liCpt++] = "'" + pApprovisionnement.MontantTaxe.ToString() + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Approvisionnement pApprovisionnement)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pApprovisionnement.ID, "[tblApprovisionnement]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Approvisionnement pApprovisionnement)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pApprovisionnement, true);
            return DataBase.Insert("[tblApprovisionnement]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Approvisionnement pApprovisionnement)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pApprovisionnement, false);
            return DataBase.UpdateID("tblApprovisionnement", lsCols, lsValues, pApprovisionnement.ID);
        }

    }
}

