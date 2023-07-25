using RazorPayPaymentGateway.Data.Repository.IRepository;
using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUser
    {
        private readonly ApplicationDbContext _Context;
        public ApplicationUserRepository(ApplicationDbContext context):base(context)
        {
                _Context = context;
        }

        public void Update(ApplicationUser applicationUser)
        {
           _Context.Update(applicationUser);
        }
    }
}
