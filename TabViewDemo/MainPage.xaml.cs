using System;
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

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            this.TabView.SelectedIndex =Convert.ToInt32(btn.StyleId);
        }
    }
}