using Tracking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tracking.Domain.Interfaces.Repository
{
    public interface IRepository<TDtoType> where TDtoType : BaseDTO
    {
        object EntityType { get; }

        IQueryable<TDtoType> List(bool withUserFilter = true);

        TDtoType Get(Guid id, bool includes = false);
        Task<TDtoType> GetAsync(Guid id, bool includes = false);

        IEnumerable<TDtoType> Get(Guid[] id);

        bool Exists(Guid obj);

        bool Exists(TDtoType obj);

        void Disable(Guid id);

        void Delete(Guid id);

        void Delete(Guid[] id);
        Task<TDtoType> SaveAsync(TDtoType obj);
        TDtoType Save(TDtoType obj);

        TDtoType[] Save(TDtoType[] obj);

        TDtoType[] InsertFast(TDtoType[] lista);

        IEnumerable<TDtoType> UpdateManyReturningObject(List<TDtoType> lista);
    }
}