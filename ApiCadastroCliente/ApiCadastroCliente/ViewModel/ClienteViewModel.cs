using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCadastroCliente.ViewModel
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string NumeroRes { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
