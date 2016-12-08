using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Support.V4;
using News.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Binding.Droid.BindingContext;

namespace News.Droid.Views
{
    [MvxFragment(typeof(FirstViewModel), 2131361878)] //Resource.Id.content_frame)]
    [Register("news.droid.views.FragmentView")]
    public class FragmentView : MvxFragment<FragmentViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.FragmentView, null);

            return view;
        }
    }
}