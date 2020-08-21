//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TestTaskToALEF.DataModels;
//using TestTaskToALEF.Models;
//using TestTaskToALEF.Services;

//namespace TestTaskToALEF.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class ModelController : ControllerBase
//    {
//        private readonly IModelService _modelService;

//        public ModelController(IModelService modelService)
//        {
//            _modelService = modelService;
//        }

//        [HttpGet]
//        public async Task<IEnumerable<ModelData>> Get()
//        {
//            return await _modelService.GetModelsAsync();
//        }

//        //baseurl/brand/id
//        [HttpGet("{id}")]
//        public async Task<Model> Get(int id)
//        {
//            var data = await _modelService.GetModelAsync(id);
//            return new Model {Id = data.Id, Value=data.Value, Name=data.Name };
//        }


//        [HttpPost]
//        public async Task Post(Model model)
//        {
//            await _modelService.AddModelAsync(model);
//            //Redirect("/Home/Index.cshtml");
//        }

//        [HttpDelete]
//        public async Task Delete(int id)
//        {
//            await _modelService.DeleteModelAsync(id);
//        }
//    }
//}
