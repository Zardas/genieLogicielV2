

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class MembreADesPréférencesCatégorieMapper : AbstractMapper, IMembreADesPréférencesCatégorieMapper
    {

        public MembreADesPréférencesCatégorieMapper()
        {
        }

        //--------------------------------------------------------------------
        public MembreADesPréférencesCatégorie Find(Guid ID)
        {
            MembreADesPréférencesCatégorie lMembreADesPréférencesCatégorie = (MembreADesPréférencesCatégorie)AbstractFind(ID);

            if (Util.isNULL(lMembreADesPréférencesCatégorie))
            {
                DataRow row = DataBase.SelectID(ID, "[tblMembreADesPréférencesCatégorie]");
                if (Util.isNULL(row))
                    return null;
                lMembreADesPréférencesCatégorie = this.FillFields(row);
                LoadedMap.Add(lMembreADesPréférencesCatégorie.ID, lMembreADesPréférencesCatégorie); 
            }
            return lMembreADesPréférencesCatégorie;
        }


        //--------------------------------------------------------------------
        private MembreADesPréférencesCatégorie FillFields(DataRow pDataRow)
        {
            MembreADesPréférencesCatégorie lMembreADesPréférencesCatégorie = new MembreADesPréférencesCatégorie();

            lMembreADesPréférencesCatégorie.ID = new Guid(pDataRow["ID"].ToString());
	    lMembreADesPréférencesCatégorie.IDMembre = new Guid(pDataRow["IDMembre"].ToString());
	    lMembreADesPréférencesCatégorie.IDCatégorie = new Guid(pDataRow["IDCatégorie"].ToString());
            return lMembreADesPréférencesCatégorie;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblMembreADesPréférencesCatégorie]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, MembreADesPréférencesCatégorie pMembreADesPréférencesCatégorie, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 2;
	          if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pMembreADesPréférencesCatégorie.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	   
	          pCols[liCpt] = "IDMembre";
            pValues[liCpt++] = "'" + pMembreADesPréférencesCatégorie.IDMembre.ToString() + "'";
	          pCols[liCpt] = "IDCatégorie";
            pValues[liCpt++] = "'" + pMembreADesPréférencesCatégorie.IDCatégorie.ToString() + "'";
        }

        //----------------------------------------------------------------------------------------
        public int Delete(MembreADesPréférencesCatégorie pMembreADesPréférencesCatégorie)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pMembreADesPréférencesCatégorie.ID, "[tblMembreADesPréférencesCatégorie]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(MembreADesPréférencesCatégorie pMembreADesPréférencesCatégorie)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pMembreADesPréférencesCatégorie, true);
            return DataBase.Insert("[tblMembreADesPréférencesCatégorie]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(MembreADesPréférencesCatégorie pMembreADesPréférencesCatégorie)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pMembreADesPréférencesCatégorie, false);
            return DataBase.UpdateID("tblMembreADesPréférencesCatégorie", lsCols, lsValues, pMembreADesPréférencesCatégorie.ID);
        }

    }
}

