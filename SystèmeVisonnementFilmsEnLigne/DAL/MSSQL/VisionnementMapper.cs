

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class VisionnementMapper : AbstractMapper, IVisionnementMapper
    {

        public VisionnementMapper()
        {
        }

        //--------------------------------------------------------------------
        public Visionnement Find(Guid ID)
        {
            Visionnement lVisionnement = (Visionnement)AbstractFind(ID);

            if (Util.isNULL(lVisionnement))
            {
                DataRow row = DataBase.SelectID(ID, "[tblVisionnement]");
                if (Util.isNULL(row))
                    return null;
                lVisionnement = this.FillFields(row);
                LoadedMap.Add(lVisionnement.ID, lVisionnement); 
            }
            return lVisionnement;
        }


        //--------------------------------------------------------------------
        private Visionnement FillFields(DataRow pDataRow)
        {
            Visionnement lVisionnement = new Visionnement();
            
            
        lVisionnement.Numéro = (string)pDataRow["Numéro"];
      
        lVisionnement.DateTransaction = (DateTime)pDataRow["DateTransaction"];
      
        lVisionnement.TypeTransaction = (string)pDataRow["TypeTransaction"];
      
        lVisionnement.Prix = (float)pDataRow["Prix"];
      
        lVisionnement.MontantTaxe = (float)pDataRow["MontantTaxe"];
      
      
            lVisionnement.ID = new Guid(pDataRow["ID"].ToString());

	          
        if (pDataRow["IDPaiement"].GetType() != typeof(System.DBNull))
        lVisionnement.IDPaiement = new Guid(pDataRow["IDPaiement"].ToString());
    
      
            return lVisionnement;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblVisionnement]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Visionnement pVisionnement, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 5 + 1;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pVisionnement.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pVisionnement.Numéro) + "'";
      
    pCols[liCpt] = "DateTransaction";
    
        pValues[liCpt++] = "'" + pVisionnement.DateTransaction.ToString() + "'";
      
    pCols[liCpt] = "TypeTransaction";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pVisionnement.TypeTransaction) + "'";
      
    pCols[liCpt] = "Prix";
    
        pValues[liCpt++] = "'" + pVisionnement.Prix.ToString() + "'";
      
    pCols[liCpt] = "MontantTaxe";
    
        pValues[liCpt++] = "'" + pVisionnement.MontantTaxe.ToString() + "'";
      
      if (!Util.isNULL(pVisionnement.IDPaiement))
      {
        pCols[liCpt] = "IDPaiement";
        pValues[liCpt++] = "'" + pVisionnement.IDPaiement.ToString() + "'";
      }
    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Visionnement pVisionnement)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pVisionnement.ID, "[tblVisionnement]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Visionnement pVisionnement)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pVisionnement, true);
            return DataBase.Insert("[tblVisionnement]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Visionnement pVisionnement)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pVisionnement, false);
            return DataBase.UpdateID("tblVisionnement", lsCols, lsValues, pVisionnement.ID);
        }

    }
}

