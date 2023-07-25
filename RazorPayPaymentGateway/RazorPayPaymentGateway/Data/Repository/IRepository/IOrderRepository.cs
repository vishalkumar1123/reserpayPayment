using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository.IRepository
{
    public interface IOrderRepository:IRepository<OrderEntity>
    {
        void Update(OrderEntity order);
    }
}
