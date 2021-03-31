using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp.Entities
{
    public static class Parameters
    {
        public static string connectionString { get => ConfigurationManager.ConnectionStrings["appDatabase"].ConnectionString; }

    }
}
