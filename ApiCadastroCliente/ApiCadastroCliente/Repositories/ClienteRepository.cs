using ApiCadastroCliente.Data;
using ApiCadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiCadastroCliente.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private CadastroDbContext _context;
        public ClienteRepository(CadastroDbContext context)
        {
            _context = context;
        }
        public ClienteRepository()
        {

        }
        public List<Cliente> GetClientes()
        {
            return _context.Clientes.ToList();
        }

        public Cliente GetClienteID(int iD)
        {
            return _context.Clientes.Find(iD);
        }

        public void CreateCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void DeleteClienteByID(int iD)
        {
            var cliente = _context.Clientes.Find(iD);
            _context.Clientes.Remove(cliente);

            _context.SaveChanges();
        }
    }
}
