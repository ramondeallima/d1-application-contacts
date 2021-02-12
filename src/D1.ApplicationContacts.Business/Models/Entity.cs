using System;
using System.Collections.Generic;
using System.Text;

namespace D1.CadastroClientes.Business.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
