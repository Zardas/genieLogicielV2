

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class SessionMapper : AbstractMapper, ISessionMapper
    {

        public SessionMapper()
        {
        }

        //--------------------------------------------------------------------
        public Session Find(Guid ID)
        {
            Session lSession = (Session)AbstractFind(ID);

            if (Util.isNULL(lSession))
            {
                DataRow row = DataBase.SelectID(ID, "[tblSession]");
                if (Util.isNULL(row))
                    return null;
                lSession = this.FillFields(row);
                LoadedMap.Add(lSession.ID, lSession); 
            }
            return lSession;
        }


        //--------------------------------------------------------------------
        private Session FillFields(DataRow pDataRow)
        {
            Session lSession = new Session();
            
            
        lSession.Num�ro = (string)pDataRow["Num�ro"];
      
        lSession.DateConnexion = (DateTime)pDataRow["DateConnexion"];
      
        lSession.DateD�connexion = (DateTime)pDataRow["DateD�connexion"];
      
      
            lSession.ID = new Guid(pDataRow["ID"].ToString());

	          
        if (pDataRow["IDVisiteur"].GetType() != typeof(System.DBNull))
        lSession.IDVisiteur = new Guid(pDataRow["IDVisiteur"].ToString());
    
      
            return lSession;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblSession]", "");
        }


  
        //--------------------------------------------------------------------
        public DataTable FindAllPourUnVisiteur(Guid pVisiteurId)
        {
        return DataBase.Select("SELECT * FROM tblSession WHERE IDVisiteur='" + pVisiteurId.ToString() + "'");
        }
      
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Session pSession, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 3 + 1;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pSession.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pSession.Num�ro) + "'";
      
    pCols[liCpt] = "DateConnexion";
    
        pValues[liCpt++] = "'" + pSession.DateConnexion.ToString() + "'";
      
    pCols[liCpt] = "DateD�connexion";
    
        pValues[liCpt++] = "'" + pSession.DateD�connexion.ToString() + "'";
      
      if (!Util.isNULL(pSession.IDVisiteur))
      {
        pCols[liCpt] = "IDVisiteur";
        pValues[liCpt++] = "'" + pSession.IDVisiteur.ToString() + "'";
      }
    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Session pSession)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pSession.ID, "[tblSession]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
      liTemp = DataBase.Delete("DELETE FROM tblSessionCoteFilm  WHERE IDSession ='" + pSession.ID + "'");
      if (liTemp == liErreur)
      liI = liErreur;
      if (liI != liErreur)
      liI += liTemp;
    
      liTemp = DataBase.Delete("DELETE FROM tblTransaction WHERE IDSession ='" + pSession.ID + "'");
      if (liTemp == liErreur)
      liI = liErreur;
      if (liI != liErreur)
      liI += liTemp;
    
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Session pSession)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pSession, true);
            return DataBase.Insert("[tblSession]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Session pSession)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pSession, false);
            return DataBase.UpdateID("tblSession", lsCols, lsValues, pSession.ID);
        }

    }
}

