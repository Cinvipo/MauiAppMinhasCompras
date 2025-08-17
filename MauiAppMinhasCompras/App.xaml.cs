using MauiAppMinhasCompras.Views;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Ensure a Window object is always returned to fix CS0161
            return new Window(new NavigationPage(new Views.ListaProduto()));
        }
    }
}   