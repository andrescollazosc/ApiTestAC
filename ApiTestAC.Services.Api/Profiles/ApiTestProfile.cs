using ApiTestAC.Domain.Entities;
using ApiTestAC.Services.Dto;
using AutoMapper;

namespace ApiTestAC.Services.Api.Profiles
{
    public class ApiTestProfile : Profile
    {
        public ApiTestProfile()
        {
            this.CreateMap<Operator, OperatorDto>().ReverseMap();
        }
    }
}
