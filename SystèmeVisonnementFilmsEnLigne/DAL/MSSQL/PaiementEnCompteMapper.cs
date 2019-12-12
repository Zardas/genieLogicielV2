

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class PaiementEnCompteMapper : AbstractMapper, IPaiementEnCompteMapper
    {

        public PaiementEnCompteMapper()
        {
        }

        //--------------------------------------------------------------------
        public PaiementEnCompte Find(Guid ID)
        {
            PaiementEnCompte lPaiementEnCompte = (PaiementEnCompte)AbstractFind(ID);

            if (Util.isNULL(lPaiementEnCompte))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPaiementEnCompte]");
                if (Util.isNULL(row))
                    return null;
                lPaiementEnCompte = this.FillFields(row);
                LoadedMap.Add(lPaiementEnCompte.ID, lPaiementEnCompte); 
            }
            return lPaiementEnCompte;
        }


        //--------------------------------------------------------------------
        private PaiementEnCompte FillFields(DataRow pDataRow)
        {
            PaiementEnCompte lPaiementEnCompte = new PaiementEnCompte();
            
            
        lPaiementEnCompte.Numéro = (string)pDataRow["Numéro"];
      
        lPaiementEnCompte.Date = (DateTime)pDataRow["Date"];
      
        lPaiementEnCompte.Montant = (float)pDataRow["Montant"];
      
      
            lPaiementEnCompte.ID = new Guid(pDataRow["ID"].ToString());

	          
        if (pDataRow["IDCompte"].GetType() != typeof(System.DBNull))
        lPaiementEnCompte.IDCompte = new Guid(pDataRow["IDCompte"].ToString());
    
      
            return lPaiementEnCompte;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPaiementEnCompte]", "");
        }


  
        //--------------------------------------------------------------------
        public DataTable FindAllPourUnCompte(Guid pCompteId)
        {
        return DataBase.Select("SELECT * FROM tblPaiementEnCompte WHERE IDCompte='" + pCompteId.ToString() + "'");
        }
      
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, PaiementEnCompte pPaiementEnCompte, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 3 + 1;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pPaiementEnCompte.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiementEnCompte.Numéro) + "'";
      
    pCols[liCpt] = "Date";
    
        pValues[liCpt++] = "'" + pPaiementEnCompte.Date.ToString() + "'";
      
    pCols[liCpt] = "Montant";
    
        pValues[liCpt++] = "'" + pPaiementEnCompte.Montant.ToString() + "'";
      
      if (!Util.isNULL(pPaiementEnCompte.IDCompte))
      {
        pCols[liCpt] = "IDCompte";
        pValues[liCpt++] = "'" + pPaiementEnCompte.IDCompte.ToString() + "'";
      }
    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(PaiementEnCompte pPaiementEnCompte)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPaiementEnCompte.ID, "[tblPaiementEnCompte]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(PaiementEnCompte pPaiementEnCompte)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPaiementEnCompte, true);
            return DataBase.Insert("[tblPaiementEnCompte]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(PaiementEnCompte pPaiementEnCompte)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPaiementEnCompte, false);
            return DataBase.UpdateID("tblPaiementEnCompte", lsCols, lsValues, pPaiementEnCompte.ID);
        }

    }
}

