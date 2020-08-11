using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Data
{
    public class SqlConfiguration
    {
        public SqlConfiguration(string connnectionString) => ConnectionString = connnectionString;
        public string ConnectionString { get; }
    }
}
