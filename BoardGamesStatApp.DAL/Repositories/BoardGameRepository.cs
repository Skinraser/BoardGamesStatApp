using BoardGamesStatApp.DAL.Entity;
using BoardGamesStatApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.DAL.Repositories
{
    public class BoardGameRepository : Repository<BoardGame, int>, IBoardGameRepository
    {
        public BoardGameRepository(BoardGameDB context) : base(context)
        {

        }
    }
}
