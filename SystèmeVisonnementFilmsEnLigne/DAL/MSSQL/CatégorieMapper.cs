

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class Cat�gorieMapper : AbstractMapper, ICat�gorieMapper
    {

        public Cat�gorieMapper()
        {
        }

        //--------------------------------------------------------------------
        public Cat�gorie Find(Guid ID)
        {
            Cat�gorie lCat�gorie = (Cat�gorie)AbstractFind(ID);

            if (Util.isNULL(lCat�gorie))
            {
                DataRow row = DataBase.SelectID(ID, "[tblCat�gorie]");
                if (Util.isNULL(row))
                    return null;
                lCat�gorie = this.FillFields(row);
                LoadedMap.Add(lCat�gorie.ID, lCat�gorie); 
            }
            return lCat�gorie;
        }


        //--------------------------------------------------------------------
        private Cat�gorie FillFields(DataRow pDataRow)
        {
            Cat�gorie lCat�gorie = new Cat�gorie();
            
            
        lCat�gorie.Num�ro = (string)pDataRow["Num�ro"];
      
        lCat�gorie.Description = (string)pDataRow["Description"];
      
      
            lCat�gorie.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lCat�gorie;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblCat�gorie]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Cat�gorie pCat�gorie, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 2 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pCat�gorie.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCat�gorie.Num�ro) + "'";
      
    pCols[liCpt] = "Description";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pCat�gorie.Description) + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Cat�gorie pCat�gorie)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pCat�gorie.ID, "[tblCat�gorie]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Cat�gorie pCat�gorie)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pCat�gorie, true);
            return DataBase.Insert("[tblCat�gorie]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Cat�gorie pCat�gorie)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pCat�gorie, false);
            return DataBase.UpdateID("tblCat�gorie", lsCols, lsValues, pCat�gorie.ID);
        }

    }
}

