using D1.ApplicationContacts.Business.Enums;
using D1.CadastroClientes.Business.Models;

namespace D1.ApplicationContacts.Business.Models
{
    public class RedeSocial : Entity
    {
        public string Link { get; set; }
        public TipoRedeSocial TipoRedeSocial { get; set; }
    }
}