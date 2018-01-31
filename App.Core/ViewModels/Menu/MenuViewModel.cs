using App.Core.ViewModels.Base;
using App.Core.ViewModels.Home;
using MvvmCross.Core.ViewModels;

namespace App.Core.ViewModels.Menu
{
    class MenuViewModel : BaseViewModel 
    {
        protected MenuViewModel()
        {
        }

        public IMvxCommand ShowHomeCommand
        {
            get { return new MvxCommand(ShowHomeExecuted); }
        }

        private void ShowHomeExecuted()
        {
            ShowViewModel<HomeViewModel>();
        }

        public IMvxCommand ShowSettingCommand
        {
            get { return new MvxCommand(ShowSettingsExecuted); }
        }

        private void ShowSettingsExecuted()
        {
            ShowViewModel<SettingsViewModel>();
        }

       /* public IMvxCommand ShowHelpCommand
        {
            get { return new MvxCommand(ShowHelpExecuted); }
        }

        private void ShowHelpExecuted()
        {
            ShowViewModel<HelpAndFeedbackViewModel>();
        }*/
    }
}
