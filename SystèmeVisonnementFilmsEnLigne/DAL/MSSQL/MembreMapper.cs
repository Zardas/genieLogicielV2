

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class MembreMapper : AbstractMapper, IMembreMapper
    {

        public MembreMapper()
        {
        }

        //--------------------------------------------------------------------
        public Membre Find(Guid ID)
        {
            Membre lMembre = (Membre)AbstractFind(ID);

            if (Util.isNULL(lMembre))
            {
                DataRow row = DataBase.SelectID(ID, "[tblMembre]");
                if (Util.isNULL(row))
                    return null;
                lMembre = this.FillFields(row);
                LoadedMap.Add(lMembre.ID, lMembre); 
            }
            return lMembre;
        }


        //--------------------------------------------------------------------
        private Membre FillFields(DataRow pDataRow)
        {
            Membre lMembre = new Membre();
            
            
        lMembre.Num�ro = (string)pDataRow["Num�ro"];
      
        lMembre.Nom = (string)pDataRow["Nom"];
      
        lMembre.Pr�nom = (string)pDataRow["Pr�nom"];
      
        lMembre.Adresse = (string)pDataRow["Adresse"];
      
        lMembre.T�l�phone = (string)pDataRow["T�l�phone"];
      
        lMembre.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lMembre.AAccept�RecevoirNuveaut�s = (bool)pDataRow["AAccept�RecevoirNuveaut�s"];
      
        lMembre.NomUsager = (string)pDataRow["NomUsager"];
      
        lMembre.MotDePasse = (string)pDataRow["MotDePasse"];
      
      
            lMembre.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lMembre;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblMembre]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Membre pMembre, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 9 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pMembre.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Num�ro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Nom) + "'";
      
    pCols[liCpt] = "Pr�nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Pr�nom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Adresse) + "'";
      
    pCols[liCpt] = "T�l�phone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.T�l�phone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AAccept�RecevoirNuveaut�s";
    
        pValues[liCpt++] = "'" + pMembre.AAccept�RecevoirNuveaut�s.ToString() + "'";
      
    pCols[liCpt] = "NomUsager";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.NomUsager) + "'";
      
    pCols[liCpt] = "MotDePasse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.MotDePasse) + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Membre pMembre)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pMembre.ID, "[tblMembre]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
      liTemp = DataBase.Delete("DELETE FROM tblMembreADesPr�f�rencesCat�gorie  WHERE IDMembre ='" + pMembre.ID + "'");
      if (liTemp == liErreur)
      liI = liErreur;
      if (liI != liErreur)
      liI += liTemp;
    
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Membre pMembre)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pMembre, true);
            return DataBase.Insert("[tblMembre]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Membre pMembre)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pMembre, false);
            return DataBase.UpdateID("tblMembre", lsCols, lsValues, pMembre.ID);
        }

    }
}

