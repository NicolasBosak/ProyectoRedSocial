using ProyectoRedSocial.MVVM.Views;

namespace ProyectoRedSocial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashboardPage();
        }
    }
}
