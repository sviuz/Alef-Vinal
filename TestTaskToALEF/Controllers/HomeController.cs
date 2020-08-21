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
            var models = await _modelService.GetModelsAsync();
            return View(models);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Model model)
        {
            await _modelService.AddModelAsync(model);
            return Redirect("~/Home/Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ModelData model)
        {
            await _modelService.EditModelAsync(model);
            return Redirect("~/Home/Index");
        }
    }
}
