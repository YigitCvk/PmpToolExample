using Business.Abstract;
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
    public class BoardsController : Controller
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
    }
}
