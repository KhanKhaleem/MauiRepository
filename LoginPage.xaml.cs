using MyFirstMAUI_Project.Servises;
using MyFirstMAUI_Project.Views;

namespace MyFirstMAUI_Project;

public partial class LoginPage : ContentPage
{
    ILoginRepository repository = new LoginRepository();
    public LoginPage()
	{
		InitializeComponent();
    }
    public async void OnSignUpTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignInPage());
    }
    public async void SingInClickd(object sender, EventArgs e)
    {
        string username = UserName.Text;
        string password = Password.Text;       
        var loginuser =repository.Login(username , password);
        if (loginuser.Id >0) 
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
}
