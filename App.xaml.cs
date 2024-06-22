using JPEDRAZAEXAMEN.VISTAS;

namespace JPEDRAZAEXAMEN
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LOGIN());
        }
    }
}
