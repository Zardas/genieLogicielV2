

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class VisiteurMapper : AbstractMapper, IVisiteurMapper
    {

        public VisiteurMapper()
        {
        }

        //--------------------------------------------------------------------
        public Visiteur Find(Guid ID)
        {
            Visiteur lVisiteur = (Visiteur)AbstractFind(ID);

            if (Util.isNULL(lVisiteur))
            {
                DataRow row = DataBase.SelectID(ID, "[tblVisiteur]");
                if (Util.isNULL(row))
                    return null;
                lVisiteur = this.FillFields(row);
                LoadedMap.Add(lVisiteur.ID, lVisiteur); 
            }
            return lVisiteur;
        }


        //--------------------------------------------------------------------
        private Visiteur FillFields(DataRow pDataRow)
        {
            Visiteur lVisiteur = new Visiteur();
            
            
      
            lVisiteur.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lVisiteur;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblVisiteur]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Visiteur pVisiteur, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 0 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pVisiteur.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Visiteur pVisiteur)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pVisiteur.ID, "[tblVisiteur]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
      liTemp = DataBase.Delete("DELETE FROM tblSession WHERE IDVisiteur ='" + pVisiteur.ID + "'");
      if (liTemp == liErreur)
      liI = liErreur;
      if (liI != liErreur)
      liI += liTemp;
    
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Visiteur pVisiteur)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pVisiteur, true);
            return DataBase.Insert("[tblVisiteur]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Visiteur pVisiteur)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pVisiteur, false);
            return DataBase.UpdateID("tblVisiteur", lsCols, lsValues, pVisiteur.ID);
        }

    }
}

