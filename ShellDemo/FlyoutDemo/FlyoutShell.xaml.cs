namespace ShellDemo.FlyoutDemo;

public partial class FlyoutShell
{
    public FlyoutShell()
    {
        InitializeComponent();
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        _ = Browser.OpenAsync("https://github.com/dhindrik/MauiShellDemo");
    }
}