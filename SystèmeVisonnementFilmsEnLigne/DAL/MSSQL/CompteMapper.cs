

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
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
            
            
        lCompte.Num�ro = (string)pDataRow["Num�ro"];
      
        lCompte.Solde = (float)pDataRow["Solde"];
      
        lCompte.Num�roCarteCr�dit = (string)pDataRow["Num�roCarteCr�dit"];
      
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
          
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCompte.Num�ro) + "'";
      
    pCols[liCpt] = "Solde";
    
        pValues[liCpt++] = "'" + pCompte.Solde.ToString() + "'";
      
    pCols[liCpt] = "Num�roCarteCr�dit";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCompte.Num�roCarteCr�dit) + "'";
      
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

