using Xamarin.Forms;

namespace TabViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TabViewItem_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {
            DisplayAlert("Title", "Item tapped", "Ok");
        }
    }
}