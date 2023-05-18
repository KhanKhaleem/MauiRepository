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

        public void Login(string username, string password)
        {
            if (username == "kaleem" || password == "123")
            {
                Shell.Current.DisplayAlert("Welcome Kaleem", "Login", "OK");
            }
            else
            {
                Shell.Current.DisplayAlert("Please try again", "Login", "OK");
            }
        }
    }
}
