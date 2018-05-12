using cuteqt.Configuration.User;
using cuteqt.Helper.MVVM;
using System.Windows.Media;

namespace cuteqt.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public Settings UserSettings { get; } = new Settings() { Background = new SolidColorBrush(Colors.Black), Width = 800 };
    }
}