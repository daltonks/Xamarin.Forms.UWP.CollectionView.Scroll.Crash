using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace UWP.CollectionView.Scroll.Crash
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCrashClicked(object sender, EventArgs e)
        {
            var crashPage = new CrashPage();
            Application.Current.MainPage = crashPage;
            crashPage.Scroll();
        }
    }
}
