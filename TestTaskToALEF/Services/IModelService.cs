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
        Task<IEnumerable<Model>> GetModelsAsync();

        Task AddModelAsync(Model model);

        Task<Model> GetModelAsync(int id);

        Task EditModelAsync(ModelData model);

        Task DeleteModelAsync(int id);

    }
}
