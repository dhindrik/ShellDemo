namespace ShellDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage());
        }

        public static void ShowMain()
        {
            App.Current.Windows[0].Page = new MainPage();
        }
    }
}