using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.Respository
{
   public interface IBaseRespository<T> where T: class
    {
        DbSet<T> Set();
        void Add(T Entity);
        void Delete(T Entity);
        void Update(T Entitiy);
        Task<bool>  Commit();
        Task<T> Find(int Id);
        Task<List<T>> ListAll();
    }
}
