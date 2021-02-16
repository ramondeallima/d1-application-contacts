using D1.ApplicationContacts.Business.Enums;
using D1.CadastroClientes.Business.Models;
using System;

namespace D1.ApplicationContacts.Business.Models
{
    public class Telefone : Entity
    {
        public Guid ClienteId { get; set; }
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; }

        /* Relações */
        public Cliente Cliente { get; set; }
    }
}