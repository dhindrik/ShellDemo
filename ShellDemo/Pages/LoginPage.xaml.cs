namespace ShellDemo.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _ = Shell.Current.GoToAsync("//home");
    }
}