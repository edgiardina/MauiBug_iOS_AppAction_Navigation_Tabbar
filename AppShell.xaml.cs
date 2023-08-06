namespace MauiBug_iOS_AppAction_Navigation_Tabbar;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("subpage", typeof(MainPage));
    }
}
