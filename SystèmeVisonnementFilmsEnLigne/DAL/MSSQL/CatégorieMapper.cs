

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class CatégorieMapper : AbstractMapper, ICatégorieMapper
    {

        public CatégorieMapper()
        {
        }

        //--------------------------------------------------------------------
        public Catégorie Find(Guid ID)
        {
            Catégorie lCatégorie = (Catégorie)AbstractFind(ID);

            if (Util.isNULL(lCatégorie))
            {
                DataRow row = DataBase.SelectID(ID, "[tblCatégorie]");
                if (Util.isNULL(row))
                    return null;
                lCatégorie = this.FillFields(row);
                LoadedMap.Add(lCatégorie.ID, lCatégorie); 
            }
            return lCatégorie;
        }


        //--------------------------------------------------------------------
        private Catégorie FillFields(DataRow pDataRow)
        {
            Catégorie lCatégorie = new Catégorie();
            
            
        lCatégorie.Numéro = (string)pDataRow["Numéro"];
      
        lCatégorie.Description = (string)pDataRow["Description"];
      
      
            lCatégorie.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lCatégorie;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblCatégorie]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Catégorie pCatégorie, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 2 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pCatégorie.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCatégorie.Numéro) + "'";
      
    pCols[liCpt] = "Description";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCatégorie.Description) + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Catégorie pCatégorie)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pCatégorie.ID, "[tblCatégorie]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Catégorie pCatégorie)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pCatégorie, true);
            return DataBase.Insert("[tblCatégorie]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Catégorie pCatégorie)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pCatégorie, false);
            return DataBase.UpdateID("tblCatégorie", lsCols, lsValues, pCatégorie.ID);
        }

    }
}

