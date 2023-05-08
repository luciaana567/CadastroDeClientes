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
    public class ClienteConfig : BaseConfig<ClienteEntity>, IDataContextOperationalConfiguration
    {
        public ClienteConfig() : base("Cliente") { }

        public override void Configure(EntityTypeBuilder<ClienteEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.PessoaId).IsRequired();
            builder.Property(x => x.CidadeId).IsRequired();


            builder.HasOne(e => e.Cidade)
              .WithMany(e => e.Clientes)
            .HasForeignKey(e => e.CidadeId);
        }
    }
}
