

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class RéalisateurMapper : AbstractMapper, IRéalisateurMapper
    {

        public RéalisateurMapper()
        {
        }

        //--------------------------------------------------------------------
        public Réalisateur Find(Guid ID)
        {
            Réalisateur lRéalisateur = (Réalisateur)AbstractFind(ID);

            if (Util.isNULL(lRéalisateur))
            {
                DataRow row = DataBase.SelectID(ID, "[tblRéalisateur]");
                if (Util.isNULL(row))
                    return null;
                lRéalisateur = this.FillFields(row);
                LoadedMap.Add(lRéalisateur.ID, lRéalisateur); 
            }
            return lRéalisateur;
        }


        //--------------------------------------------------------------------
        private Réalisateur FillFields(DataRow pDataRow)
        {
            Réalisateur lRéalisateur = new Réalisateur();
            
            
        lRéalisateur.Numéro = (string)pDataRow["Numéro"];
      
        lRéalisateur.Nom = (string)pDataRow["Nom"];
      
        lRéalisateur.Prénom = (string)pDataRow["Prénom"];
      
        lRéalisateur.Adresse = (string)pDataRow["Adresse"];
      
        lRéalisateur.Téléphone = (string)pDataRow["Téléphone"];
      
        lRéalisateur.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lRéalisateur.AAcceptéRecevoirNuveautés = (bool)pDataRow["AAcceptéRecevoirNuveautés"];
      
        lRéalisateur.NomUsager = (string)pDataRow["NomUsager"];
      
        lRéalisateur.MotDePasse = (string)pDataRow["MotDePasse"];
      
      
            lRéalisateur.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lRéalisateur;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblRéalisateur]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Réalisateur pRéalisateur, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 9 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pRéalisateur.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRéalisateur.Numéro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRéalisateur.Nom) + "'";
      
    pCols[liCpt] = "Prénom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRéalisateur.Prénom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRéalisateur.Adresse) + "'";
      
    pCols[liCpt] = "Téléphone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRéalisateur.Téléphone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRéalisateur.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AAcceptéRecevoirNuveautés";
    
        pValues[liCpt++] = "'" + pRéalisateur.AAcceptéRecevoirNuveautés.ToString() + "'";
      
    pCols[liCpt] = "NomUsager";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRéalisateur.NomUsager) + "'";
      
    pCols[liCpt] = "MotDePasse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pRéalisateur.MotDePasse) + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Réalisateur pRéalisateur)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pRéalisateur.ID, "[tblRéalisateur]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
      liTemp = DataBase.Delete("DELETE FROM tblFilm WHERE IDRéalisateur ='" + pRéalisateur.ID + "'");
      if (liTemp == liErreur)
      liI = liErreur;
      if (liI != liErreur)
      liI += liTemp;
    
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Réalisateur pRéalisateur)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pRéalisateur, true);
            return DataBase.Insert("[tblRéalisateur]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Réalisateur pRéalisateur)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pRéalisateur, false);
            return DataBase.UpdateID("tblRéalisateur", lsCols, lsValues, pRéalisateur.ID);
        }

    }
}

