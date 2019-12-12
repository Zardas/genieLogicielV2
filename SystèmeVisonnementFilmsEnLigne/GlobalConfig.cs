
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmeVisonnementFilmsEnLigne.DAL;
namespace SystèmeVisonnementFilmsEnLigne
{
    public static class GlobalConfig
    {

        public static string getConnectionString()
        {
            return "Data Source=.;Initial Catalog=SystèmeVisonnementFilmsEnLigneDB;Trusted_Connection=Yes";
        }

        public static MapperType getMapperType()
        {
            return MapperType.MSSQL;
        }
    }
}

       