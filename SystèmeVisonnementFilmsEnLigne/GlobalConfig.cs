
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syst�meVisonnementFilmsEnLigne.DAL;
namespace Syst�meVisonnementFilmsEnLigne
{
    public static class GlobalConfig
    {

        public static string getConnectionString()
        {
            return "Data Source=.;Initial Catalog=Syst�meVisonnementFilmsEnLigneDB;Trusted_Connection=Yes";
        }

        public static MapperType getMapperType()
        {
            return MapperType.MSSQL;
        }
    }
}

       