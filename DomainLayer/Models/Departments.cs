using System;
using System.Collections.Generic;

namespace DomainLayer.Models;
public partial class Departments
{
    public int DeptId { get; set; }

    public string? DeptName { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdateOn { get; set; }
}
