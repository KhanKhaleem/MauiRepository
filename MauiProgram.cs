using Microsoft.Extensions.Logging;
using MyFirstMAUI_Project.Models;
using MyFirstMAUI_Project.Servises;
using MyFirstMAUI_Project.ViwModels;

namespace MyFirstMAUI_Project;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//Services
		builder.Services.AddSingleton<ILoginRepository,LoginRepository>();

		//View
		builder.Services.AddSingleton<LoginPage>();

		//View Models
		builder.Services.AddSingleton<UserInfoViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
