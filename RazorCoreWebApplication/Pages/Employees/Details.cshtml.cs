using AutoMapper;
using DomainLayer.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCoreWebApplication.Models.GeneralDto;
using RazorCoreWebApplication.Utilities;
using RazorCoreWebApplication.ViewModels;
using ServiceLayer;

namespace RazorCoreWebApplication.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public DetailsModel(IEmployeeService employeeService, IDepartmentService departmentService, IMapper mapper)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            _mapper = mapper;
        }

        [BindProperty(SupportsGet = true)]
        public EmployeeViewModel EmployeeDetails { get; set; }
        public void OnGet(int id = 0)
        {
            if (id > 0) 
            {
                EmployeeDetails.Employee = _mapper.Map<EmployeeDto>(_employeeService.GetById(id));
            }

            EmployeeDetails.Departments = _mapper.Map<List<DepartmentDto>>(_departmentService.GetAll());
        }

        public IActionResult OnPost()
        {
            DomainLayer.Models.Employees employee = _mapper.Map<DomainLayer.Models.Employees>(EmployeeDetails.Employee);
            if (EmployeeDetails.Employee.File != null)
            {
                if (EmployeeDetails.Employee.PhotoPath != null)
                {
                    FileUploadProcess.DeleteFile(EmployeeDetails.Employee.PhotoPath);
                }
                employee.PhotoPath = FileUploadProcess.UploadFile(EmployeeDetails.Employee.File);
            }
            if (EmployeeDetails.Employee.EmpId > 0)
            {
                _employeeService.Update(employee);
            }
            else 
            {
                _employeeService.Insert(employee);
            }

           
            return RedirectToPage("Index");
        }
    }
}
