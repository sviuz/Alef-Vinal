using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskToALEF.Models;

namespace TestTaskToALEF.Services
{
    public interface IModelService
    {
        Task AddModel(Model model);
        Task<Model> GetModel();
        Task EditModel(Model model);
        Task DeleteModel(int id);
    }
}
