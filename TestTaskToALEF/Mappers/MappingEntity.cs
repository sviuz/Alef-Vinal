using AutoMapper;
using TestTaskToALEF.DataModels;
using TestTaskToALEF.Models;

namespace TestTaskToALEF.Mappers
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            CreateMap<Model, ModelData>();
            CreateMap<ModelData, Model>();
        }
    }
}
