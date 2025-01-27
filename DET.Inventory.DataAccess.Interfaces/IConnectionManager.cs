using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DET.Inventory.DataAccess.Interfaces
{
    public interface IConnectionManager
    {
        IDbConnection GetConnection(string key);
    }
}
