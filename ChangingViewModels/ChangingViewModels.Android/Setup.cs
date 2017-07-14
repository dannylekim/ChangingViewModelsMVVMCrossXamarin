using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using ChangingViewModels;

namespace ChangingViewModels.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
        : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}