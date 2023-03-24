using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginProject.Application.Interfaces.Account
{
    public interface IDeleteAccountService
    {
        Task Delete(Guid id);
    }
}
