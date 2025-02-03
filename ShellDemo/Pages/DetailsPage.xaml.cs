namespace ShellDemo.Pages;

[QueryProperty(nameof(Name), "name")]
public partial class DetailsPage : ContentPage
{
    public string? Name { get; set; }

    public DetailsPage()
    {
        InitializeComponent();

        BindingContext = new DetailsViewModel();
    }
}