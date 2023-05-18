using MyFirstMAUI_Project.ViwModels;

namespace MyFirstMAUI_Project;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
    }
    public async void OnSignUpTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignInPage());
    }
}