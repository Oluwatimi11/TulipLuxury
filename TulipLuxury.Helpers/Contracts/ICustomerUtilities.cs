namespace TulipLuxury.Helpers.Contracts
{
    public interface ICustomerUtilities
    {
        string ChangeToTitle(string str);
        string GenerateCustomerId();
        string GenerateRandomNumber(int length, string prefix);
        string PasswordHash(string Password);
        string RemoveDigits(string str);
    }
}