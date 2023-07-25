using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository.IRepository
{
    public interface IApplicationUser : IRepository<ApplicationUser>
    {
        void Update(ApplicationUser applicationUser);
    }
}
