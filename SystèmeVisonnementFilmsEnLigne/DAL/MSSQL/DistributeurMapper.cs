

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class DistributeurMapper : AbstractMapper, IDistributeurMapper
    {

        public DistributeurMapper()
        {
        }

        //--------------------------------------------------------------------
        public Distributeur Find(Guid ID)
        {
            Distributeur lDistributeur = (Distributeur)AbstractFind(ID);

            if (Util.isNULL(lDistributeur))
            {
                DataRow row = DataBase.SelectID(ID, "[tblDistributeur]");
                if (Util.isNULL(row))
                    return null;
                lDistributeur = this.FillFields(row);
                LoadedMap.Add(lDistributeur.ID, lDistributeur); 
            }
            return lDistributeur;
        }


        //--------------------------------------------------------------------
        private Distributeur FillFields(DataRow pDataRow)
        {
            Distributeur lDistributeur = new Distributeur();
            
            
        lDistributeur.Numéro = (string)pDataRow["Numéro"];
      
        lDistributeur.Nom = (string)pDataRow["Nom"];
      
        lDistributeur.Adresse = (string)pDataRow["Adresse"];
      
        lDistributeur.Téléphone = (string)pDataRow["Téléphone"];
      
        lDistributeur.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lDistributeur.AdresseSiteWeb = (string)pDataRow["AdresseSiteWeb"];
      
      
            lDistributeur.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lDistributeur;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblDistributeur]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Distributeur pDistributeur, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 6 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pDistributeur.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pDistributeur.Numéro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pDistributeur.Nom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pDistributeur.Adresse) + "'";
      
    pCols[liCpt] = "Téléphone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pDistributeur.Téléphone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pDistributeur.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AdresseSiteWeb";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pDistributeur.AdresseSiteWeb) + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Distributeur pDistributeur)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pDistributeur.ID, "[tblDistributeur]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Distributeur pDistributeur)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pDistributeur, true);
            return DataBase.Insert("[tblDistributeur]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Distributeur pDistributeur)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pDistributeur, false);
            return DataBase.UpdateID("tblDistributeur", lsCols, lsValues, pDistributeur.ID);
        }

    }
}

