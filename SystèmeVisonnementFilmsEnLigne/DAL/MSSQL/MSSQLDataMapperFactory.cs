
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
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
	    
		public override ICatégorieMapper GetCatégorieMapper()
        	{
            		return new CatégorieMapper();
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
	    
		public override IPaiementCarteCréditMapper GetPaiementCarteCréditMapper()
        	{
            		return new PaiementCarteCréditMapper();
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
	    
		public override IRéalisateurMapper GetRéalisateurMapper()
        	{
            		return new RéalisateurMapper();
        	}
	    
		public override ISessionCoteFilmMapper GetSessionCoteFilmMapper()
        	{
            		return new SessionCoteFilmMapper();
        	}
	   

    }
}
       