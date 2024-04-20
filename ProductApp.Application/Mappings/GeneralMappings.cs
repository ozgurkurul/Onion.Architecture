using AutoMapper;
using ProductApp.Application.Features.Commands.CreateProduct;

namespace ProductApp.Application.Mappings
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<Domain.Entities.Product, Dtos.ProductViewDto>().ReverseMap();

            CreateMap<Domain.Entities.Product, Dtos.GetProductByIdViewDto>().ReverseMap();

            CreateMap<Domain.Entities.Product, CreateProductCommand>().ReverseMap();
        }
    }
}
