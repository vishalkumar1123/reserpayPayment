using System.Linq.Expressions;

namespace RazorPayPaymentGateway.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> OrderBy = null,
            string includeProperties = null
            );
        T FirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null  //Category, CoverType
            );
        void Add(T entity);  //For Save
        void Remove(T entity); //for Delete
        void Remove(int id);  // for Delete id
        void RemoveRange(IEnumerable<T> entity);  //Delete Range
    }
}
