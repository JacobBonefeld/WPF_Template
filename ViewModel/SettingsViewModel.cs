using Template.Utility;
using System.Windows.Input;

namespace Template.ViewModel
{
    public class SettingsViewModel : BaseViewModel
    {
        public ICommand GoToMainMenu => new Command(() =>
        {
            ChangeView(new MainMenuViewModel());
        });
    }
}