using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnSite.Models;

namespace MyOwnSite.BusinessService
{
    public interface IUserService
    {
        User FindUserByLogin(string login);

        User FindUserById(int id);

        bool OnLoginValidate(User user);

        User FindUserByEmail(string email);

        void Insert(UserForm userForm);
    }
}
