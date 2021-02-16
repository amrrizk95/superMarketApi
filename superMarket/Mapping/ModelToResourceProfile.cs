using AutoMapper;
using superMarket.Domain.Models;
using superMarket.Resources;


namespace superMarket.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
