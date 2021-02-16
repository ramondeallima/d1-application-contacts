using D1.ApplicationContacts.Business.Enums;
using D1.CadastroClientes.Business.Models;
using System;

namespace D1.ApplicationContacts.Business.Models
{
    public class RedeSocial : Entity
    {
        public Guid ClienteId { get; set; }

        public string Link { get; set; }
        public TipoRedeSocial TipoRedeSocial { get; set; }

        /* Relações */
        public Cliente Cliente { get; set; }
    }
}