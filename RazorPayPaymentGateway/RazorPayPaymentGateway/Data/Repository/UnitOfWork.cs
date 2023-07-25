using RazorPayPaymentGateway.Data.Repository.IRepository;

namespace RazorPayPaymentGateway.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _Context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _Context = context;
            ApplicationUser=new ApplicationUserRepository(_Context);
            Order = new OrderRepository(_Context);
            State = new StateRepository(_Context);
            City = new CityRepository(_Context);
            Country = new CountryRepository(_Context);
        }
        public IApplicationUser ApplicationUser { get; private set; }

        public ICountryRepository Country { get; private set; }

        public IStateRepository State { get; private set; }

        public ICityRepository City { get; private set; }

        public IOrderRepository Order { get; private set; }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
