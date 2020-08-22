using AutoMapper;
using TestTaskToALEF.DataModels;
using TestTaskToALEF.Models;

namespace TestTaskToALEF.Mappers
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            CreateMap<Model, ModelData>();//"преобразование" типа Model в тип ModelData
            CreateMap<ModelData, Model>();//преобразование типа ModelData в тип Model
        }
    }
}
