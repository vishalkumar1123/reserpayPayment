using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository.IRepository
{
    public interface ICountryRepository:IRepository<Country>
    {
        void Update(Country country);
    }
}
