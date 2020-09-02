using GalaSoft.MvvmLight.Messaging;
using Template.Utility;

namespace Template.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Properties

        private BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        #endregion Properties

        public MainWindowViewModel()
        {
            // Setting initial viewmodel to the main menu
            CurrentViewModel = new MainMenuViewModel();

            // Listens for other viewmodels to request a view change
            Messenger.Default.Register<BaseViewModel>(this, (Action) =>
             {
                 CurrentViewModel = Action;
             });
        }
    }
}