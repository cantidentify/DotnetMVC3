using System.Collections.Generic;
using System.Web.Mvc;
namespace DotnetMVC3.Models
{
    public class CategoryModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
    public class CategoryViewModel
    {
        public List<CategoryModel> categoryList { get; set; }
        public List<SelectListItem> dropdownCat { get; set; } 
        public string dropDownName { get; set; }
    }
}