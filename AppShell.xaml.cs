using MyFirstMAUI_Project.Views;

namespace MyFirstMAUI_Project;

public partial class AppShell : Shell
{
  
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
    }
}
