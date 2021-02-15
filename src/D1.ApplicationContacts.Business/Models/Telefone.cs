using D1.ApplicationContacts.Business.Enums;
using D1.CadastroClientes.Business.Models;

namespace D1.ApplicationContacts.Business.Models
{
    public class Telefone : Entity
    {
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
    }
}