using System.ComponentModel;
using Xamarin.Forms;

namespace UWP.CollectionView.Scroll.Crash
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class CrashPage : ContentPage
    {
        public CrashPage()
        {
            InitializeComponent();

            var viewModel = new CrashPageViewModel();
            for (var i = 0; i < 100; i++)
            {
                viewModel.Strings.Add(i.ToString());
            }

            BindingContext = viewModel;
        }

        public void Scroll()
        {
            CollectionView.ScrollTo(99);
        }
    }
}
