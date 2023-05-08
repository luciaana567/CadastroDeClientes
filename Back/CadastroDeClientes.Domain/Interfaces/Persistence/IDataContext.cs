using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Threading.Tasks;

namespace CadastroDeClientes.Domain.Interfaces.Persistence
{
    public interface IDataContext
    {
        DatabaseFacade Database { get; }
        IModel Model { get; }
        EntityEntry Entry(object entity);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken = default);
        void Clear();
    }
}
