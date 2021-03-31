using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp.Interface
{
    public interface IUserService
    {
        bool AddUser(string firname, string surname, string email, DateTime dateOfBirth, int clientId);
    }
}
