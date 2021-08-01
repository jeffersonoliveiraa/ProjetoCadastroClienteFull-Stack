using ApiCadastroCliente.Data;
using ApiCadastroCliente.Models;
using ApiCadastroCliente.Repositories;
using ApiCadastroCliente.Services;
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
    [Route("usuario")]
    public class UsuarioController : Controller
    {
        public IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] AtenticacaoViewModel usuario)
        {

            var usuarios = _usuarioRepository.GetAutenticacao(usuario.Email, usuario.Senha);

            if (usuarios == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(usuarios);
            usuario.Senha = "";
            return new
            {
                user = usuario,
                token = token
            };
        }

        [HttpGet]
        [Authorize(Roles = "1")]
        public List<Usuario> GetUsuarios()
        {
            try
            {
                var result = _usuarioRepository.GetUsuario();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpGet("ID")]
        //[Route("id")]
        [Authorize(Roles = "1,2")]
        public ActionResult GetUsuarioID(int ID)
        {
            try
            {
                var usuario = _usuarioRepository.GetUsuarioID(ID);
                if (usuario.ID == ID)
                {
                    return Ok(usuario);
                }
                else
                {
                    return Unauthorized("Perfil de cliente pode ver somente seu cadastro");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Authorize(Roles = "1")]
        public void CreateUsuario(UsuarioViewModel usuario)
        {
            Usuario _usuario = new Usuario();
            _usuario.Nome = usuario.Nome;
            _usuario.Email = usuario.Email;
            _usuario.DataCria = usuario.DataCria;
            _usuario.Senha = usuario.Senha;
            _usuario.IDPerfil = usuario.IDPerfil;

            try
            {
                _usuarioRepository.CreateUsuario(_usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("ID")]
        [Authorize(Roles = "1")]
        public void DeleteUID(int ID)
        {
            try
            {
                _usuarioRepository.DeleteUsuarioByID(ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
