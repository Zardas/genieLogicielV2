
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syst�meVisonnementFilmsEnLigne.DAL.MSSQL
{
    public class MSSQLDataMapperFactory : DataMapperFactory
    {
        public MSSQLDataMapperFactory()
        {
        }

        
		public override IRemboursementMapper GetRemboursementMapper()
        	{
            		return new RemboursementMapper();
        	}
	    
		public override IApprovisionnementMapper GetApprovisionnementMapper()
        	{
            		return new ApprovisionnementMapper();
        	}
	    
		public override IVisionnementMapper GetVisionnementMapper()
        	{
            		return new VisionnementMapper();
        	}
	    
		public override ICat�gorieMapper GetCat�gorieMapper()
        	{
            		return new Cat�gorieMapper();
        	}
	    
		public override IClientMapper GetClientMapper()
        	{
            		return new ClientMapper();
        	}
	    
		public override ISessionMapper GetSessionMapper()
        	{
            		return new SessionMapper();
        	}
	    
		public override IDistributeurMapper GetDistributeurMapper()
        	{
            		return new DistributeurMapper();
        	}
	    
		public override IPaiementCarteCr�ditMapper GetPaiementCarteCr�ditMapper()
        	{
            		return new PaiementCarteCr�ditMapper();
        	}
	    
		public override IPaiementEnCompteMapper GetPaiementEnCompteMapper()
        	{
            		return new PaiementEnCompteMapper();
        	}
	    
		public override IBandeAnnonceMapper GetBandeAnnonceMapper()
        	{
            		return new BandeAnnonceMapper();
        	}
	    
		public override ICompteMapper GetCompteMapper()
        	{
            		return new CompteMapper();
        	}
	    
		public override ITransactionMapper GetTransactionMapper()
        	{
            		return new TransactionMapper();
        	}
	    
		public override IPaiementMapper GetPaiementMapper()
        	{
            		return new PaiementMapper();
        	}
	    
		public override IAdministrateurMapper GetAdministrateurMapper()
        	{
            		return new AdministrateurMapper();
        	}
	    
		public override IFilmMapper GetFilmMapper()
        	{
            		return new FilmMapper();
        	}
	    
		public override IMembreMapper GetMembreMapper()
        	{
            		return new MembreMapper();
        	}
	    
		public override IVisiteurMapper GetVisiteurMapper()
        	{
            		return new VisiteurMapper();
        	}
	    
		public override IR�alisateurMapper GetR�alisateurMapper()
        	{
            		return new R�alisateurMapper();
        	}
	    
		public override ISessionCoteFilmMapper GetSessionCoteFilmMapper()
        	{
            		return new SessionCoteFilmMapper();
        	}
	   

    }
}
       