

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class ClientMapper : AbstractMapper, IClientMapper
    {

        public ClientMapper()
        {
        }

        //--------------------------------------------------------------------
        public Client Find(Guid ID)
        {
            Client lClient = (Client)AbstractFind(ID);

            if (Util.isNULL(lClient))
            {
                DataRow row = DataBase.SelectID(ID, "[tblClient]");
                if (Util.isNULL(row))
                    return null;
                lClient = this.FillFields(row);
                LoadedMap.Add(lClient.ID, lClient); 
            }
            return lClient;
        }


        //--------------------------------------------------------------------
        private Client FillFields(DataRow pDataRow)
        {
            Client lClient = new Client();
            
            
        lClient.Numéro = (string)pDataRow["Numéro"];
      
        lClient.Nom = (string)pDataRow["Nom"];
      
        lClient.Prénom = (string)pDataRow["Prénom"];
      
        lClient.Adresse = (string)pDataRow["Adresse"];
      
        lClient.Téléphone = (string)pDataRow["Téléphone"];
      
        lClient.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lClient.AAcceptéRecevoirNuveautés = (bool)pDataRow["AAcceptéRecevoirNuveautés"];
      
        lClient.NomUsager = (string)pDataRow["NomUsager"];
      
        lClient.MotDePasse = (string)pDataRow["MotDePasse"];
      
      
            lClient.ID = new Guid(pDataRow["ID"].ToString());

	          
      
            return lClient;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblClient]", "");
        }


  
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Client pClient, bool pIsInsertID)
      {
        int liCpt = 0;
        
  
    int liNombre = 9 + 0;
	  
 
	      if (pIsInsertID)
         {
            pCols = new string[liNombre + 1];
            pValues = new string[liNombre + 1];
            pCols[liCpt] = "ID";
            pValues[liCpt++] = "'" + pClient.ID.ToString() + "'";
         }
         else
          {
            pCols = new string[liNombre];
            pValues = new string[liNombre];
          }  
          
    pCols[liCpt] = "Numéro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Numéro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Nom) + "'";
      
    pCols[liCpt] = "Prénom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Prénom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Adresse) + "'";
      
    pCols[liCpt] = "Téléphone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Téléphone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AAcceptéRecevoirNuveautés";
    
        pValues[liCpt++] = "'" + pClient.AAcceptéRecevoirNuveautés.ToString() + "'";
      
    pCols[liCpt] = "NomUsager";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.NomUsager) + "'";
      
    pCols[liCpt] = "MotDePasse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.MotDePasse) + "'";
      
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Client pClient)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pClient.ID, "[tblClient]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
            
            return liI;
      }

        //--------------------------------------------------------------------

        public int Insert(Client pClient)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pClient, true);
            return DataBase.Insert("[tblClient]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Client pClient)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pClient, false);
            return DataBase.UpdateID("tblClient", lsCols, lsValues, pClient.ID);
        }

    }
}

