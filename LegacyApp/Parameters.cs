using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    public static class Parameters
    {
        public static string connectionString { get => System.Configuration.ConfigurationManager.ConnectionStrings["appDatabase"].ConnectionString; }

    }
}
