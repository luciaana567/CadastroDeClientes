using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeClientes.Domain.Enum;

namespace CadastroDeClientes.Domain.Dto
{
    public class ClienteDTO
    {
		public string Id { get; set; }
		public PessoaDTO Pessoa { get; set; }
		public CidadeDTO Cidade { get; set; }
	}
}
