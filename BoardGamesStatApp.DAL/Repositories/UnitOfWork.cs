using BoardGamesStatApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BoardGameDB _context;
        private IBoardGameRepository _boardGameRepository;
        private bool disposedValue;

        //  Add repositories

        public UnitOfWork(BoardGameDB context)
        {
            _context = context;
        }

        public IBoardGameRepository BoardGameRepository
        {
            get
            {
                if (_boardGameRepository == null)
                {
                    _boardGameRepository = new BoardGameRepository(_context);
                }
                return _boardGameRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }

}
