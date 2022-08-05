using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.DAL.Interfaces
{
    public interface IRepository<T, TKey>
       where T : class
    {
        Task<IEnumerable<T>> ListItemsAsync();
        Task<T> GetItemAsync(TKey id);
        Task CreateAsync(T item);
        void Delete(T item);
        Task DeleteByIdAsync(TKey id);
        void Update(T model);
        Task SaveAsync();
    }

}
