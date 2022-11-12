namespace TulipLuxury.Data.ContractsRepo

{
    public interface ICustomerRepository
    {
        string CollectCustomerDetails(string CustomerId);
        string getCustomerByEmail(string email);
    }
}