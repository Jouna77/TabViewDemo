using Xamarin.Forms;

[assembly: ExportFont("FontAwesome5BrandsRegular400.otf", Alias = "FontAwesomeBrands")]
[assembly: ExportFont("FontAwesome5FreeRegular400.otf", Alias = "FontAwesomeRegular")]
[assembly: ExportFont("FontAwesome5FreeSolid900.otf", Alias = "FontAwesomeSolid")]

namespace TabViewDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}