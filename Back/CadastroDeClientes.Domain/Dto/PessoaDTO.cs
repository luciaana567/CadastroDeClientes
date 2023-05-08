using CadastroDeClientes.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Domain.Dto
{
    public class PessoaDTO
	{
		public string Id { get; set; }
		public string Nome { get; set; }
		public Genero Genero { get; set; }
		public DateTime DataNascimento { get; set; }
		public int Idade { get; set; }		
	}
}
