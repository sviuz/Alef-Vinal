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

        public async Task<IActionResult> Index()//Начальная страница
        {
            var models = await _modelService.GetModelsAsync();//получение списка моделей из БД через Modelservice
            return View(models);//Передача нашего списка в вид страницы
        }

        [HttpPost]
        public async Task<IActionResult> Add(Model model)
        {
            await _modelService.AddModelAsync(model);//Добавление модели в БД
            return Redirect("~/Home/Index");//после добавления происходит переход на главную страницу
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ModelData model)
        {
            await _modelService.EditModelAsync(model);//Изменение модели
            return Redirect("~/Home/Index");//переход на главную станицу
        }
    }
}
