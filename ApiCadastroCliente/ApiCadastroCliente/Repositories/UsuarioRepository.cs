using ApiCadastroCliente.Data;
using ApiCadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiCadastroCliente.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private CadastroDbContext _context;
        public UsuarioRepository(CadastroDbContext context)
        {
            _context = context;
        }
        public UsuarioRepository()
        {

        }
        public Usuario GetAutenticacao(string Email, string Senha)
        {
            var result = _context.Usuarios.SingleOrDefault(user => user.Email == Email);
            return result;
        }

            public List<Usuario> GetUsuario()
        {
            return _context.Usuarios.Include(x => x.Perfil).ToList();
        }

        public Usuario GetUsuarioID(int ID)
        {
            return _context.Usuarios.Find(ID);
        }

        public void CreateUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void DeleteUsuarioByID(int ID)
        {
            var usuario = _context.Usuarios.Find(ID);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }
}
