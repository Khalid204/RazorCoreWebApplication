using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IDepartmentService
    {
        List<Departments> GetAll();
        Departments GetById(object id);
    }
}
