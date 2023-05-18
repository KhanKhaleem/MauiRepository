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
        public void Login(string username, string password);
    }
}
