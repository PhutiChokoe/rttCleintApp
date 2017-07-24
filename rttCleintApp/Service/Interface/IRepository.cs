using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IRepository
    {
        DataTable CreateDataTable(string selectCommand);
        void SqlInsert(string table, IDictionary<string, string> parameterMap);
    }
}
