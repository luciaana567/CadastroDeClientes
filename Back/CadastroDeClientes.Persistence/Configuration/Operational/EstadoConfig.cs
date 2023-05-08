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
    public class EstadoConfig : BaseConfig<EstadoEntity>, IDataContextOperationalConfiguration
    {
        public EstadoConfig(): base("Estado") { }

        public override void Configure(EntityTypeBuilder<EstadoEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Sigla).HasMaxLength(2);
        }
    }
}
