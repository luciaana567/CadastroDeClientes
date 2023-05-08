using CadastroDeClientes.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Persistence.Entities
{
    public class PessoaEntity: BaseEntity
    {
        public string Nome { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
    }
}
