using D1.CadastroClientes.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace D1.ApplicationContacts.Business.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public RedeSocial RedeSocial { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
