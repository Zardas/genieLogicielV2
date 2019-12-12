
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeVisonnementFilmsEnLigne.DAL
{
    public abstract class DataMapperFactory
    {
        	
		public abstract IRemboursementMapper GetRemboursementMapper();
	    	
		public abstract IApprovisionnementMapper GetApprovisionnementMapper();
	    	
		public abstract IVisionnementMapper GetVisionnementMapper();
	    	
		public abstract ICatégorieMapper GetCatégorieMapper();
	    	
		public abstract IClientMapper GetClientMapper();
	    	
		public abstract ISessionMapper GetSessionMapper();
	    	
		public abstract IDistributeurMapper GetDistributeurMapper();
	    	
		public abstract IPaiementCarteCréditMapper GetPaiementCarteCréditMapper();
	    	
		public abstract IPaiementEnCompteMapper GetPaiementEnCompteMapper();
	    	
		public abstract IBandeAnnonceMapper GetBandeAnnonceMapper();
	    	
		public abstract ICompteMapper GetCompteMapper();
	    	
		public abstract ITransactionMapper GetTransactionMapper();
	    	
		public abstract IPaiementMapper GetPaiementMapper();
	    	
		public abstract IAdministrateurMapper GetAdministrateurMapper();
	    	
		public abstract IFilmMapper GetFilmMapper();
	    	
		public abstract IMembreMapper GetMembreMapper();
	    	
		public abstract IVisiteurMapper GetVisiteurMapper();
	    	
		public abstract IRéalisateurMapper GetRéalisateurMapper();
	    	
		public abstract ISessionCoteFilmMapper GetSessionCoteFilmMapper();
	      
        
        public static DataMapperFactory GetDataMapperFactory()
        {
            switch (GlobalConfig.getMapperType())
            {
                case MapperType.MEMORY:
                    return null;
                case MapperType.MSSQL:
                    return new MSSQL.MSSQLDataMapperFactory();
                case MapperType.MYSQL:
                    return null;
                case MapperType.ORACLE:
                    return null;
                case MapperType.FLAT_FILE:
                    return null;
                case MapperType.NONE:
                    return null;
                default:
                    return null;
            }

        }
    }
}

       