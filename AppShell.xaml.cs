﻿namespace MyFirstMAUI_Project;

public partial class AppShell : Shell
{
  
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
    }
}
