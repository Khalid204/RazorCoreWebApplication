using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCoreWebApplication.Models.BaseDto;
using RazorCoreWebApplication.Models.GeneralDto;

namespace RazorCoreWebApplication.ViewModels
{
    public class EmployeeViewModel
    {
        public EmployeeDto Employee { get; set; } = new EmployeeDto();
        public List<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
        public List<DepartmentDto> Departments { get; set; } = new List<DepartmentDto>();
    }
}
