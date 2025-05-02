using AutoMapper;
using FireArmsInventoryManagementSystem.Models;
using FireArmsInventoryManagementSystem.Models.Dto;

namespace FireArmsInventoryManagementSystem.Mapping
{
    public class Form4473MappingProfile : Profile
    {
        public Form4473MappingProfile()
        {
            // Map entity to DTO and reverse
            CreateMap<Form4473Record, Form4473RecordDto>().ReverseMap();

            CreateMap<Form4473FirearmLine, Form4473FirearmLineDto>().ReverseMap();

           

            CreateMap<NicsResponseType, string>()
                .ConvertUsing(src => src.ToString());
        }
    }
}
