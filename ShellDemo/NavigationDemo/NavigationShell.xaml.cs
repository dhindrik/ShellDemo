using ShellDemo.Pages;

namespace ShellDemo.NavigationDemo;

public partial class NavigationShell
{
    public NavigationShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("settings", typeof(SettingsPage));
        Routing.RegisterRoute("details", typeof(DetailsPage));
    }
}