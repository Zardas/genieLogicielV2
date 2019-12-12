

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meVisonnementFilmsEnLigne.Logique;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
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
            
            
        lClient.Num�ro = (string)pDataRow["Num�ro"];
      
        lClient.Nom = (string)pDataRow["Nom"];
      
        lClient.Pr�nom = (string)pDataRow["Pr�nom"];
      
        lClient.Adresse = (string)pDataRow["Adresse"];
      
        lClient.T�l�phone = (string)pDataRow["T�l�phone"];
      
        lClient.AdresseCourriel = (string)pDataRow["AdresseCourriel"];
      
        lClient.AAccept�RecevoirNuveaut�s = (bool)pDataRow["AAccept�RecevoirNuveaut�s"];
      
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
          
    pCols[liCpt] = "Num�ro";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Num�ro) + "'";
      
    pCols[liCpt] = "Nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Nom) + "'";
      
    pCols[liCpt] = "Pr�nom";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Pr�nom) + "'";
      
    pCols[liCpt] = "Adresse";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.Adresse) + "'";
      
    pCols[liCpt] = "T�l�phone";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.T�l�phone) + "'";
      
    pCols[liCpt] = "AdresseCourriel";
    
        pValues[liCpt++] = "'" + Util.DoubleQuote(pClient.AdresseCourriel) + "'";
      
    pCols[liCpt] = "AAccept�RecevoirNuveaut�s";
    
        pValues[liCpt++] = "'" + pClient.AAccept�RecevoirNuveaut�s.ToString() + "'";
      
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

