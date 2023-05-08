using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Persistence.Entities
{
    public class CidadeEntity: BaseEntity
    {
        public string Nome { get; set; }
        public Guid EstadoId { get; set; }
        public virtual EstadoEntity Estado { get; set; }
        public virtual ICollection<ClienteEntity> Clientes { get; set; }
    }
}
