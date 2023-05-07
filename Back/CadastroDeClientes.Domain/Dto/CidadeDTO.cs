using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Domain.Dto
{
    public class CidadeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public EstadoDTO Estado { get; set; }
    }
}
