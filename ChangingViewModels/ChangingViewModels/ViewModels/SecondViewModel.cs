
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace ChangingViewModels.ViewModels
{
    class SecondViewModel : MvxViewModel
    {
        public ICommand GoCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<FirstViewModel>());
            }
        }
    }
}
