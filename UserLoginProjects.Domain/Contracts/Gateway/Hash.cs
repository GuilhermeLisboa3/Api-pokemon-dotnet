namespace UserLoginProject.Domain.Contracts.Gateway
{
    public interface Hash
    {
        Task<string> Generate(string plaintext);
        Task<bool> Verify(string plaintext, string digest);
    }
}
