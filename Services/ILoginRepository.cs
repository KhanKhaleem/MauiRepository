using MyFirstMAUI_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUI_Project.Servises
{
    public interface ILoginRepository
    {
        public void SignIn(UserInfo userInfo);
        public Task<int>Login(string UserName , string Password);
    }
}
