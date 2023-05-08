using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Persistence.Entities
{
    public class EstadoEntity: BaseEntity
    {
        public string Nome{ get; set; }
        public string Sigla { get; set; }
        public virtual ICollection<CidadeEntity> Cidades { get; set; }
    }
}
