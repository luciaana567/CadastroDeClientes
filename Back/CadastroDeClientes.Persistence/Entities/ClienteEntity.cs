using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Persistence.Entities
{
    public class ClienteEntity: BaseEntity
    {
        public Guid PessoaId { get; set; }
        public Guid CidadeId { get; set; }
        public virtual PessoaEntity Pessoa { get; set; }
        public virtual CidadeEntity Cidade { get; set; }
    }
}
