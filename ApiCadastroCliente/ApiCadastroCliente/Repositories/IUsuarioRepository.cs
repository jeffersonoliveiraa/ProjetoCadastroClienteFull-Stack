using ApiCadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCadastroCliente.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario GetAutenticacao(string Email, string Senha);
        List<Usuario> GetUsuario();
        Usuario GetUsuarioID(int ID);
        void CreateUsuario(Usuario usuario);
        void DeleteUsuarioByID(int ID);
    }
}
