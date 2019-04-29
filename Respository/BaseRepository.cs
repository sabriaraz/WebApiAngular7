using Microsoft.EntityFrameworkCore;
using PersonelProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.Respository
{
    public class BaseRepository<T> : IBaseRespository<T> where T : class
    {
        private readonly PersonelContext _db;
        public BaseRepository(PersonelContext db)
        {
            _db = db;
        }

        public void Add(T Entity)
        {
            _db.Entry(Entity).State = EntityState.Added;
        }

        public async Task<bool> Commit()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public void Delete(T Entity)
        {
            _db.Entry(Entity).State = EntityState.Deleted;
        }

        public async Task<T> Find(int Id)
        {
            return await Set().FindAsync(Id);
        }

        public async Task<List<T>> ListAll()
        {
            return await Set().ToListAsync();
        }

        public void Update(T Entitiy)
        {
            _db.Entry(Entitiy).State = EntityState.Modified;
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }
    }
}
