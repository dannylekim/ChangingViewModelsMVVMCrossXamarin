using ChangingViewModels.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace ChangingViewModels
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<FirstViewModel>());
        }
        
    }
}
