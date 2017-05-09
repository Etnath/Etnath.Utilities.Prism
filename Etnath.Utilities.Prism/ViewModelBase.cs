using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Etnath.Utilities.Prism
{
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        public IView View { get; set; }
        public ViewModelBase(IView view)
        {
            View = view;
            view.ViewModel = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
