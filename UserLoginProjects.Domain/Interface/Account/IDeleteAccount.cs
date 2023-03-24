using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginProject.Domain.Interface.Account
{
    public interface IDeleteAccount
    {
        Task<bool> Delete(Guid id);
    }
}
