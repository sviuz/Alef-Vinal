using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTaskToALEF.DataModels;
using TestTaskToALEF.Models;
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

        public async Task<IActionResult> Index()
        {
            dynamic data = new ExpandoObject();
            data.Models = await _modelService.GetModelsAsync();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Model model)
        {
            await _modelService.AddModelAsync(model);
            return Redirect("/Home/Index");
        }

        [HttpPut("Id")]
        public async Task<IActionResult> Index(int id)
        {
            var data = await _modelService.GetModelAsync(id);
            await _modelService.EditModelAsync(data);
            return Redirect("/Home/Index");
        }
    }
}
