using HoboConsolePrjct.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Data
{
    public interface IBaseRepository<T> where T : IEntity
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        bool Save();
        bool Load();
        Task<bool> SaveAsync();
        Task<bool> LoadAsync();
    }
}
