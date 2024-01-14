using PSI.Application.Interface;
using PSI.Domain.Models;
using PSI.Infraestructure;


namespace PSI.Infraestructure.Repositories
{
    public class RepositoryImplementation<T> : IRepositoryModel<T> where T : class
    {
        public PSIContext PSIContext { get; set; }

        public RepositoryImplementation(PSIContext _PSIContext) 
        {
            _PSIContext = PSIContext;
        }

        public void Create(T entity)
        {
            PSIContext.Set<T>().Add(entity);
        }

        public List<T> Get(T entity)
        {
            var result = PSIContext.Set<T>().ToList();
            return result;
        }

        public T GetById(int Id)
        {
            var result = PSIContext.Set<T>().Find(Id);
            return result;
        }

        public void Update(T entity)
        {
            PSIContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            PSIContext.Set<T>().Remove(entity);
        }

        public void DeleteById(int Id)
        {
            var result = PSIContext.Set<T>().Find(Id);
            PSIContext.Set<T>().Remove(result);
        }
    }
}
