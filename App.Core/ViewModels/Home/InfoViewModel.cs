using App.Core.ViewModels.Base;
using MvvmCross.Core.ViewModels;

namespace App.Core.ViewModels.Home
{
    public class InfoViewModel : BaseViewModel
    {
        public InfoViewModel()
        {
            Info = "This is info for you...";
        }

        public string Info { get; private set; }
        public IMvxCommand GoThCommand
        {
            get { return new MvxCommand(() => ShowViewModel<ThirdViewModel>()); }
        }


    }
}