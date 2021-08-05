using ApiCadastroCliente.Models;
using ApiCadastroCliente.Repositories;
using ApiCadastroCliente.ViewModel;
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
        [AllowAnonymous]
        //[Authorize(Roles = "1")] //Comentado para o front-end enviar informações sem precisar autenticação.
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
        //[Authorize(Roles = "1")]
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
        //[Authorize(Roles = "1")] //Comentado para o front-end enviar informações sem precisar autenticação.

        public void CreateCliente(ClienteViewModel cliente)
        {
            Cliente _cliente = new Cliente();
            _cliente.Nome = cliente.Nome;
            _cliente.Email = cliente.Email;
            _cliente.Logradouro = cliente.Logradouro;
            _cliente.NumeroRes = cliente.NumeroRes;
            _cliente.Complemento = cliente.Complemento;
            _cliente.Cep = cliente.Cep;
            _cliente.Bairro = cliente.Bairro;
            _cliente.Cidade = cliente.Cidade;
            _cliente.Estado = cliente.Estado;
            try
            {
                _clienteRepository.CreateCliente(_cliente);
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
