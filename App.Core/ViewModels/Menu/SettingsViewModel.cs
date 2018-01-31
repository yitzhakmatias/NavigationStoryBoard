using App.Core.ViewModels.Base;
using App.Core.ViewModels.Home;
using MvvmCross.Core.ViewModels;

namespace App.Core.ViewModels.Menu
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel()
        {
        }
        public IMvxCommand GoHomeCommand
        {
            get { return new MvxCommand(() => ShowViewModel<HomeViewModel>()); }
        }

    }
}