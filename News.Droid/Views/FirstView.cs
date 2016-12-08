using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using News.Core.ViewModels;

namespace News.Droid.Views
{
    [Activity(Label = "View for FirstViewModel", Theme = "@style/AppTheme")]
    public class FirstView : MvxCachingFragmentCompatActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Title = GetString(Resource.String.ApplicationName);

            SetContentView(Resource.Layout.FirstView);

            if (bundle == null)
                ViewModel.ShowFragment();
        }
    }
}
