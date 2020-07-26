using System.Collections.ObjectModel;

namespace UWP.CollectionView.Scroll.Crash
{
    public class CrashPageViewModel
    {
        public ObservableCollection<string> Strings { get; } = new ObservableCollection<string>();
    }
}
