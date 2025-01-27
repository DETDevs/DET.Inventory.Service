using DET.Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DET.Inventory.BusinessLogic.Interfaces
{
    public interface IProductos
    {
        Task<List<Productos>> ListarProductos();
    }
}
