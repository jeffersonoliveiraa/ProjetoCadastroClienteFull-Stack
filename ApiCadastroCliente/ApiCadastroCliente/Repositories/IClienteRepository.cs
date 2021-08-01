using ApiCadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCadastroCliente.Repositories
{
    public interface IClienteRepository
    {
        List<Cliente> GetClientes();
        Cliente GetClienteID(int ID);
        void CreateCliente(Cliente cliente);
        void DeleteClienteByID(int ID);
    }
}
