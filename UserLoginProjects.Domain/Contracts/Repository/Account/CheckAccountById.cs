using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginProject.Domain.Contracts.Repository.Account
{
    public interface CheckAccountById
    {
        Task<bool> CheckById(Guid id);
    }
}
