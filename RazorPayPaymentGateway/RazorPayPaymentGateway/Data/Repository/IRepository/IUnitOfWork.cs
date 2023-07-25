namespace RazorPayPaymentGateway.Data.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IApplicationUser ApplicationUser { get; }
        ICountryRepository Country { get; }
        IStateRepository State { get; }
        ICityRepository City { get; }
        IOrderRepository Order { get; }
        void Save();
    }
}
