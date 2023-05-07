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
		public string Id { get; set; }
		public string Nome { get; set; }
		public Genero Genero { get; set; }
		public DateTime DataNascimento { get; set; }
		public int Idade { get; set; }
		public Cidade Cidade { get; set; }
	}
}
