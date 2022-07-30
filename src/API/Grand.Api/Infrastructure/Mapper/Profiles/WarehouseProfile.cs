using Grand.Api.DTOs.Customers;
using Grand.Api.DTOs.Shipping;
using Grand.Domain.Common;
using Grand.Domain.Shipping;
using Grand.Infrastructure.Mapper;
using AutoMapper;


namespace Grand.Api.Infrastructure.Mapper
{
	public class WarehouseProfile : Profile, IAutoMapperProfile
    {
        public WarehouseProfile()
        {
            CreateMap<Warehouse, WarehouseDto>();
                //.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.AdminComment));
            CreateMap<Address, AddressDto>();
        }

        public int Order => 1;
    }
}
