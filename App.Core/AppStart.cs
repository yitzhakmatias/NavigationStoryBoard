using App.Core.Services;
using App.Core.ViewModels.Base;
using App.Core.ViewModels.Home;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace App.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        

        public AppStart()
        {
           
        }

        /// <summary>
        /// Start is called on startup of the app
        /// Hint contains information in case the app is started with extra parameters
        /// </summary>
        public async void Start(object hint = null)
        {
            var userService = Mvx.Resolve<IUserDataService>();
            await userService.Login("gillcleeren", "123456");
            // If your application uses a secure API this first call attempts to log the user into the application
            // using any credentials stored from a previous session.  If there are
            // none stored we should present the login screen, else go straight into the app
            ShowViewModel<MainViewModel>();
            //ShowViewModel<ThirdViewModel>();
           
        }
    }
}