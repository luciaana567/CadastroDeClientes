using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeClientes.Domain.Enum;


namespace CadastroDeClientes.Domain.Models
{
	public class Cliente
	{
		public int Id { get; set; }
		public Pessoa Pessoa { get; set; }
		public Cidade Cidade { get; set; }
	}
}
