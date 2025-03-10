﻿using DET.Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DET.Inventory.DataAccess.Interfaces
{
    public interface ICliente
    {
        Task<List<Cliente>> ListarClientes(Cliente cliente);
        Task<Cliente> GuradarCliente(Cliente cliente);
    }
}
