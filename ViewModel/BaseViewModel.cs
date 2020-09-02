using GalaSoft.MvvmLight.Messaging;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Template.Utility
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newViewModel"> The view model which will be passed to the listener of the message</param>
        protected void ChangeView(BaseViewModel newViewModel)
        {
            Messenger.Default.Send<BaseViewModel>(newViewModel);
        }
    }
}