using RazorPayPaymentGateway.Data.Repository.IRepository;
using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        private readonly ApplicationDbContext _Context;
        public CityRepository(ApplicationDbContext context):base(context)
        {
            _Context = context;
        }
        public void Update(City city)
        {
           _Context.Update(city);
        }
    }
}
