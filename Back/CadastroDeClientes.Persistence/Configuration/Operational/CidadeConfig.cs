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
    public class CidadeConfig : BaseConfig<CidadeEntity>, IDataContextOperationalConfiguration
    {
        public CidadeConfig() : base("Cidade") { }

        public override void Configure(EntityTypeBuilder<CidadeEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).IsRequired();
            builder.HasOne(e => e.Estado)
              .WithMany(e => e.Cidades)
            .HasForeignKey(e => e.EstadoId);
        }
    }
}
