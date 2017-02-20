namespace ZooSystem.DAL
{
    using System.Collections.Generic;

    public interface IRepository<T> 
        where T: class
    {
        IList<T> GetAll();

        void Add(T entity);

        void Delete(T entity);
        
    }
}
