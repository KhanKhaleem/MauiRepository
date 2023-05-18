namespace MyFirstMAUI_Project;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}
    private async void OnSignInTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}