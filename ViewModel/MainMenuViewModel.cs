using Template.Utility;
using System.Windows.Input;

namespace Template.ViewModel
{
    public class MainMenuViewModel : BaseViewModel
    {
        public ICommand GoToSettings => new Command(() =>
        {
            ChangeView(new SettingsViewModel());
        });
    }
}