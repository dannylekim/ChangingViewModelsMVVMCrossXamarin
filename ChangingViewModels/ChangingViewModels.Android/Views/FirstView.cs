using Android.App;
using MvvmCross.Droid.Views;

namespace ChangingViewModels.Droid.Views
{
    [Activity(Label = "FirstView", MainLauncher = true)]
    public class FirstView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_First);
        }
    }
}