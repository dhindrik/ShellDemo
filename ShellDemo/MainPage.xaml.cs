namespace ShellDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender == ShowTabDemo)
            {
                App.Current!.Windows[0].Page = new TabDemo.TabShell();
            }
            else if (sender == ShowFlyoutDemo)
            {
                App.Current!.Windows[0].Page = new FlyoutDemo.FlyoutShell();
            }
            else if (sender == ShowFlyoutCustomDemo)
            {
                App.Current!.Windows[0].Page = new CustomFlyoutDemo.FlyoutShell();
            }
            else if (sender == ShowFlyoutFullCustomDemo)
            {
                App.Current!.Windows[0].Page = new CustomFlyoutDemo.CustomFlyoutShell();
            }
            else if (sender == ShowNavigationDemo)
            {
                App.Current!.Windows[0].Page = new NavigationDemo.NavigationShell();
            }
            else if (sender == ShowSearchDemo)
            {
                App.Current!.Windows[0].Page = new SearchDemo.SearchShell();
            }
        }
    }

}
