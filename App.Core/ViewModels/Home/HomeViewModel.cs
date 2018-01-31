using App.Core.ViewModels.Base;
using App.Core.ViewModels.Menu;
using MvvmCross.Core.ViewModels;

namespace App.Core.ViewModels.Home
{
   public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
           // Recycler = new RecyclerViewModel();
        }

        /// <summary>Gets the recycler.</summary>
        /// <value>The recycler.</value>
      //  public RecyclerViewModel Recycler { get; private set; }

        public IMvxCommand GotoSettings
        {
            get { return new MvxCommand(() => ShowViewModel<SettingsViewModel>()); }
        }
        public IMvxCommand GotoInfo
        {
            get { return new MvxCommand(() => ShowViewModel<InfoViewModel>()); }
        }
    }
}
