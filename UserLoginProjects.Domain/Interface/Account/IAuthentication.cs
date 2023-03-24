namespace UserLoginProject.Domain.Interface.Account
{
    public interface IAuthentication
    {
        Task<string?> Auth(string email, string password);
    }
}
