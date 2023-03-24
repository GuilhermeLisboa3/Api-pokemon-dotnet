namespace UserLoginProject.Domain.Contracts.Gateway
{
    public interface Token
    {
        Task<string> Generate(string key);
    }
}
