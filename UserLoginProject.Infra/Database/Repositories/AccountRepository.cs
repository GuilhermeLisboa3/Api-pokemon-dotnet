using UserLoginProject.Infra.Database.Helpers;
using UserLoginProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using UserLoginProject.Domain.Contracts.Repository.Account;

namespace UserLoginProject.Infra.Database.Repositories
{
    public class AccountRepository : CheckAccountByEmail, AddAccountRepo, LoadAccountByEmail, CheckAccountById, DeleteAccount
    {
        private readonly DataContext _context;
        public AccountRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> Add(User userModel)
        {
           userModel.Id = Guid.NewGuid();
           var user = await _context.User.AddAsync(userModel);
           await _context.SaveChangesAsync();
           return userModel;
        }

        public async Task<bool> CheckByEmail(string email)
        {
            var exist = _context.User.SingleOrDefault(usuario => usuario.Email == email);
            return exist != null ? true : false;
        }

        public async Task<bool> CheckById(Guid id)
        {
            var exist = _context.User.SingleOrDefault(usuario => usuario.Id == id);
            return exist != null ? true : false;
        }

        public async Task Delete(Guid id)
        {
            var user = await _context.User.FindAsync(id);
            _context.Entry(user).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<User> LoadByEmail(string email)
        {
            var user = _context.User.SingleOrDefault( usuario => usuario.Email == email);
            return user != null ? user : null;
        }
    }
}
