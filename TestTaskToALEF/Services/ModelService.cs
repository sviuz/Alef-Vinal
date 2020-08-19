using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TestTaskToALEF.DataModels;
using TestTaskToALEF.Models;

namespace TestTaskToALEF.Services
{
    public class ModelService : IModelService
    {
        private readonly ModelContext _modelContext;
        private readonly IMapper _mapper;

        public ModelService(ModelContext modelContext, IMapper mapper)
        {
            _modelContext = modelContext;
            _mapper = mapper;
        }

        public async Task AddModelAsync(Model model)
        {
            var data = _mapper.Map<ModelData>(model);
            await _modelContext.Models.AddAsync(data);
            await _modelContext.SaveChangesAsync();
        }

        public async Task DeleteModelAsync(int id)
        {
            var data = _modelContext.Models.FirstOrDefault(m => m.Id == id);
            _modelContext.Models.Remove(data);
            await _modelContext.SaveChangesAsync();
        }

        public Task EditModelAsync(Model model)
        {
            var data = _mapper.Map<ModelData>(model);
            return Task.FromResult(new Model { Id = data.Id, Value = data.Value, Name = data.Name });
        }

        public async Task<Model> GetModelAsync(int id)
        {
            var data = _modelContext.Models.FirstOrDefault(m => m.Id == id);
            return new Model { Id = data.Id, Name = data.Name, Value = data.Value };
        }

        public async Task<IEnumerable<ModelData>> GetModelsAsync()
        {
            var data = _modelContext.Models.AsNoTracking().AsEnumerable();
            return data;
        }
    }
}
