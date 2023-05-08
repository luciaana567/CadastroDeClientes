using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace CadastroDeClientes.Persistence.Context
{
    public abstract class BaseDataContext<TContext> : DbContext
        where TContext : DbContext
    {
        public BaseDataContext()
        {

        }

        public BaseDataContext(DbContextOptions<TContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureManualEntities(modelBuilder);
            ConfigureAllEntityTypes(modelBuilder);

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            CallSeeds(modelBuilder);
        }

        public void Clear()
        {
            var changedEntries = ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Detached)
                .ToList();

            foreach (var entry in changedEntries)
                entry.State = EntityState.Detached;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (Debugger.IsAttached)
                optionsBuilder.EnableSensitiveDataLogging();
        }


        public virtual void ConfigureAllEntityTypes(ModelBuilder modelBuilder)
        {
            var applyConfigMethod = typeof(ModelBuilder).GetMethods().Where(e => e.Name == "ApplyConfiguration" && e.GetParameters().Single().ParameterType.Name == typeof(IEntityTypeConfiguration<>).Name).Single();
            var configs = GetAllConfigs();

            foreach (var item in configs)
            {
                var entityType = item.ImplementedInterfaces.First(x => x.Name == typeof(IEntityTypeConfiguration<>).Name).GenericTypeArguments.Single();
                var applyConfigGenericMethod = applyConfigMethod.MakeGenericMethod(entityType);
                applyConfigGenericMethod.Invoke(modelBuilder, new object[] { Activator.CreateInstance(item) });
            }
        }

        public abstract IList<TypeInfo> GetAllConfigs();
        public abstract void CallSeeds(ModelBuilder modelBuilder);
        public abstract void ConfigureManualEntities(ModelBuilder modelBuilder);
    }
}
