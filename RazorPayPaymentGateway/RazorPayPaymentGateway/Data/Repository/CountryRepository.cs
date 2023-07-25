using RazorPayPaymentGateway.Data.Repository.IRepository;
using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private readonly ApplicationDbContext _Context;
        public CountryRepository(ApplicationDbContext context):base(context)
        {
            _Context = context;
        }
        public void Update(Country country)
        {
           _Context.Update(country);
        }
    }
}
