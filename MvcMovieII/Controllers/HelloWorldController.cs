﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovieII.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }



        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Buenasss {name},tu ID es: {ID}");
        }
    }
}
