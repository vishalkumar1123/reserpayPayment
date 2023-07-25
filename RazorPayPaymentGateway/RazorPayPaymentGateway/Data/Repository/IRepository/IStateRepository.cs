using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Data.Repository.IRepository
{
    public interface IStateRepository:IRepository<State>
    {
        void Update(State state);   
    }
}
