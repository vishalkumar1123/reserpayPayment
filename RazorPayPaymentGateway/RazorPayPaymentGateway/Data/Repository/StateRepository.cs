using RazorPayPaymentGateway.Data.Repository.IRepository;
using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        private readonly ApplicationDbContext _Context;
        public StateRepository(ApplicationDbContext context):base(context)
        {
            _Context = context;
        }
        public void Update(State state)
        {
            _Context.Update(state);
        }
    }
}
