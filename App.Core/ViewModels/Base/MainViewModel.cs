using App.Core.ViewModels.Home;

namespace App.Core.ViewModels.Base
{
    

    public class MainViewModel : BaseViewModel
    {
   
        public void ShowHome()
        {
            ShowViewModel<HomeViewModel>();
        }
        public void ShowInfoModal()
        {
            ShowViewModel<InfoViewModel>();
        }

    }
}
