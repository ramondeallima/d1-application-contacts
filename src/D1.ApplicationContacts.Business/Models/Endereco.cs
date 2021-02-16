using D1.ApplicationContacts.Business.Enums;
using D1.CadastroClientes.Business.Models;
using System;

namespace D1.ApplicationContacts.Business.Models
{
    public class Endereco : Entity
    {
        public Guid ClienteId { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public TipoEndereco TipoEndereco { get; set; }

        /* Relações */
        public Cliente Cliente { get; set; }
    }
}