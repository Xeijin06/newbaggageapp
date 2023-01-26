using BaggageApp.Services;

namespace BaggageApp;

public partial class App : Application
{
    public static BpmApiManager BpmApiManager { get; private set; }

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
