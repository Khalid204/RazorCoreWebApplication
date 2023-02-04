using DomainLayer.BaseEntity;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IEmployeeService
    {
        List<Employees> GetAll();
        Employees GetById(object id);
        void Insert(Employees obj);
        void Update(Employees obj);
        void Delete(object id);
    }
}
