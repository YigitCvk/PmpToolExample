using Business.Abstract;
using Entities.Concrete;
using Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        IBoardService _boardService;
        IBoardTaskService _boardTaskService;

        public BoardsController(IBoardService boardService, IBoardTaskService boardTaskService)
        {
            _boardService = boardService;
            _boardTaskService = boardTaskService;
        }
        [HttpGet("getall")]
        public string GetAll(BoardViewModel bvm)
        {
            BoardViewModel xyz = new BoardViewModel()
            {
                Board = _boardService.GetAll().Data,
                BoardTask=_boardTaskService.GetAll().Data

            };
            return JsonConvert.SerializeObject(xyz);
        }

        [HttpPost("boardAdd")]
        public IActionResult GetBoardAdd(Board board)
        {
            var result = _boardService.Add(board);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("boardDelete")]
        public IActionResult GetBoardDelete(Board board)
        {
            var result = _boardService.Delete(board);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("boardUpdate")]
        public IActionResult GetBoardUpdate(Board board)
        {
            var result = _boardService.Update(board);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("boardTaskAdd")]
        public IActionResult GetBoardTaskAdd(BoardTask boardTask)
        {
            var result = _boardTaskService.Add(boardTask);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("boardTaskDelete")]
        public IActionResult GetBoardTaskDelete(BoardTask boardTask)
        {
            var result = _boardTaskService.Delete(boardTask);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("boardTaskUpdate")]
        public IActionResult GetBoardTaskUpdate(BoardTask boardTask)
        {
            var result = _boardTaskService.Update(boardTask);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
