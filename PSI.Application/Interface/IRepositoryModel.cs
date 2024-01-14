namespace PSI.Application.Interface
{
    public interface IRepositoryModel<T> where T : class
    {
        void Create(T entity);
        List<T> Get(T entity);
        T GetById(int Id);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int Id);
    }
}
