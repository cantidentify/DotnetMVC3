using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotnetMVC3.Models;

namespace DotnetMVC3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            HomeViewModel homeView = new HomeViewModel();
            if(homeView.categoryList == null)
            {
                homeView.categoryList = new List<CategoryModel>()
                {
                    new CategoryModel () { CategoryID  = 1 , CategoryName = "john" },
                    new CategoryModel () { CategoryID  = 2 , CategoryName = "jame"},
                    new CategoryModel () { CategoryID  = 3 , CategoryName = "jasmin"},
                    new CategoryModel () { CategoryID  = 4 , CategoryName = "joe"}
                };
            }
            if (homeView.gameList == null)
            {
                homeView.gameList = new List<GameModel>()
                {
                    new GameModel () { GameID = 1 , GameName = "A" , GamePrice = 100 , GameSaleDate = "2021-06-10", CategoryID = 1},
                    new GameModel () { GameID = 2 , GameName = "B" , GamePrice = 250 , GameSaleDate = "2020-03-19", CategoryID = 2},
                    new GameModel () { GameID = 3 , GameName = "C" , GamePrice = 360 , GameSaleDate = "2019-11-11", CategoryID = 3},
                };
            }

            homeView.dropDownCat = new List<SelectListItem>();

            foreach (CategoryModel cat in homeView.categoryList)
            {
                SelectListItem objItmC = new SelectListItem();
                objItmC.Text = cat.CategoryName;
                objItmC.Value = cat.CategoryID.ToString();
                homeView.dropDownCat.Add(objItmC);
            }

            homeView.dropDownGame = new List<SelectListItem>();

            foreach (GameModel game in homeView.gameList)
            {
                SelectListItem objItmC = new SelectListItem();
                objItmC.Text = game.GameName;
                objItmC.Value = game.GameID.ToString();
                homeView.dropDownGame.Add(objItmC);
            }

            homeView.dropDownCatName= "0";

            homeView.dropDownGameName = "0";

            return View(homeView);
        }

        [HttpPost]
        public JsonResult CategorySelect(int ID)
        {
            IList<GameModel> gameList = new List<GameModel>()
            {
                new GameModel () { GameID = 1 , GameName = "A" , GamePrice = 100 , GameSaleDate = "2021-06-10", CategoryID = 1},
                new GameModel () { GameID = 1 , GameName = "AC" , GamePrice = 100 , GameSaleDate = "2021-06-10", CategoryID = 1},
                new GameModel () { GameID = 1 , GameName = "AB" , GamePrice = 100 , GameSaleDate = "2021-06-10", CategoryID = 1},
                new GameModel () { GameID = 2 , GameName = "B" , GamePrice = 250 , GameSaleDate = "2020-03-19", CategoryID = 2},
                new GameModel () { GameID = 3 , GameName = "C" , GamePrice = 360 , GameSaleDate = "2019-11-11", CategoryID = 3},
            };

            var selectedGame = (from game in gameList
                                            where game.CategoryID == ID
                                            select game).ToList();
            return this.Json(new { success = "true", package = selectedGame});
        }


    }
}