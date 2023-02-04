using DomainLayer.Models;

namespace RazorCoreWebApplication.Models.GeneralDto
{
    public class EmployeeDto : Employees
    {
        public string Department { get; set; }
        public IFormFile? File { get; set; }
    }
}
