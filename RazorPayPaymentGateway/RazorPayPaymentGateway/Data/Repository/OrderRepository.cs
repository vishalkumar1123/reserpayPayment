using RazorPayPaymentGateway.Data.Repository.IRepository;
using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository
{
    public class OrderRepository : Repository<OrderEntity>, IOrderRepository
    {
        private readonly ApplicationDbContext _Context;
        public OrderRepository(ApplicationDbContext context):base(context) 
        {
            _Context = context;
        }
        public void Update(OrderEntity order)
        {
            _Context.Update(order);
        }
    }
}
