using CadastroDeClientes.Domain.Interfaces.Persistence;
using CadastroDeClientes.Persistence.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Persistence.Configuration.Operational
{
    public class PessoaConfig : BaseConfig<PessoaEntity>, IDataContextOperationalConfiguration
    {
        public PessoaConfig() : base("Pessoa") { }

        public override void Configure(EntityTypeBuilder<PessoaEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Genero).IsRequired();
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.Property(x => x.Idade).IsRequired();
        }
    }
}
