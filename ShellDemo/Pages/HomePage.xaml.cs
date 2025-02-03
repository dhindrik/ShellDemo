namespace ShellDemo.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private void Map_Clicked(object sender, EventArgs e)
    {
        _ = Shell.Current.GoToAsync("//items/map");
    }

    private void Settings_Clicked(object sender, EventArgs e)
    {
        _ = Shell.Current.GoToAsync("settings");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _ = Shell.Current.GoToAsync($"details?name={NameEntry.Text}");

        //var parameters = new Dictionary<string, object>()
        //{
        //    { "name", NameEntry.Text }
        //};

        //_ = Shell.Current.GoToAsync($"details", parameters);
    }
}