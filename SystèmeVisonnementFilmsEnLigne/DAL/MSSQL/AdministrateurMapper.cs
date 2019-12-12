

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
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
            
            
        lAdministrateur.Numéro = (string)pDataRow["Numéro"];
      
        lAdministrateur.Nom = (string)pDataRow["Nom"];
      
        lAdministrateur.Prénom = (string)pDataRow["Prénom"];
      
        lAdministrateur.Adresse = (string)pDataRow["Adresse"];
      
        lAdministrateur.Téléphone = (string)pDataRow["Téléphone"];
      
        lAdministrateur.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lAdministrateur.AAcceptéRecevoirNuveautés = (bool)pDataRow["AAcceptéRecevoirNuveautés"];
      
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
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Numéro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Nom) + "'";
      
    pCols[liCpt] = "Prénom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Prénom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Adresse) + "'";
      
    pCols[liCpt] = "Téléphone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.Téléphone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pAdministrateur.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AAcceptéRecevoirNuveautés";
    
        pValues[liCpt++] = "'" + pAdministrateur.AAcceptéRecevoirNuveautés.ToString() + "'";
      
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

