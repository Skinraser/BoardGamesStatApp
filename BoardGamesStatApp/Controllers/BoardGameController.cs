using BoardGamesStatApp.BLL.Dto;
using BoardGamesStatApp.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoardGamesStatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardGameController : ControllerBase
    {
        private IBoardGameService _boardGameService;

        public BoardGameController(IBoardGameService boardGameService)
        {
            _boardGameService = boardGameService;
        }

        [HttpPost]
        [Route("boardgame")]
        public async Task<IActionResult> AddBoardGame(BoardGameDto boardgame)
        {
            await _boardGameService.AddBoardGame(boardgame);
            return Ok();
        }
        [HttpGet]
        [Route("boardgame")]
        public async Task<IActionResult> GetBoardGameById(int id)
        {
            var boardGame = await _boardGameService.GetBoardGameById(id);
            return Ok(boardGame);
        }
        [HttpGet]
        [Route("boardgamelist")]
        public async Task<IActionResult> GetBoardGamesList()
        {
            var boardGamesList = await _boardGameService.GetBoardGamesList();
            return Ok(boardGamesList);
        }
        [HttpPut]
        [Route("boardgame")]
        public async Task<IActionResult> UpdateBoardGame(BoardGameDto boardgame)
        {
            await _boardGameService.UpdateBoardGame(boardgame);
            return Ok();
        }
        [HttpDelete]
        [Route("boardgame")]
        public async Task<IActionResult> DeleteBoardGame(int id)
        {
            await _boardGameService.DeleteBoardGameById(id);
            return Ok();
        }
    }
}