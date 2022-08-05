using AutoMapper;
using BoardGamesStatApp.BLL.Dto;
using BoardGamesStatApp.BLL.Interfaces;
using BoardGamesStatApp.DAL.Entity;
using BoardGamesStatApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.BLL.Services
{
    public class BoardGameService : IBoardGameService
    {
        private readonly IUnitOfWork _database;
        private IMapper _mapper;
        public BoardGameService(IUnitOfWork database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }
        public async Task AddBoardGame(BoardGameDto boardgame)
        {
            await _database.BoardGameRepository.CreateAsync(_mapper.Map<BoardGame>(boardgame));
            await _database.SaveAsync();
        }
        public async Task<BoardGameDto> GetBoardGameById(int id)
        {
            var boardGame = await _database.BoardGameRepository.GetItemAsync(id);
            var boardGameDto = _mapper.Map<BoardGameDto>(boardGame);

            return boardGameDto;
        }
        public async Task<IEnumerable<BoardGameDto>> GetBoardGamesList()
        {
            var boardGameList = await _database.BoardGameRepository.ListItemsAsync();
            var boardGameListDto = _mapper.Map<IEnumerable<BoardGameDto>>(boardGameList);

            return boardGameListDto;
        }

        public async Task DeleteBoardGameById(int id)
        {
            var boardGame = await _database.BoardGameRepository.GetItemAsync(id);
            await _database.BoardGameRepository.DeleteByIdAsync(id);
            await _database.SaveAsync();
        }

        public async Task UpdateBoardGame(BoardGameDto boardGame)
        {
            var boardGameToUpdate = _mapper.Map<BoardGame>(boardGame);
            _database.BoardGameRepository.Update(boardGameToUpdate);
            await _database.SaveAsync();
        }

    }
}
