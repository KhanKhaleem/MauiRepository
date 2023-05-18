using MyFirstMAUI_Project.Models;
using MyFirstMAUI_Project.Servises;

namespace MyFirstMAUI_Project;

public partial class SignInPage : ContentPage
{
    ILoginRepository repository;

    public SignInPage()
    {
        InitializeComponent();
    }

    public SignInPage(ILoginRepository repository)
	{
        this.repository = repository;
	}
    private async void OnSignInTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void SingUpClick(object sender, EventArgs e)
    {
        string username = UserName.Text;
        string email = Email.Text;
        string password = Password.Text;
        UserInfo user = new UserInfo { UserName = username, Email = email, UserPassword = password };
        repository.SignIn(user);
        await Navigation.PushAsync(new LoginPage());
    }
}
