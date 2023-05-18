using MyFirstMAUI_Project.Models;
using MyFirstMAUI_Project.Servises;
using MyFirstMAUI_Project.ViwModels;

namespace MyFirstMAUI_Project;

public partial class LoginPage : ContentPage
{
//     ILoginRepository repository;
//    public LoginPage(ILoginRepository repository)
//      {
//         this.repository = repository;
//      }
    public LoginPage()
	{
		InitializeComponent();
    }
    public async void OnSignUpTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignInPage());
    }
    public void SingInClickd(object sender, EventArgs e)
    {
        //string username = UserName.Text;
        //string password = Password.Text;
        //repository.Login(username, password);
    }
}
