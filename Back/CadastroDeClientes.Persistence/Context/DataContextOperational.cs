using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CadastroDeClientes.Domain.Interfaces.Persistence;
using CadastroDeClientes.Persistence.Seed;

namespace CadastroDeClientes.Persistence.Context
{
    public class DataContextOperational : BaseDataContext<DataContextOperational>, IDataContext
    {
        public DataContextOperational() { }
        public DataContextOperational(DbContextOptions<DataContextOperational> options) : base(options) { }

        public override void CallSeeds(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedModel();
        }

        public override IList<TypeInfo> GetAllConfigs()
            => Assembly.GetExecutingAssembly().DefinedTypes
                .Where(t => t.ImplementedInterfaces.Any(i => i.Name == typeof(IDataContextOperationalConfiguration).Name))
                .Where(i => i.IsClass && !i.IsAbstract && !i.IsNested)
                .ToList();

        public override void ConfigureManualEntities(ModelBuilder modelBuilder)
        {
        }
    }
}
