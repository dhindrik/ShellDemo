using System.ComponentModel;

namespace ShellDemo.Pages;

public class DetailsViewModel : INotifyPropertyChanged, IQueryAttributable
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public string? Name { get; set; }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Name = query["name"] as string;

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
    }
}
