using AutoMapper;
using DomainLayer.Models;
using RazorCoreWebApplication.Models.GeneralDto;

namespace RazorCoreWebApplication.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Employees, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeDto, Employees>().ReverseMap();

            CreateMap<Departments, DepartmentDto>().ReverseMap();
            CreateMap<DepartmentDto, Departments>().ReverseMap();
        }
    }
}
