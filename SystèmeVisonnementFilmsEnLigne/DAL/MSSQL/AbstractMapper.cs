
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmeVisonnementFilmsEnLigne.Logique;

namespace SystèmeVisonnementFilmsEnLigne.DAL.MSSQL
{
    public abstract class AbstractMapper
    {
        private Dictionary<Guid, DomainObject> lLoadedMap = new Dictionary<Guid, DomainObject>();

        public AbstractMapper() { }

        protected DomainObject AbstractFind(Guid pID)
        {
            if (lLoadedMap.ContainsKey(pID))
            {
                return lLoadedMap[pID];
            }
            return null;
        }

        protected Dictionary<Guid, DomainObject> LoadedMap
        {
            get { return lLoadedMap; }
            set { lLoadedMap = value; }
        }

    }
}

       