using App.Core.ViewModels.Base;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;

namespace App.Core.ViewModels.Home
{
    [MvxFromStoryboard("MyStoryboard")]
    public class ThirdViewModel : BaseViewModel
    {

        public IMvxCommand goBack
        {
            get { return new MvxCommand(() => ShowViewModel<InfoViewModel>()); }
        }
    }
}