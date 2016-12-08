using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;

namespace News.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        public FirstViewModel()
        {
            var loader = Mvx.Resolve<IMvxResourceLoader>();
            var contents = loader.GetTextResource("channels.xml");
        }

        public void ShowFragment()
        {
            ShowViewModel<FragmentViewModel>();
        }
    }
}
