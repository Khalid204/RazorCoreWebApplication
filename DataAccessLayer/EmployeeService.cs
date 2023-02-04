using DomainLayer.Models;
using RepositoryLayer.GenericRepository;
using System.Xml;

namespace ServiceLayer
{
    public class EmployeeService : IEmployeeService
    {

        private IGenericRepository<Employees> _repository;
        public EmployeeService(IGenericRepository<Employees> genericRepository)
        {
            _repository = genericRepository;
        }
        public List<Employees> GetAll()
        {
            return _repository.GetAll().ToList();            
        }

        public Employees GetById(object id)
        {
            return _repository.GetById(id);
        }

        public void Insert(Employees model)
        {
            _repository.Insert(model);
            _repository.Save();
        }

        public void Update(Employees model)
        {
            _repository.Update(model);
            _repository.Save();
        }

        public void Delete(object id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}
