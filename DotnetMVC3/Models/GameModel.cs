using System.Collections.Generic;
using System.Web.Mvc;


namespace DotnetMVC3.Models
{
    public class GameModel
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public string GameSaleDate { get; set; }
        public int CategoryID { get; set; }
    }

    public class GameViewModel
    {
        public List<GameModel> gameList { get; set; }
        public List<SelectListItem> dropDownGame { get; set; }
        public string dropDownName { get; set; }

    }
}