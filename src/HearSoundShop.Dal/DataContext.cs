using HearSoundShop.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace HearSoundShop.Dal
{
    public class DataContext : DbContext
    {
        public DbSet<HeadPhoneEntity> HeadPhones { get; set; }
        public DbSet<PlayerEntity> Players { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        public DbSet<T> DbSet<T>() where T : class
        { 
            return Set<T>();
        }

        public new IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }

    }
}
