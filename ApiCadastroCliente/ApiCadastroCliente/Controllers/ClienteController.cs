using ApiCadastroCliente.Models;
using ApiCadastroCliente.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCadastroCliente.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ClienteController : ControllerBase
    {
        public IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        [Authorize(Roles = "1")]
        public List<Cliente> GetClientes()
        {
            try
            {
                return _clienteRepository.GetClientes();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("ID")]
        [Authorize(Roles = "1")]
        public Cliente GetClienteID(int ID)
        {
            try
            {
                return _clienteRepository.GetClienteID(ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPut]
        [Authorize(Roles = "1")]
        public void CreateCliente(Cliente cliente)
        {
            try
            {
                 _clienteRepository.CreateCliente(cliente);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("ID")]
        [Authorize(Roles = "1")]
        public void DeleteClienteByID(int ID)
        {
            try
            {
                 _clienteRepository.DeleteClienteByID(ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
