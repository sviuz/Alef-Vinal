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

        public async Task AddModelAsync(Model model)//Метод добавления модели
        {
            var data = _mapper.Map<ModelData>(model);//преобразовываем нашу модель в необходимый тип данных
            await _modelContext.Models.AddAsync(data);//Добавляем модель в БД
            await _modelContext.SaveChangesAsync();//сохраняем изменения
        }

        public async Task DeleteModelAsync(int id)//Метод удаления элемента (в проекте не используется)
        {
            var data = _modelContext.Models.FirstOrDefault(m => m.Id == id);//происк элемента в БД по Id использую LINQ
            _modelContext.Models.Remove(data);//Удаляем найденную модель из Бд
            await _modelContext.SaveChangesAsync();//сохраняем изменения
        }

        public async Task EditModelAsync(ModelData model)//Метод изменения модели
        {
            _modelContext.Entry(model).State = EntityState.Modified;//позволяем изменить данные нашей модели в БД
            _modelContext.Models.Update(model);//изменяем модель в БД
            await _modelContext.SaveChangesAsync();//сохраняем изменения
        }

        public async Task<Model> GetModelAsync(int id)//Получение модели по id
        {
            var data = _modelContext.Models.AsNoTracking().FirstOrDefault(m => m.Id == id);//поиск модели без кеширования(asnotracking)
            return new Model { Id = data.Id, Name = data.Name, Value = data.Value };//повзращем полученный результат
        }

        public async Task<IEnumerable<Model>> GetModelsAsync()//получение списка всех моделей из БД
        {
            var models = _mapper.Map<IEnumerable<Model>>(
                _modelContext.Models
                .AsNoTracking().AsEnumerable()
                );//преобразовываем полученные данные из бд в нужный тип
            return models;//возвращение списка моделей
        }
    }
}
