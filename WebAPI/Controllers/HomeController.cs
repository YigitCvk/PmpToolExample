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
    public class HomeController : ControllerBase
    {
        IProjectService _projectService;
        IProjectLeaderService _projectLeaderService;
        IProjectPersonService _projectPersonService;

        public HomeController(IProjectService projectService, IProjectLeaderService projectLeaderService, IProjectPersonService projectPersonService)
        {
            _projectService = projectService;
            _projectLeaderService = projectLeaderService;
            _projectPersonService = projectPersonService;
        }

      [HttpGet("GetHomeProjectDetailList")]
      public string GetHomeProjectDetailList(HomeViewModel homeViewModel)
        {
            HomeViewModel hvm = new HomeViewModel() 
            {
            Project=_projectService.GetAll().Data,
            ProjectLeader=_projectLeaderService.GetAll().Data,
            ProjectPerson=_projectPersonService.GetAll().Data

            };
            return JsonConvert.SerializeObject(hvm);
        }

        //[HttpGet("getbypersonid")]
        //public JsonResult GetByPersonId(int personId)
        //{
        //    HomeViewModel hvm = new HomeViewModel()
        //    {
        //        Project = _projectService.GetById().Data
        //    };
        //}

    }
}
