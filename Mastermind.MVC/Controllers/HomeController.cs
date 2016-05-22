using Mastermind.Application.DTO;
using Mastermind.Application.Interfaces;
using Mastermind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mastermind.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameAppService _gameAppService;

        public HomeController(IGameAppService gameAppService)
        {
            _gameAppService = gameAppService;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public JsonResult NewGameSinglePlayer()
        {
            var result = _gameAppService.CreateSinglePlayer();

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult NewGameMultiPlayer(int[] positions)
        {
            var result = _gameAppService.CreateMultiPlayer(positions);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SendCode(GameDTO game)
        {
            int[] positions = new int[8];
            positions[0] = game.Position1;
            positions[1] = game.Position2;
            positions[2] = game.Position3;
            positions[3] = game.Position4;
            positions[4] = game.Position5;
            positions[5] = game.Position6;
            positions[6] = game.Position7;
            positions[7] = game.Position8;

            int result = _gameAppService.SendAttempt(game.GameId, positions);

           

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
