using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Configuration;

namespace PrintLabel.App.Database
{
    public static class AppConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["UMCVN_BASEEntities"].ConnectionString;
    }
}
