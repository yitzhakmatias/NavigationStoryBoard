using System;
using App.Core.ViewModels.Base;
using Foundation;
using MvvmCross.iOS.Views;
using UIKit;

namespace NavigationStoryBoard.Views
{
    [MvxFromStoryboard("Main")]
    public partial class MainView : MvxViewController// BaseViewController<MainViewModel>
    {
        public new MainViewModel ViewModel
        {
            get { return (MainViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ViewModel.ShowHome();
        }
        public MainView(IntPtr handle) : base(handle)
        {
        }
    }
}