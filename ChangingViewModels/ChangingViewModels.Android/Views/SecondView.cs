using Android.App;
using MvvmCross.Droid.Views;

namespace ChangingViewModels.Droid.Views
{
    [Activity(Label = "SecondView")]
    public class SecondView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Second);
        }
    }
}