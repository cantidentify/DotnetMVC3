using System.Collections.Generic;
using System.Web.Mvc;

namespace DotnetMVC3.Models
{
    public class HomeViewModel
    {
        public List<CategoryModel> categoryList { get; set; }
        public List<GameModel> gameList { get; set; }
        public List<SelectListItem> dropDownCat { get; set; }
        public List<SelectListItem> dropDownGame { get; set; }
        public string dropDownCatName { get; set; }
        public string dropDownGameName { get; set; }
        public List<GameModel> selectedGame { get; set; }
    }
}