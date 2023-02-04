using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public partial class Employees
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpCode { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? Salary { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? AddressType { get; set; }
    public string? PhotoPath { get; set; }
}
