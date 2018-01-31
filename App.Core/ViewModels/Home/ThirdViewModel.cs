using App.Core.Models;
using App.Core.Services;
using App.Core.ViewModels.Base;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;

namespace App.Core.ViewModels.Home
{
    [MvxFromStoryboard("MyStoryboard")]
    public class ThirdViewModel : BaseViewModel
    {
        private User _user;

        public IMvxCommand goBack
        {
            get { return new MvxCommand(() => ShowViewModel<InfoViewModel>()); }
        }

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                RaisePropertyChanged(() => User);
            }
        }

        private readonly IUserDataService _userDataService;

        public ThirdViewModel(IUserDataService userDataService)
        {
            _userDataService = userDataService;
        }

        public MvxCommand ReloadDataCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    this.User = _userDataService.GetActiveUser();
                    
                });
            }
        }
    }
}