

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class TransactionMapper : AbstractMapper, ITransactionMapper
    {

        public TransactionMapper()
        {
        }

        //--------------------------------------------------------------------
        public Transaction Find(Guid ID)
        {
            Transaction lTransaction = (Transaction)AbstractFind(ID);

            if (Util.isNULL(lTransaction))
            {
                DataRow row = DataBase.SelectID(ID, "[tblTransaction]");
                if (Util.isNULL(row))
                    return null;
                lTransaction = this.FillFields(row);
                LoadedMap.Add(lTransaction.ID, lTransaction); 
            }
            return lTransaction;
        }


        //--------------------------------------------------------------------
        private Transaction FillFields(DataRow pDataRow)
        {
            Transaction lTransaction = new Transaction();
            
            
        lTransaction.Numéro = (string)pDataRow["Numéro"];
      
        lTransaction.DateTransaction = (DateTime)pDataRow["DateTransaction"];
      
        lTransaction.TypeTransaction = (string)pDataRow["TypeTransaction"];
      
        lTransaction.Prix = (float)pDataRow["Prix"];
      
        lTransaction.MontantTaxe = (float)pDataRow["MontantTaxe"];
      
      
            lTransaction.ID = new Guid(pDataRow["ID"].ToString());

	          
        if (pDataRow["IDSession"].GetType() != typeof(System.DBNull))
        lTransaction.IDSession = new Guid(pDataRow["IDSession"].ToString());
    
      
            return lTransaction;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblTransaction]", "");
        }


  
        //--------------------------------------------------------------------
        public DataTable FindAllPourUnSession(Guid pSessionId)
        {
        return DataBase.Select("SELECT * FROM tblTransaction WHERE IDSession='" + pSessionId.ToString() + "'");
        }
      
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Transaction pTransaction, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 5 + 1;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pTransaction.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pTransaction.Numéro) + "'";
      
    pCols[liCpt] = "DateTransaction";
    
        pValues[liCpt++] = "'" + pTransaction.DateTransaction.ToString() + "'";
      
    pCols[liCpt] = "TypeTransaction";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pTransaction.TypeTransaction) + "'";
      
    pCols[liCpt] = "Prix";
    
        pValues[liCpt++] = "'" + pTransaction.Prix.ToString() + "'";
      
    pCols[liCpt] = "MontantTaxe";
    
        pValues[liCpt++] = "'" + pTransaction.MontantTaxe.ToString() + "'";
      
      if (!Util.isNULL(pTransaction.IDSession))
      {
        pCols[liCpt] = "IDSession";
        pValues[liCpt++] = "'" + pTransaction.IDSession.ToString() + "'";
      }
    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Transaction pTransaction)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pTransaction.ID, "[tblTransaction]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Transaction pTransaction)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pTransaction, true);
            return DataBase.Insert("[tblTransaction]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Transaction pTransaction)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pTransaction, false);
            return DataBase.UpdateID("tblTransaction", lsCols, lsValues, pTransaction.ID);
        }

    }
}

