using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCadastroCliente.Models
{
    public class Perfil
    {
        public Perfil()
        {
            this.Usuarios = new List<Usuario>();
        }
        
        public int ID { get; set; }
        public string Descricao { set; get; }
        public string Nivel { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
