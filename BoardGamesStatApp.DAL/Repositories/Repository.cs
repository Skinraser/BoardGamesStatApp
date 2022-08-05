using BoardGamesStatApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.DAL.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class
    {
        public readonly BoardGameDB _context;

        public Repository(BoardGameDB context)
        {
            _context = context;
        }

        public virtual async Task CreateAsync(TEntity item)
        {
            await _context.Set<TEntity>().AddAsync(item);
        }

        public virtual async Task<TEntity> GetItemAsync(TKey id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual void Delete(TEntity item)
        {
            _context.Set<TEntity>().Remove(item);
        }

        public virtual async Task DeleteByIdAsync(TKey id)
        {
            Delete(await GetItemAsync(id));
        }

        public virtual async Task<IEnumerable<TEntity>> ListItemsAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public virtual void Update(TEntity model)
        {
            _context.Set<TEntity>().Attach(model);
            _context.Entry(model).State = EntityState.Modified;
        }
    }

}
