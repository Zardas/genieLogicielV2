

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class AdministrateurMapper : AbstractMapper, IAdministrateurMapper
    {

        public AdministrateurMapper()
        {
        }

        //--------------------------------------------------------------------
        public Administrateur Find(Guid ID)
        {
            Administrateur lAdministrateur = (Administrateur)AbstractFind(ID);

            if (Util.isNULL(lAdministrateur))
            {
                DataRow row = DataBase.SelectID(ID, "[tblAdministrateur]");
                if (Util.isNULL(row))
                    return null;
                lAdministrateur = this.FillFields(row);
                LoadedMap.Add(lAdministrateur.ID, lAdministrateur); 
            }
            return lAdministrateur;
        }


        //--------------------------------------------------------------------
        private Administrateur FillFields(DataRow pDataRow)
        {
            Administrateur lAdministrateur = new Administrateur();
            
            
        lAdministrateur.Num�ro = (string)pDataRow["Num�ro"];
      
        lAdministrateur.Nom = (string)pDataRow["Nom"];
      
        lAdministrateur.Pr�nom = (string)pDataRow["Pr�nom"];
      
        lAdministrateur.Adresse = (string)pDataRow["Adresse"];
      
        lAdministrateur.T�l�phone = (string)pDataRow["T�l�phone"];
      
        lAdministrateur.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lAdministrateur.AAccept�RecevoirNuveaut�s = (bool)pDataRow["AAccept�RecevoirNuveaut�s"];
      
        lAdministrateur.NomUsager = (string)pDataRow["NomUsager"];
      
        lAdministrateur.MotDePasse = (string)pDataRow["MotDePasse"];
      
      
            lAdministrateur.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lAdministrateur;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblAdministrateur]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Administrateur pAdministrateur, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 9 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pAdministrateur.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Num�ro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Nom) + "'";
      
    pCols[liCpt] = "Pr�nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Pr�nom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Adresse) + "'";
      
    pCols[liCpt] = "T�l�phone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.T�l�phone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AAccept�RecevoirNuveaut�s";
    
        pValues[liCpt++] = "'" + pAdministrateur.AAccept�RecevoirNuveaut�s.ToString() + "'";
      
    pCols[liCpt] = "NomUsager";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.NomUsager) + "'";
      
    pCols[liCpt] = "MotDePasse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.MotDePasse) + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Administrateur pAdministrateur)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pAdministrateur.ID, "[tblAdministrateur]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Administrateur pAdministrateur)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pAdministrateur, true);
            return DataBase.Insert("[tblAdministrateur]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Administrateur pAdministrateur)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pAdministrateur, false);
            return DataBase.UpdateID("tblAdministrateur", lsCols, lsValues, pAdministrateur.ID);
        }

    }
}

