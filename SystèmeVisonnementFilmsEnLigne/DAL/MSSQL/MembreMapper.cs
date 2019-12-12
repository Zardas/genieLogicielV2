

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
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
            
            
        lMembre.Numéro = (string)pDataRow["Numéro"];
      
        lMembre.Nom = (string)pDataRow["Nom"];
      
        lMembre.Prénom = (string)pDataRow["Prénom"];
      
        lMembre.Adresse = (string)pDataRow["Adresse"];
      
        lMembre.Téléphone = (string)pDataRow["Téléphone"];
      
        lMembre.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lMembre.AAcceptéRecevoirNuveautés = (bool)pDataRow["AAcceptéRecevoirNuveautés"];
      
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
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Numéro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Nom) + "'";
      
    pCols[liCpt] = "Prénom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Prénom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Adresse) + "'";
      
    pCols[liCpt] = "Téléphone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.Téléphone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pMembre.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AAcceptéRecevoirNuveautés";
    
        pValues[liCpt++] = "'" + pMembre.AAcceptéRecevoirNuveautés.ToString() + "'";
      
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
            
      liTemp = DataBase.Delete("DELETE FROM tblMembreADesPréférencesCatégorie  WHERE IDMembre ='" + pMembre.ID + "'");
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

