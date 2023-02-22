using HearSoundShop.Dal.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace HearSoundShop.Dal.Repositories
{
    public class DbRepository : IDbRepository
    {
        private readonly DataContext context;
        public DbRepository(DataContext context)
        {
            this.context = context;
        }
        public async Task<int> SaveChangeAsync()
        {
            return await context.SaveChangesAsync();
        }

        public async Task<Guid> Add<T>(T newEntity) where T : class, IEntity
        {
            var entity = await context.Set<T>().AddAsync(newEntity);
            return entity.Entity.Id;
        }

        public async Task Delete<T>(Guid id) where T : class, IEntity
        {
            var activeEntity = await context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            await Task.Run(() => context.Update(activeEntity)); 
        }

        public IQueryable<T> Get<T>(Expression<Func<T, bool>> selector) where T : class, IEntity
        {
            return context.Set<T>().Where(selector).AsQueryable();
        }

        public IQueryable<T> GetAll<T>() where T : class, IEntity
        {
           return context.Set<T>().AsQueryable();
        }

        Task IDbRepository.Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
