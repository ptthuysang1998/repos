using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult StringModel()
        {
            ViewData.Model = "Hello world from Home-Index action";
            var view = new ViewResult();
            view.ViewName = "/Views/Home/StringModel.cshtml";
            view.ViewData = ViewData;
            return view;
        }

        public IActionResult TupleModel()
        {
            ViewData.Model = ("Donald", "Trump", new DateTime(1900, 12, 31));
            var view = new ViewResult();
            view.ViewData = ViewData;
            return view;
        }
    }
}