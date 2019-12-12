

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class MembreADesPr�f�rencesCat�gorieMapper : AbstractMapper, IMembreADesPr�f�rencesCat�gorieMapper
    {

        public MembreADesPr�f�rencesCat�gorieMapper()
        {
        }

        //--------------------------------------------------------------------
        public MembreADesPr�f�rencesCat�gorie Find(Guid ID)
        {
            MembreADesPr�f�rencesCat�gorie lMembreADesPr�f�rencesCat�gorie = (MembreADesPr�f�rencesCat�gorie)AbstractFind(ID);

            if (Util.isNULL(lMembreADesPr�f�rencesCat�gorie))
            {
                DataRow row = DataBase.SelectID(ID, "[tblMembreADesPr�f�rencesCat�gorie]");
                if (Util.isNULL(row))
                    return null;
                lMembreADesPr�f�rencesCat�gorie = this.FillFields(row);
                LoadedMap.Add(lMembreADesPr�f�rencesCat�gorie.ID, lMembreADesPr�f�rencesCat�gorie); 
            }
            return lMembreADesPr�f�rencesCat�gorie;
        }


        //--------------------------------------------------------------------
        private MembreADesPr�f�rencesCat�gorie FillFields(DataRow pDataRow)
        {
            MembreADesPr�f�rencesCat�gorie lMembreADesPr�f�rencesCat�gorie = new MembreADesPr�f�rencesCat�gorie();

            lMembreADesPr�f�rencesCat�gorie.ID = new Guid(pDataRow["ID"].ToString());
	    lMembreADesPr�f�rencesCat�gorie.IDMembre = new Guid(pDataRow["IDMembre"].ToString());
	    lMembreADesPr�f�rencesCat�gorie.IDCat�gorie = new Guid(pDataRow["IDCat�gorie"].ToString());
            return lMembreADesPr�f�rencesCat�gorie;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblMembreADesPr�f�rencesCat�gorie]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, MembreADesPr�f�rencesCat�gorie pMembreADesPr�f�rencesCat�gorie, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 2;
	          if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pMembreADesPr�f�rencesCat�gorie.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	   
	          pCols[liCpt] = "IDMembre";
            pValues[liCpt++] = "'" + pMembreADesPr�f�rencesCat�gorie.IDMembre.ToString() + "'";
	          pCols[liCpt] = "IDCat�gorie";
            pValues[liCpt++] = "'" + pMembreADesPr�f�rencesCat�gorie.IDCat�gorie.ToString() + "'";
        }

        //----------------------------------------------------------------------------------------
        public int Delete(MembreADesPr�f�rencesCat�gorie pMembreADesPr�f�rencesCat�gorie)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pMembreADesPr�f�rencesCat�gorie.ID, "[tblMembreADesPr�f�rencesCat�gorie]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(MembreADesPr�f�rencesCat�gorie pMembreADesPr�f�rencesCat�gorie)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pMembreADesPr�f�rencesCat�gorie, true);
            return DataBase.Insert("[tblMembreADesPr�f�rencesCat�gorie]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(MembreADesPr�f�rencesCat�gorie pMembreADesPr�f�rencesCat�gorie)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pMembreADesPr�f�rencesCat�gorie, false);
            return DataBase.UpdateID("tblMembreADesPr�f�rencesCat�gorie", lsCols, lsValues, pMembreADesPr�f�rencesCat�gorie.ID);
        }

    }
}

