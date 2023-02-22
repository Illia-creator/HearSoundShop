using HearSoundShop.Dal.Entities.Abstracts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;

namespace HearSoundShop.Dal.Repositories
{
    public interface IDbRepository
    {
        IQueryable<T> Get<T>(Expression<Func<T, bool>> selector) where T : class, IEntity;
        IQueryable<T> GetAll<T>() where T : class, IEntity;

        Task<Guid> Add<T>(T newEntity) where T : class, IEntity;

        Task Update<T>(T entity) where T : class, IEntity;
        Task Delete<T>(Guid id) where T : class, IEntity;

        Task<int> SaveChangeAsync();
    }
}
