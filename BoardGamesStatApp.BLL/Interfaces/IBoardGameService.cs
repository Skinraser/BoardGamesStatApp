using BoardGamesStatApp.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.BLL.Interfaces
{
    public interface IBoardGameService
    {
        Task AddBoardGame(BoardGameDto boardgame);
        Task<BoardGameDto> GetBoardGameById(int id);
        Task<IEnumerable<BoardGameDto>> GetBoardGamesList();
        Task DeleteBoardGameById(int id);
        Task UpdateBoardGame(BoardGameDto boardgame);
    }
}
