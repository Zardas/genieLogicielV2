

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class CompteMapper : AbstractMapper, ICompteMapper
    {

        public CompteMapper()
        {
        }

        //--------------------------------------------------------------------
        public Compte Find(Guid ID)
        {
            Compte lCompte = (Compte)AbstractFind(ID);

            if (Util.isNULL(lCompte))
            {
                DataRow row = DataBase.SelectID(ID, "[tblCompte]");
                if (Util.isNULL(row))
                    return null;
                lCompte = this.FillFields(row);
                LoadedMap.Add(lCompte.ID, lCompte); 
            }
            return lCompte;
        }


        //--------------------------------------------------------------------
        private Compte FillFields(DataRow pDataRow)
        {
            Compte lCompte = new Compte();
            
            
        lCompte.Numéro = (string)pDataRow["Numéro"];
      
        lCompte.Solde = (float)pDataRow["Solde"];
      
        lCompte.NuméroCarteCrédit = (string)pDataRow["NuméroCarteCrédit"];
      
        lCompte.Titualire = (string)pDataRow["Titualire"];
      
        lCompte.DateExpiration = (DateTime)pDataRow["DateExpiration"];
      
      
            lCompte.ID = new Guid(pDataRow["ID"].ToString());

	          
        if (pDataRow["IDMembre"].GetType() != typeof(System.DBNull))
        lCompte.IDMembre = new Guid(pDataRow["IDMembre"].ToString());
    
      
            return lCompte;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblCompte]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Compte pCompte, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 5 + 1;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pCompte.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCompte.Numéro) + "'";
      
    pCols[liCpt] = "Solde";
    
        pValues[liCpt++] = "'" + pCompte.Solde.ToString() + "'";
      
    pCols[liCpt] = "NuméroCarteCrédit";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCompte.NuméroCarteCrédit) + "'";
      
    pCols[liCpt] = "Titualire";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCompte.Titualire) + "'";
      
    pCols[liCpt] = "DateExpiration";
    
        pValues[liCpt++] = "'" + pCompte.DateExpiration.ToString() + "'";
      
      if (!Util.isNULL(pCompte.IDMembre))
      {
        pCols[liCpt] = "IDMembre";
        pValues[liCpt++] = "'" + pCompte.IDMembre.ToString() + "'";
      }
    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Compte pCompte)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pCompte.ID, "[tblCompte]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
      liTemp = DataBase.Delete("DELETE FROM tblPaiementEnCompte WHERE IDCompte ='" + pCompte.ID + "'");
      if (liTemp == liErreur)
      liI = liErreur;
      if (liI != liErreur)
      liI += liTemp;
    
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Compte pCompte)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pCompte, true);
            return DataBase.Insert("[tblCompte]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Compte pCompte)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pCompte, false);
            return DataBase.UpdateID("tblCompte", lsCols, lsValues, pCompte.ID);
        }

    }
}

