﻿using Microsoft.Extensions.Logging;

namespace MauiBug_iOS_AppAction_Navigation_Tabbar;

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
            .ConfigureEssentials(essentials =>
            {
                //TODO: it's unclear whether icons must be in the Resources/Images folder or in the Platforms/{platform} folder
                essentials
                    .AddAppAction("page1", "Page 1") //works and changes selected tab
                    .AddAppAction("page2", "Page 2") //works and changes selected tab
                    .AddAppAction("page3/subpage", "Page3/subpage") //does not change active tab (but puts subpage in a nav stack underneath page3 tab)
                    .OnAppAction(App.HandleAppActions);

                essentials.UseVersionTracking();
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
