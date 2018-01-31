using System;
using MvvmCross.iOS.Views;
using UIKit;
using MvvmCross.Core.ViewModels;

namespace NavigationStoryBoard.Views
{
    public class BaseViewController<TViewModel> : MvxViewController
    {

        public BaseViewController(IntPtr handle) : base(handle)
        {
        }

        #region Fields

        protected bool NavigationBarEnabled = false;

        public new TViewModel ViewModel
        {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = (IMvxViewModel)value; }
        }

        #endregion

        #region Public Methods

        public override void ViewDidLoad()
        {
            // EdgesForExtendedLayout = UIRectEdge.None;
            // View.BackgroundColor = UIColor.White;
            this.NavigationController.NavigationBar.BarTintColor = UIColor.White;
            base.ViewDidLoad();
        }

        #endregion
    }
}