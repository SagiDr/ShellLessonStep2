using Microsoft.Extensions.Logging;
using ShellLessonStep2.Services;
using ShellLessonStep2.ViewModels;
using ShellLessonStep2.Views;

namespace ShellLessonStep2;

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
			})
            .RegisterDataServices().RegisterViewModels().RegisterViews();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<AnimalService>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<CatsViewModel>();
        builder.Services.AddSingleton<DogsViewModel>();
        builder.Services.AddSingleton<MonkeysViewModels>();
        builder.Services.AddSingleton<ElephantsViewModel>();
        builder.Services.AddSingleton<BearsViewModel>();

        //--------Transient ViewModels
        builder.Services.AddTransient<AnimalDetailsViewModel>();

        return builder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<Cats>();
        builder.Services.AddSingleton<Dogs>();
        builder.Services.AddSingleton<Monkeys>();
        builder.Services.AddSingleton<Elephants>();
        builder.Services.AddSingleton<Bears>();

        //--------Transient ViewModels
        builder.Services.AddTransient<AnimalDetailsView>();

        return builder;
    }
}
