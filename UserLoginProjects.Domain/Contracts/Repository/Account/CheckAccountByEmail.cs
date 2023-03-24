namespace UserLoginProject.Domain.Contracts.Repository.Account
{
    public interface CheckAccountByEmail
    {
        Task<bool> CheckByEmail(string email);
    }
}
