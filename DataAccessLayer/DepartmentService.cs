using DomainLayer.Models;
using RepositoryLayer.GenericRepository;

namespace ServiceLayer
{
    public class DepartmentService : IDepartmentService
    {
        private IGenericRepository<Departments> _repository;
        public DepartmentService(IGenericRepository<Departments> genericRepository)
        {
            _repository = genericRepository;
        }
        public List<Departments> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public Departments GetById(object id)
        {
            return _repository.GetById(id);
        }
    }
}
