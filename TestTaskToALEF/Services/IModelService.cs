using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskToALEF.DataModels;
using TestTaskToALEF.Models;

namespace TestTaskToALEF.Services
{
    public interface IModelService
    {
        Task<IEnumerable<ModelData>> GetModelsAsync();

        Task AddModelAsync(Model model);

        Task<Model> GetModelAsync(int id);

        Task EditModelAsync(Model model);

        Task DeleteModelAsync(int id);

    }
}
