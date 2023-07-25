using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository.IRepository
{
    public interface ICityRepository:IRepository<City>
    {
        void Update(City city);
    }
}
