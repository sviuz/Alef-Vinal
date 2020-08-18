using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTaskToALEF.Services;

namespace TestTaskToALEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly IModelService _modelService;

        public HomeController(IModelService modelService)
        {
            _modelService = modelService;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
