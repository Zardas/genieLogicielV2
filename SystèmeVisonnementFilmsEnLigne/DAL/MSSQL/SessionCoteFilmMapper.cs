

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class SessionCoteFilmMapper : AbstractMapper, ISessionCoteFilmMapper
    {

        public SessionCoteFilmMapper()
        {
        }

        //--------------------------------------------------------------------
        public SessionCoteFilm Find(Guid ID)
        {
            SessionCoteFilm lSessionCoteFilm = (SessionCoteFilm)AbstractFind(ID);

            if (Util.isNULL(lSessionCoteFilm))
            {
                DataRow row = DataBase.SelectID(ID, "[tblSessionCoteFilm]");
                if (Util.isNULL(row))
                    return null;
                lSessionCoteFilm = this.FillFields(row);
                LoadedMap.Add(lSessionCoteFilm.ID, lSessionCoteFilm); 
            }
            return lSessionCoteFilm;
        }


        //--------------------------------------------------------------------
        private SessionCoteFilm FillFields(DataRow pDataRow)
        {
            SessionCoteFilm lSessionCoteFilm = new SessionCoteFilm();
	    

            lSessionCoteFilm.ID = new Guid(pDataRow["ID"].ToString());
	    lSessionCoteFilm.IDSession = new Guid(pDataRow["IDSession"].ToString());
	    lSessionCoteFilm.IDFilm = new Guid(pDataRow["IDFilm"].ToString());
            return lSessionCoteFilm;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblSessionCoteFilm]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, SessionCoteFilm pSessionCoteFilm, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 0 + 2;
            
	    if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pSessionCoteFilm.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
	    pCols[liCpt] = "IDSession";
            pValues[liCpt++] = "'" + pSessionCoteFilm.IDSession.ToString() + "'";
	    pCols[liCpt] = "IDFilm";
            pValues[liCpt++] = "'" + pSessionCoteFilm.IDFilm.ToString() + "'";
        }

        //----------------------------------------------------------------------------------------
        public int Delete(SessionCoteFilm pSessionCoteFilm)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pSessionCoteFilm.ID, "[tblSessionCoteFilm]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(SessionCoteFilm pSessionCoteFilm)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pSessionCoteFilm, true);
            return DataBase.Insert("[tblSessionCoteFilm]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(SessionCoteFilm pSessionCoteFilm)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pSessionCoteFilm, false);
            return DataBase.UpdateID("tblSessionCoteFilm", lsCols, lsValues, pSessionCoteFilm.ID);
        }

    }
}

