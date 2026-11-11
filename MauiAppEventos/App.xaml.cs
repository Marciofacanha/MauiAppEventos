namespace MauiAppEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new Window(new NavigationPage(new Views.CadastroEvento()));

            window.Width = 400;
            window.Height = 800;

            return window;
        }
    }
}