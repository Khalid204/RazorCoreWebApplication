using AutoMapper;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCoreWebApplication.Models.GeneralDto;
using RazorCoreWebApplication.Utilities;
using RazorCoreWebApplication.ViewModels;
using ServiceLayer;

namespace RazorCoreWebApplication.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public IndexModel(IEmployeeService employeeService, IDepartmentService departmentService, IMapper mapper)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            _mapper = mapper;
        }

        [BindProperty(SupportsGet =true)]
        public EmployeeViewModel Employee { get; set; }
        public void OnGet()
        {
            var employees = _employeeService.GetAll().
                            GroupJoin(_departmentService.GetAll(),
                            emp => emp.DepartmentId, dept => dept.DeptId,
                            (emp, dept) => new { emp, dept }).
                            SelectMany(x => x.dept.DefaultIfEmpty(),
                            (employee, department) => new { employee,department });

            foreach (var employee in employees) 
            {
                Employee.Employees.Add(new EmployeeDto 
                { 
                    EmpId = employee.employee.emp.EmpId,
                    EmpName = employee.employee.emp.EmpName,
                    EmpCode = employee.employee.emp.EmpCode,
                    Salary = employee.employee.emp.Salary,
                    Gender = employee.employee.emp.Gender,
                    AddressType = employee.employee.emp.AddressType,
                    Address = employee.employee.emp.Address,
                    DepartmentId = employee.employee.emp.DepartmentId,
                    Department = employee.department?.DeptName,
                    IsActive = employee.employee.emp.IsActive,
                    PhotoPath = employee.employee.emp.PhotoPath
                });
            }
        }

        public IActionResult OnPostDelete(int id)
        {

            DomainLayer.Models.Employees employee = _mapper.Map<DomainLayer.Models.Employees>(_employeeService.GetById(id));
            if (employee.PhotoPath != null)
            {
                FileUploadProcess.DeleteFile(employee.PhotoPath);
            }
            _employeeService.Delete(id);
            return RedirectToPage("Index");
        }
    }
}
