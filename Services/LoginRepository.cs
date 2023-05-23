using __XamlGeneratedCode__;
using MyFirstMAUI_Project.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUI_Project.Servises
{
    public class LoginRepository : ILoginRepository
    {
        private SQLiteAsyncConnection _connection;
        public LoginRepository()
        {
            SetUp();
        }
        private async void SetUp()
        {
            if (_connection == null)
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Login.db3");
                _connection = new SQLiteAsyncConnection(path);
               await  _connection.CreateTableAsync<UserInfo>();
            }
        }
        public void SignIn(UserInfo userInfo)
        {
           _connection.InsertAsync(userInfo);
        }

        public async Task<int> Login(string UserName, string Password)
        {
            var user = await _connection.Table<UserInfo>().FirstOrDefaultAsync(x=> x.UserName == UserName && x.UserPassword == Password);
            return 0;

        }
    }
}
