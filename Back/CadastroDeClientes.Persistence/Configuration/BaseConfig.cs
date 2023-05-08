using CadastroDeClientes.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CadastroDeClientes.Persistence.Configuration
{
    public abstract class BaseConfig<TType> : IEntityTypeConfiguration<TType> where TType : BaseEntity
    {
        public BaseConfig(string tableName)
            => TableName = tableName;

        public string TableName { get; }

        public virtual void Configure(EntityTypeBuilder<TType> builder)
        {
            builder.ToTable(TableName);
            
            builder.HasKey(obj => obj.Id);
        }
    }
}
