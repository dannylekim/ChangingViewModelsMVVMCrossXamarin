
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace ChangingViewModels.ViewModels
{
    public class FirstViewModel :MvxViewModel
    {
        public ICommand GoCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SecondViewModel>());
            }
        }
    }

}


